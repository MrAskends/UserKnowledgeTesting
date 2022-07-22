using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace Server
{
    class Program
    {

        static void Main(string[] args)
        {

            const string usersDatabasePath = "usersdatabase.json"; // Путь к БД с юзерами

            const string subjectsDatabasePath = "subjectsdatabase.json"; // Путь к БД с предметами и вопросами

            PacketTracer packetTracer = new PacketTracer(usersDatabasePath, subjectsDatabasePath); // Создаем объект класса PacketTracer

            if (!File.Exists(usersDatabasePath)) // Проверка существует ли файл
            {
                Dictionary<string, int> emptyDict = new Dictionary<string, int>(); // Создаем пустой словарь
                User defaultUser = new User(1, "MrAskends", "33713", "Дмитрий", "Гиршович", 20, emptyDict, true); // Дефолтный юзер
                List<User> defaultUserList = new List<User>() { defaultUser }; // Создаем список с дефолтными юзерами
                FileStream fileStream = File.Create(usersDatabasePath); // Открываем поток FileStream
                fileStream.Close(); // Закрываем поток FileStream
                File.WriteAllText(usersDatabasePath, JsonSerializer.Serialize(defaultUserList, new JsonSerializerOptions() 
                { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All) })); // Записываем в него дефолтного юзера
            }
            if (!File.Exists(subjectsDatabasePath)) // Проверка существует ли файл
            {
                Question defaultQuestion = new Question(1, "Сколько лап у паука?", "2", "4", "6", "8", "d"); // Создаем дефолтный вопрос
                List <Question> defaultQuestionList = new List<Question>() { defaultQuestion }; // Создаем список дефолтных вопросов
                Subject defaultSubject = new Subject(1, "Biology", defaultQuestionList); // Создаем дефолтный предмет
                List<Subject> defaultSubjectList = new List<Subject>() { defaultSubject }; // Создаем список дефолтных предметов
                FileStream fileStream = File.Create(subjectsDatabasePath); // Открываем поток FileStream
                fileStream.Close(); // Закрываем поток FileStream
                File.WriteAllText(subjectsDatabasePath, JsonSerializer.Serialize(defaultSubjectList, new JsonSerializerOptions()
                { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All) })); // Записываем в него дефолтного юзера
            }

            packetTracer.PacketListenClients(); // Включаем обработчик пакетов

        }

    }
}