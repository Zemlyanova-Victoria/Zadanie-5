using System;
using static System.Console;
using System.Collections.Generic;
using static System.Convert;


namespace ConsoleApp9
{

    class lib

    {
        public class Student

        {
            public string Id;

            public string FIO;

            public string Group;

            public string Data;

        }

        public List<Student> list = new List<Student>();

        public void add(string Id, string FIO, string Group, string Data)

        {
            list.Add(new Student() { Id = Id, FIO = FIO, Group = Group, Data = Data });
        }

        public void remov(string Id)

        {
            for (int i = 0; i < list.Count; i++)

            {
                if (list[i].Id == Id) list.RemoveAt(i);
            }
        }

        public void change(string Id, string FIO, string Group, string Data)

        {
            for (int i = 0; i < list.Count; i++)

            {
                if (list[i].Id == Id)

                {
                    list[i].FIO = FIO;

                    list[i].Group = Group;

                    list[i].Data = Data;

                }

            }

        }

        public void show()

        {
            foreach (var i in list)

            {
                Console.WriteLine(i.Id + " " + i.FIO + " " + i.Group + " " + i.Data);
            }


        }

    }
    class Program
    {
        static void Main(string[] args)
        {
             lib a = new lib();

            WriteLine("1 - Добавить студента.\n2 - Изменить данные о студенте.\n3 - Удалить студента.\n4 - Вывод всех студентов.");

            int n = ToInt32(ReadLine());

            while (n > 0)

            {

                if (n == 1)

                {
                    WriteLine("ID: "); string Id = ReadLine();

                    WriteLine("ФИО: "); string FIO = ReadLine();

                    WriteLine("Группа: "); string Group = ReadLine();

                    WriteLine("Дата: "); string Data = ReadLine();

                    a.add(Id, FIO, Group, Data);

                    WriteLine("Введи действие: ");

                    n = ToInt32(ReadLine());

                }

                else if (n == 2)

                {
                    WriteLine("Введи ID и измененные данные: ");

                    WriteLine("ID: "); string Id = ReadLine();

                    WriteLine("ФИО: "); string FIO = ReadLine();

                    WriteLine("Группа: "); string Group = ReadLine();

                    WriteLine("Дата: "); string Data = ReadLine();

                    a.change(Id, FIO, Group, Data);

                    WriteLine("Введи действие: ");

                    n = ToInt32(ReadLine());

                }

                else if (n == 3)

                {
                    WriteLine("Введи ID: ");

                    string Id = ReadLine();

                    a.remov(Id);

                    WriteLine("Введи действие: ");

                    n = ToInt32(ReadLine());

                }

                else if (n == 4)

                {
                    a.show();

                    WriteLine("Введи действие: ");

                    n = ToInt32(ReadLine());

                }

            }

        }

    }

}
        
    




