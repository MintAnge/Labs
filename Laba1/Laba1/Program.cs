using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, это ваш личная записная книжка!");
            NoteBook.command();
        }
        public class NoteBook
        {
            public string surname; //фамилия
            public string name; //имя
            public string patronymic; //отчество
            public string phone; // номер телефона
            public string country; // страна
            public string organization; //организация
            public string position; // позиция 
            public string other; // доп. информация
            public string birthDate; // дата рождения
            public static List <NoteBook> Person = new List <NoteBook>(); // массив хранит все ссылки на контакты

            public static void addNewPerson() // Создание нового контакта
            {
                Person.Add(new NoteBook());
                Console.WriteLine("Укажите фамилию: ");
                string sName = Console.ReadLine();
                while (String.IsNullOrEmpty(sName)) // проверка наличия
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Пожалуйста, укажите фамилию: ");
                    Console.ResetColor();
                    sName = Console.ReadLine();

                }
                NoteBook.Person[Person.Count-1].surname = sName;
                Console.WriteLine("Укажите имя: ");
                string name1 = Console.ReadLine();
                while (String.IsNullOrEmpty(name1)) // проверка наличия
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Пожалуйста, укажите имя: ");
                    Console.ResetColor();
                    name1 = Console.ReadLine();

                }
                NoteBook.Person[Person.Count - 1].name = name1;
                Console.WriteLine("Укажите, если оно есть, отчество. Если информации нет, нажмите кнопку Enter.");
                string patronymic1 = Console.ReadLine();
                NoteBook.Person[Person.Count - 1].patronymic = patronymic1;
                Console.WriteLine("Укажите номер телефона (Он может состоять только из цифр): ");
                string phone1 = Console.ReadLine();
                var t = phone1.ToCharArray().All(char.IsDigit);
                while (String.IsNullOrEmpty(phone1) || t == false) // проверка наличия
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Пожалуйста, укажите номер телефона: ");
                    Console.ResetColor();
                    phone1 = Console.ReadLine();
                    t = phone1.ToCharArray().All(char.IsDigit);

                }
                NoteBook.Person[Person.Count - 1].phone = phone1;
                Console.WriteLine("Укажите страну: ");
                string country1 = Console.ReadLine();
                while (String.IsNullOrEmpty(country1))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Пожалуйста, укажите страну: ");
                    Console.ResetColor();
                    country1 = Console.ReadLine();

                }
                NoteBook.Person[Person.Count - 1].country = country1;
                Console.WriteLine("Укажите, если она известна, дату рождения. Если информации нет, нажмите кнопку Enter.");
                string birthDate1 = Console.ReadLine();
                NoteBook.Person[Person.Count - 1].birthDate = birthDate1;
                Console.WriteLine("Укажите, если она известна, организацию. Если информации нет, нажмите кнопку Enter.");
                string organization1 = Console.ReadLine();
                NoteBook.Person[Person.Count - 1].organization = organization1;
                Console.WriteLine("Укажите, если она известна, позицию. Если информации нет, нажмите кнопку Enter.");
                string position1 = Console.ReadLine();
                NoteBook.Person[Person.Count - 1].position = position1;
                Console.WriteLine("Укажите, если она есть, дополнительную информацию. Если её нет, нажмите кнопку Enter.");
                string other1 = Console.ReadLine();
                NoteBook.Person[Person.Count - 1].other = other1;
            }
            public static string showPersonInfo(int t)
            {
                string s = "";
                if (Person.Count == 0 || t>Person.Count)
                {
                    return "Такого контакта не существует";
                }
                else
                {
                    if (String.IsNullOrEmpty(NoteBook.Person[t].surname))
                    {

                    }
                    else s += "Фамилия: " + NoteBook.Person[t].surname;
                    if (String.IsNullOrEmpty(NoteBook.Person[t].name))
                    {

                    }
                    else s += "\nИмя: " + NoteBook.Person[t].name;
                    if (String.IsNullOrEmpty(NoteBook.Person[t].patronymic))
                    {

                    }
                    else s += "\nОтчество: " + NoteBook.Person[t].patronymic;
                    if (String.IsNullOrEmpty(NoteBook.Person[t].phone))
                    {

                    }
                    else s += "\nНомер телефона: " + NoteBook.Person[t].phone;
                    if (String.IsNullOrEmpty(NoteBook.Person[t].organization))
                    {

                    }
                    else s += "\nОрганизация: " + NoteBook.Person[t].organization;
                    if (String.IsNullOrEmpty(NoteBook.Person[t].position))
                    {

                    }
                    else s += "\nДолжность: " + NoteBook.Person[t].position;
                    if (String.IsNullOrEmpty(NoteBook.Person[t].country))
                    {

                    }
                    else s += "\nСтрана: " + NoteBook.Person[t].country;
                    if (String.IsNullOrEmpty(NoteBook.Person[t].other))
                    {

                    }
                    else s += "\nЗаметки: " + NoteBook.Person[t].other;
                    return s;
                }
            } // показ информации об контакте
            public static void deletePerson(List<NoteBook> Person )
            {
                string i = Console.ReadLine();
                int j = Convert.ToInt32(i);
                Person[j] = null;
                NoteBook.Person.RemoveAt(j);
                Console.WriteLine("Удаление успешно завершено.");
            } // удаление контакта
            static public void command()
            {
                Console.WriteLine("Для начала работы нажмите клавишу: Enter");
                Console.WriteLine("Для конца работы напишите: Stop");
                string a = Console.ReadLine();
                while (String.Equals(a, "Stop") == false) 
                { 
                    Console.WriteLine("Что бы добавить новый контакт напишите: Добавить");
                    Console.WriteLine("Что бы удалить контакт напишите: Удалить");
                    Console.WriteLine("Что бы увидеть контакт напишите: Показать");
                    Console.WriteLine("Что бы увидеть все контакты напишите: Показать всех");
                    Console.WriteLine("Что бы отредактировать контакт напише: Редактировать");
                    Console.WriteLine("Что бы показать список всех команд напишите: Команды");
                    a = Console.ReadLine();
                    if (string.Equals(a, "Добавить"))
                    {
                        NoteBook.addNewPerson();
                    }
                    if (string.Equals(a, "Удалить"))
                    {
                        Console.Write("Укажите индекс контакта, который вы хотите удалить: ");
                        NoteBook.deletePerson(Person);
                    }
                    if (string.Equals(a, "Показать"))
                    {
                        Console.Write("Укажите индекс контакта, который вы хотите увидеть: ");
                        string n = Console.ReadLine();
                        int t = Convert.ToInt32(n);
                        Console.WriteLine(NoteBook.showPersonInfo(t));
                    }
                    if (string.Equals(a, "Показать всех"))
                    {
                        NoteBook.showAll();
                    }
                    if (string.Equals(a, "Редактировать"))
                    {
                        Console.Write("Укажить индекс контакта, который вы хотите редактировать: ");
                        string n = Console.ReadLine();
                        int i = Convert.ToInt32(n);
                        NoteBook.redact(i);
                    }
                    if (string.Equals(a, "Команды"))
                    {
                        Console.WriteLine("Что бы добавить новый контакт напишите: Добавить");
                        Console.WriteLine("Что бы удалить контакт напишите: Удалить");
                        Console.WriteLine("Что бы увидеть контакт напишите: Показать");
                        Console.WriteLine("Что бы увидеть все контакты напишите: Показать всех");
                        Console.WriteLine("Что бы отредоктировать контакт напише: Редактировать");
                    }
                    a = Console.ReadLine();
                }
            } // команды для консоли
            public static void redact(int i)
            {
                if (Person.Count == 0 || i > Person.Count)
                {
                    Console.WriteLine("Такого контакта не существует"); 
                }
                else
                {
                    Console.WriteLine("Если вы хотите изменить фамилию - напишите новую фамилию контакта. Если нет - нажмите Enter");
                    string sName = Console.ReadLine();
                    if (String.IsNullOrEmpty(sName) != true)
                    {
                       NoteBook.Person[i].surname = sName;
                    }
                    Console.WriteLine("Если вы хотите изменить имя - напишите новое имя контакта. Если нет - нажмите Enter");
                    string name = Console.ReadLine();
                    if (String.IsNullOrEmpty(name) != true)
                    {
                        NoteBook.Person[i].name = name;
                    }
                    Console.WriteLine("Если вы хотите изменить отчество - напишите новое отчество контакта. Если нет - нажмите Enter");
                    string patr = Console.ReadLine();
                    if (String.IsNullOrEmpty(patr) != true)
                    {
                        NoteBook.Person[i].patronymic = patr;
                    }
                    Console.WriteLine("Если вы хотите изменить номер - напишите новый номер контакта. Если нет - нажмите Enter");
                    string phone = Console.ReadLine();
                    var t = phone.ToCharArray().All(char.IsDigit);
                    while (String.IsNullOrEmpty(phone) != true || t ==false)
                    {
                        Console.WriteLine("Введеный вами номер должен состоять из цифр. Попробуйте ввести снова: ");
                         phone = Console.ReadLine();
                         t = phone.ToCharArray().All(char.IsDigit);
                    } 
                    if (String.IsNullOrEmpty(phone) != true)  NoteBook.Person[i].phone = phone;
                    Console.WriteLine("Если вы хотите изменить страну - напишите новую страну контакта. Если нет - нажмите Enter");
                    string coun = Console.ReadLine();
                    if (String.IsNullOrEmpty(coun) != true)
                    {
                        NoteBook.Person[i].country = coun;
                    }
                    Console.WriteLine("Если вы хотите изменить организацию - напишите новую организацию контакта. Если нет - нажмите Enter");
                    string org = Console.ReadLine();
                    if (String.IsNullOrEmpty(org) != true)
                    {
                        NoteBook.Person[i].organization = org;
                    }
                    Console.WriteLine("Если вы хотите изменить позицию - напишите новую позицию контакта. Если нет - нажмите Enter");
                    string pos = Console.ReadLine();
                    if (String.IsNullOrEmpty(pos) != true)
                    {
                        NoteBook.Person[i].position = pos;
                    }
                    Console.WriteLine("Если вы хотите изменить доп. Информацию - напишите новую доп. информацию контакта. Если нет - нажмите Enter");
                    string oth = Console.ReadLine();
                    if (String.IsNullOrEmpty(oth) != true)
                    {
                        NoteBook.Person[i].other = oth;
                    }
                }
            } // редактирование контакта
            public static void showAll()
            {
                for (int i = 0; i<Person.Count; i++)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("Фамилия: " + NoteBook.Person[i].surname);
                    Console.WriteLine("Имя: " + NoteBook.Person[i].name);
                    Console.WriteLine("Номер телефона: " + NoteBook.Person[i].phone);
                    Console.WriteLine();
                }
            } // показывает все контакты
        }
    }
}
