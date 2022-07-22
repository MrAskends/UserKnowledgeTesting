using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Client
{
    class PacketTracer
    {

        public string ip { get; set; } // Поле для хранения IP
        public int port { get; set; } // Поле для хранения Порта

        Socket serverSocket; // Объект класса сокет

        public PacketTracer(string ip, int port) // Конструктор класса
        {
            this.ip = ip;
            this.port = port;
        }

        public void PacketConnectToServer() // Метод подключения к серверу
        {
            IPEndPoint tcpEndPoint = new IPEndPoint(IPAddress.Parse(this.ip), this.port); // Создание конечной точки подключения

            this.serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); // Создание сокета (версия IPV4/IPV6, Тип сокета, тип протокола подключения)

            serverSocket.Connect(tcpEndPoint);
        }

        public void GetPacketRecieve() // Метод получения любого пакета от сервера
        {
            byte packetid; // поле для уникального id пакета
            byte[] buffer = new byte[32768]; // Создаем буффер для данных
            int size = 0; // Переменная для хранения реально полученных байт
            String jsonString = ""; // Создаем пустую строку
            do
            {
                size = this.serverSocket.Receive(buffer); // Получаем количество реально полученных байт
                jsonString += Encoding.UTF8.GetString(buffer, 0, size); // В строку записываем из (буфера, с 1 ячейки, количество)
            }
            while (this.serverSocket.Available > 0); //Пока есть данные считываем
            packetid = Convert.ToByte(jsonString[0]); // Получаем из всего пакета id
            jsonString = jsonString.Substring(1); // Удаляем id пакета из самого пакета
            ValidatePacket(packetid, jsonString); // Отправляем пакет на валидацию
        }

        public void ValidatePacket(byte packetid, string jsonString) // Метод проверки пакета на содержимое
        {
            switch(packetid)
            {
                case 0:
                    Main.user = JsonSerializer.Deserialize<User>(jsonString); // Если первый тип пакета, то записываем все в юзера
                    break;
                case 1:
                    Main.allSubjectsNames = JsonSerializer.Deserialize<List<string>>(jsonString); // Если второй тип пакета, то записываем все в названия предметов
                    break;
                case 2:
                    Main.subject = JsonSerializer.Deserialize<Subject>(jsonString); // Если третий тип пакета, то записываем все в предмет
                    break;
                case 3:
                    Main.usersTop = JsonSerializer.Deserialize<Dictionary<string, int>>(jsonString); // Если четвертый тип пакета, то записываем все в топ пользователей
                    break;
            }
        }

        public void SendPacketRequest() // Метод для отправления пользователя на сервер
        {
            byte[] buffer = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(Main.user)); // Переводим строку в массив байт
            switch (Main.user.userid) // Проверяем какого пользователя мы отправляем, залогиненного, зарегистрированного или нет
            {
                case -1: // Не зарегистрирован
                    this.serverSocket.Send(PacketAddIdToAnswerArr(buffer, 0)); // Отправляем массив на сервер
                    GetPacketRecieve(); // Получаем ответ от сервера
                    break;
                case 0: // Не вошел
                    this.serverSocket.Send(PacketAddIdToAnswerArr(buffer, 1)); // Отправляем массив на сервер
                    GetPacketRecieve(); // Получаем ответ от сервера
                    break;
                default: // Идентифицированный
                    if (Main.allSubjectsNames.Count == 0) // Если у пользователя нет списка предметов
                    {
                        this.serverSocket.Send(PacketAddIdToAnswerArr(buffer, 2)); // Отправляем массив на сервер
                        GetPacketRecieve(); // Получаем ответ от сервера
                    }
                    else
                    {
                        this.serverSocket.Send(PacketAddIdToAnswerArr(buffer, 3)); // Отправляем массив на сервер
                    }
                    break;
            }
        }

        public void SendPacketRequest(string selectedSubject, bool adminTop) // Метод для отправления выбранного предмета на сервер
        {
            if (!adminTop) // Если это админский запрос то
            {
                byte[] buffer = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(selectedSubject)); // Переводим строку в массив байт
                this.serverSocket.Send(PacketAddIdToAnswerArr(buffer, 4)); // Отправляем массив на сервер
                GetPacketRecieve(); // Получаем ответ от сервера
            }
            else
            {
                byte[] buffer = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(selectedSubject)); // Переводим строку в массив байт
                this.serverSocket.Send(PacketAddIdToAnswerArr(buffer, 5)); // Отправляем массив на сервер
                GetPacketRecieve(); // Получаем ответ от сервера
            }
        }

        public void SendPacketRequest(string newSubjectName) // Метод для отправления названия нового предмета на сервер
        {
            byte[] buffer = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(newSubjectName)); // Переводим строку в массив байт
            this.serverSocket.Send(PacketAddIdToAnswerArr(buffer, 6)); // Отправляем массив на сервер
            GetPacketRecieve(); // Получаем ответ от сервера
        }

        public void SendPacketRequest(Subject updatedSubject) // Метод для отправления предмета с новыми вопросами на сервер
        {
            byte[] buffer = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(updatedSubject)); // Переводим строку в массив байт
            this.serverSocket.Send(PacketAddIdToAnswerArr(buffer, 7)); // Отправляем массив на сервер
        }

        public byte[] PacketAddIdToAnswerArr(byte[] buffertmp, byte packetid) // Метод для добавления id в пакет отправляемый серверу
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
