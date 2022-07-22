using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    static class Main
    {

        public static PacketTracer server; // Создаем объект класса ServerPacketTracer

        public static User user; // Создаем объект класса User

        public static Subject subject; // Создаем объект класса Subject для выбранного предмета

        public static List<string> allSubjectsNames; // Создаем список предметов которые есть

        public static Dictionary<string, int> usersTop; // Создаем словарь для хранения топов пользователей

        public static bool registrationFormClosing; // Флаг для отлавливания закрытия окна регистрации

        public static bool loginFormClosing; // Флаг для отлавливания закрытия окна логина

        public static bool testFormClosing; // Флаг для отлавливания закрытия окна тестирования

        public static bool mainFormShowing; // Флаг для отлавливания открытия главного окна

        public static bool mainFormFirstShowing; // Флаг для отлавливания первого открытия главного окна

        public static bool SettingsFormClosing; // Флаг для отлавливания закрытия окна настроек

        public static bool ShowUsersTopsFormClosing; // Флаг для отлавливания закрытия окна показания рейтинга всех пользователей

        public static bool AddSubjectsFormClosing; // Флаг для отлавливания закрытия окна добавления предметов

        public static bool AddQuestionsFormClosing; // Флаг для отлавливания закрытия окна добавления вопросов

        static Main() // Singleton класса
        {
            server = new PacketTracer("127.0.0.1", 7000);
            user = new User();
            subject = new Subject();
            allSubjectsNames = new List<string>();
            usersTop = new Dictionary<string, int>();
            registrationFormClosing = false;
            loginFormClosing = false;
            testFormClosing = false;
            mainFormShowing = false;
            mainFormFirstShowing = true;
            SettingsFormClosing = false;
            ShowUsersTopsFormClosing = false;
            AddSubjectsFormClosing = false;
            AddQuestionsFormClosing = false;
        }

    }
}
