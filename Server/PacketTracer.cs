using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Server
{
    class PacketTracer
    {
        const int port = 7000; // Порт который будет слушать сервер

        public string usersDatabasePath; // Путь к БД с юзерами

        public string subjectsDatabasePath; // Путь к БД с предметами и вопросами

        IPEndPoint tcpEndPoint = new IPEndPoint(IPAddress.Any, port); // Создание конечной точки подключения

        Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); // Создание сокета (версия IPV4/IPV6, Тип сокета, тип протокола подключения)

        public PacketTracer(string usersDatabasePath, string questionsDatabasePath) // Конструктор класса
        {
            this.usersDatabasePath = usersDatabasePath;
            this.subjectsDatabasePath = questionsDatabasePath;
        }

        public void PacketListenClients() // Метод подключения к серверу
        {
            clientSocket.Bind(tcpEndPoint); //Связывает сокет с локальной конечной точкой

            Console.WriteLine("Сервер запущен.");

            clientSocket.Listen(); //Устанавливает сокет в состояние прослушивания

            Socket listener = clientSocket.Accept(); //Создание слушателя определенного на конкретного клиента

            Console.WriteLine("Клиент подключился к серверу.");

            while (true)
            {
                GetPacketRequest(listener);
            }
        }

        public void GetPacketRequest(Socket lnr) // Метод для получения запроса от клиента
        {
            byte packetid; // поле для уникального id пакета
            byte[] buffer = new byte[256]; // Буффер для данных
            int size = 0; // Переменная для хранения реально полученных байт
            string jsonString = ""; // Строка в которую запишем расшифрованные данные отправленные клиентом
            do
            {
                size = lnr.Receive(buffer); // Получаем количество реально полученных байт
                jsonString += Encoding.UTF8.GetString(buffer, 0, size); // В строку записываем из (буфера, с 1 ячейки, количество)
            }
            while (lnr.Available > 0); //Пока есть данные считываем
            packetid = Convert.ToByte(jsonString[0]); // Получаем из всего пакета id
            jsonString = jsonString.Substring(1); // Удаляем id пакета из самого пакета
            ValidatePacket(lnr, packetid, jsonString);
        }

        public void ValidatePacket(Socket lnr, byte packetid, String jsonString) // Метод для определения что за пакет пришел от пользователя
        {
            User usertmp = new User();
            Subject subjecttmp = new Subject();
            switch (packetid)
            {
                case 0: // Пакет с незарегистрированным пользователем
                    usertmp = JsonSerializer.Deserialize<User>(jsonString); // Записываем присланного юзера во временный объект
                    PacketUserRegistration(lnr, usertmp); // Отправляем на регистрацию
                    break;
                case 1: // Пакет с незалогиненным пользователем
                    usertmp = JsonSerializer.Deserialize<User>(jsonString); // Записываем присланного юзера во временный объект
                    PacketUserLogin(lnr, usertmp); // Отправляем на вход
                    break;
                case 2: // Пакет с залогиненным пользователем, которому нужен список предметов
                    PacketSubjectsNames(lnr); // Отправляем список предметов
                    break;
                case 3: // Пакет с пользователем, который прошел тест
                    usertmp = JsonSerializer.Deserialize<User>(jsonString); // Записываем присланного юзера во временный объект
                    PacketUserPassedTest(usertmp); // Отправляем на обработчик пройденного тестов
                    break;
                case 4: // Пакет с выбранным предметом пользователем
                    string selectedSubjectName = JsonSerializer.Deserialize<string>(jsonString); // Создаем поле типа стринг и записываем в нее выбранный пользователем предмет
                    PacketSelectedSubject(lnr, selectedSubjectName); // Отправляем на обработчик выбранного предметов
                    break;
                case 5: // Пакет с запросом администратора на составление топа по выбранному предмету
                    string selectedAdminSubjectName = JsonSerializer.Deserialize<string>(jsonString); // Создаем поле типа стринг и записываем в нее выбранный пользователем предмет
                    PacketAdminUsersTop(lnr, selectedAdminSubjectName); // Отправляем на обработчик всех предметов
                    break;
                case 6: // Пакет с названием нового предмета
                    string newSubjectName = JsonSerializer.Deserialize<string>(jsonString); // Создаем поле типа стринг и записываем в нее название нового предмета
                    PacketAdminAddANewSubject(lnr, newSubjectName); // Отправляем на обработчик добавления нового предмета
                    break;
                case 7:
                    subjecttmp = JsonSerializer.Deserialize<Subject>(jsonString);// Записываем присланный предмет во временный объект
                    PacketAdminUpdateSubject(subjecttmp); // Отправляем на обработчик обновления предмета
                    break;
            }
        }

        public void PacketUserRegistration(Socket lnr, User usertmp) // Метод для обработки регистрации пользователя
        {
            List<User> userList = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(usersDatabasePath)); // Переводим файл БД json в лист типа User
            foreach (User user in userList) // Проходим по всему списку пока не найдем одинаковые логины
            {
                if (user.login == usertmp.login || (user.firstname == usertmp.firstname && user.lastname == usertmp.lastname)) // Если такой логин уже есть в БД то выходим из метода регистрации
                {
                    SendPacketRecieve(lnr, usertmp); // Отправляем пакет с пустым юзером
                    return;
                }
            }
            usertmp.userid = userList.Count + 1; // Присваиваем пользователю значение нового ID
            SendPacketRecieve(lnr, usertmp); // Отправляем пакет с новым юзером
            userList.Add(usertmp); // Добавляем в список нового пользователя
            File.WriteAllText(usersDatabasePath, JsonSerializer.Serialize(userList, new JsonSerializerOptions()
            { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All) })); // Записываем в файл новый список пользователей
        }

        public void PacketUserLogin(Socket lnr, User usertmp) // Метод для обработки входа пользователя
        {
            List<User> userList = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(usersDatabasePath)); // Переводим файл БД json в лист типа User
            foreach (User user in userList) // Проходим по всему списку пока не найдем нужный логин
            {
                if ((user.login == usertmp.login) && (user.password == usertmp.password)) // если логин и пароль найден
                {
                    usertmp = user; // Во временный объект записываем всю информацию о пользователе чтобы отправить клиенту обратно
                    break;
                }
            }
            SendPacketRecieve(lnr, usertmp); // Отправляем пакет с юзером
        }

        public void PacketSubjectsNames(Socket lnr) // Метод для обрабоки передачи списка с названиями всех предметов
        {
            List<Subject> allSubjectsList = JsonSerializer.Deserialize<List<Subject>>(File.ReadAllText(subjectsDatabasePath)); // Создаем список всех предметов
            List<string> allSubjectsNamesList = new List<string>(); // Создаем список с названиями всех предметов
            foreach (Subject subject in allSubjectsList) // Проходим по всему списку с предметами 
            {
                allSubjectsNamesList.Add(subject.subjectName); // Записываем все названия предметов в список
            }
            SendPacketRecieve(lnr, allSubjectsNamesList); // Отправляем пакет со всеми предметами пользователю
        }

        public void PacketSelectedSubject(Socket lnr, string selectedSubjectName) // Метод для обработки и отправления нужного предмета пользователю
        {
            List<Subject> allSubjectsList = JsonSerializer.Deserialize<List<Subject>>(File.ReadAllText(subjectsDatabasePath)); // Создаем список всех предметов
            Subject selectedSubject = new Subject(); // Создаем объект Subject для выбранного предмета который мы отошлем пользователю
            foreach (Subject subject in allSubjectsList) // Проходим по всему списку предметов
            {
                if (subject.subjectName == selectedSubjectName) // когда находим нужный предмет
                {
                    selectedSubject = subject; // В один объект записываем другой
                }
            }
            SendPacketRecieve(lnr, selectedSubject); // Отправляем пакет с выбранным предметом пользователю
        }

        public void PacketAdminUsersTop(Socket lnr, string selectedAdminSubjectName) // Метод для обработки и составления топа по выбранному предмету администратору
        {
            Dictionary<string, int> unSortedSubjectUsersTop = new Dictionary<string, int>(); // Создаем пустой словарь для составления топа
            List<User> userList = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(usersDatabasePath)); // Переводим файл БД json в лист типа User
            foreach (User user in userList) // Проходим по всему списку с пользователями
            {
                if (user.subjectScores.ContainsKey(selectedAdminSubjectName)) // Если пользователь проходил тест по заданной теме то
                {
                    unSortedSubjectUsersTop.Add(user.lastname + " " + user.firstname, user.subjectScores[selectedAdminSubjectName]); // Добавляем его в общий топ
                }
            }
            var sortedSubjectUsersTop = from entry in unSortedSubjectUsersTop orderby entry.Value descending select entry; // Сортируем и записываем в новую переменную неотсортированный словарь
            SendPacketRecieve(lnr, sortedSubjectUsersTop.ToDictionary(pair => pair.Key, pair => pair.Value)); // Отправляем отсортированный словарь пользователю
        }

        public void PacketUserPassedTest(User usertmp) // Метод для обработки результатов теста
        {
            List<User> userList = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(usersDatabasePath)); // Переводим файл БД json в лист типа User
            foreach (User user in userList) // Проходим по всему массиву пока не найдем одинаковые userid
            {
                if (user.userid == usertmp.userid) // Ищем нужного пользователя по айди
                {
                    user.subjectScores = usertmp.subjectScores; // Обновляем данные о рейтинге пользователя
                    File.WriteAllText(usersDatabasePath, JsonSerializer.Serialize(userList, new JsonSerializerOptions()
                    { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All) })); // Записываем в файл новый список пользователей
                    return;
                }
            }
        }

        public void PacketAdminAddANewSubject(Socket lnr, string newSubjectName) // Метод для создания нового предмета
        {
            List<Subject> subjectsList = JsonSerializer.Deserialize<List<Subject>>(File.ReadAllText(subjectsDatabasePath)); // Создаем список всех предметов из БД
            Subject newSubject = new Subject(subjectsList.Count + 1, newSubjectName, new List<Question>()); // Создаем объект класса предмет и заполняем его айди, названием и пустым списком вопросов
            subjectsList.Add(newSubject); // В список всех предметов добавляем новый предмет
            File.WriteAllText(subjectsDatabasePath, JsonSerializer.Serialize(subjectsList, new JsonSerializerOptions()
            { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All) })); // Записываем в файл новый список предметов
            PacketSubjectsNames(lnr);
        }

        public void PacketAdminUpdateSubject(Subject updatedSubject) // Метод для обновления какого-либо предмета
        {
            List<Subject> subjectsList = JsonSerializer.Deserialize<List<Subject>>(File.ReadAllText(subjectsDatabasePath)); // Создаем список всех предметов из БД
            int counter = 0; // Создаем счетчик
            foreach(Subject subject in subjectsList) // Проходим по всему списку
            {
                counter++; // Инкрементируем счетчик
                if(subject.subjectName == updatedSubject.subjectName) // Если название предметов совпадает то выходим из цикла
                {
                    break;
                }
            }
            int idCounter = subjectsList[counter].questionsList.Count + 1; // Создаем поле для нумерования вопросов
            foreach (Question question in updatedSubject.questionsList) // Проходим по всему списку вопросов в предмете
            {
                question.questionid = idCounter; // Присваиваем каждому вопросу нужный id
                idCounter++;
            }
            subjectsList[counter].questionsList.AddRange(updatedSubject.questionsList); // добавляем к старому списку вопросов новый
            File.WriteAllText(subjectsDatabasePath, JsonSerializer.Serialize(subjectsList, new JsonSerializerOptions()
            { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All) })); // Записываем в файл новый список предметов
        }

        public void SendPacketRecieve(Socket lnr, User usertmp) // Метод для отправления пользователя пользователю
        {
            byte[] buffer = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(usertmp)); // в массив байт передаем JSON строку
            lnr.Send(PacketAddIdToAnswerArr(buffer, 0)); // отправляем массив байт на сервер
        }

        public void SendPacketRecieve(Socket lnr, List<string> subjectsNamesList) // Метод для отправления списка предметов пользователю
        {
            byte[] buffer = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(subjectsNamesList)); // в массив байт передаем JSON строку
            lnr.Send(PacketAddIdToAnswerArr(buffer, 1)); // отправляем массив байт на сервер
        }

        public void SendPacketRecieve(Socket lnr, Subject selectedSubject) // Метод для отправления теста с нужным предметом пользователю
        {
            byte[] buffer = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(selectedSubject)); // в массив байт передаем JSON строку
            lnr.Send(PacketAddIdToAnswerArr(buffer, 2)); // отправляем массив байт с айди пакета на сервер 
        }

        public void SendPacketRecieve(Socket lnr, Dictionary<string, int> subjectUsersTop)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(subjectUsersTop)); // в массив байт передаем JSON строку
            lnr.Send(PacketAddIdToAnswerArr(buffer, 3)); // отправляем массив байт с айди пакета на сервер 
        }

        public byte[] PacketAddIdToAnswerArr(byte[] buffertmp, byte packetid) // Метод для добавления id в пакет отправляемый пользователю
        {
            byte[] answer = new byte[buffertmp.Length + 1]; // Создаем массив размером конечный пакет + id
            answer[0] = packetid; // Добавляем в первый элемент массива id пакета
            for (int i = 1; i < answer.Length; i++) // добавляем в массив с id пакета сам пакет
            {
                answer[i] = buffertmp[i - 1];
            }
            return answer; // Возвращаем конечный готовый пакет
        }
    }
}
