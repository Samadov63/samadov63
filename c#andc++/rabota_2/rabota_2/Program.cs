using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{

    class Program
    {
        abstract class Person
        {
            protected string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public abstract void input();
            public abstract bool Equals(object obj);
        }
        class Student : Person
        {
            protected string login;
            protected string parol;

            public string Place
            {
                get { return login; }
                set { login = value; }
            }

            public override void input()
            {
            Err:
                try
                {
                    Console.WriteLine("Введите имя: ");
                    Name = Console.ReadLine();

                    if (Name == "")
                        throw new Exception("Пустая строка");

                    foreach (var item in name.ToLower())
                    {
                        if ((item < 'а' || item > 'я') && item != ' ')
                            throw new Exception("Не верно задано имя (имеются не только буквы)");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Err;
                }

            Err1:
                try
                {
                    Console.WriteLine("Введите логин: ");
                    login = Console.ReadLine();

                    if (login == "")
                        throw new Exception("Пустая строка");

                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Err1;
                }

            Err2:
                try
                {
                    Console.WriteLine("Введите пароль: ");
                    parol = Console.ReadLine();

                    if (parol == "")
                        throw new Exception("Пустая строка");

                   // foreach (var item in parol.ToLower())
                    //{
                      //  if ((item < 'а' || item > 'я') && item != ' ')
                        //    throw new Exception("Не верно зада профессия (имеются не только буквы)");
                    //}
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Err2;
                }
            }

            public override bool Equals(object obj)
            {
                return obj is Student student &&
                       name == student.name &&
                       login == student.login &&
                       parol == student.parol;
            }

            public override string ToString()
            {
                return "Имя: " + name + "\nМесто работы: " + login + "\nПрофессия: " + parol;
            }
        }

        class Prepod : Student
        {
            private string position;


            public string Position
            {
                get { return position; }
                set { position = value; }
            }

            public override void input()
            {
            Err:
                try
                {
                    Console.WriteLine("Введите имя: ");
                    Name = Console.ReadLine();

                    if (Name == "")
                        throw new Exception("Пустая строка");

                    foreach (var item in name.ToLower())
                    {
                        if ((item < 'а' || item > 'я') && item != ' ')
                            throw new Exception("Не верно задано имя (имеются не только буквы)");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Err;
                }

            Err1:
                try
                {
                    Console.WriteLine("Логин: ");
                    login = Console.ReadLine();

                    if (login == "")
                        throw new Exception("Пустая строка");


                    /*
                    foreach (var item in login.ToLower())
                    {
                        if ((item < 'а' || item > 'я') && item != ' ')
                            throw new Exception("Не верно задан логин (имеются не только буквы)");
                    }
                    */

                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Err1;
                }

            Err2:
                try
                {
                    Console.WriteLine("Пароль: ");
                    position = Console.ReadLine();

                    if (position == "")
                        throw new Exception("Пустая строка");

                    /*foreach (var item in position.ToLower())
                    {
                        if ((item < 'а' || item > 'я') && item != ' ')
                            throw new Exception("Не верно задан пароль (имеются не только буквы)");
                    }
                    */

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Err2;
                }
            }
            public override bool Equals(object obj)
            {
                return obj is Prepod prepod &&
                       base.Equals(obj) &&
                       position == prepod.position;
            }

            public override string ToString()
            {
                return "Имя: " + name + "\nМесто работы: " + login +
                     "\nДолжность: " + position;
            }
        }
        class ZavKaf : Prepod
        {
            private string spec;

            public string Spec
            {
                get { return spec; }
                set { spec = value; }
            }

            public override void input()
            {
            Err:
                try
                {
                    Console.WriteLine("Введите имя: ");
                    Name = Console.ReadLine();

                    if (Name == "")
                        throw new Exception("Пустая строка");

                    foreach (var item in name.ToLower())
                    {
                        if ((item < 'а' || item > 'я') && item != ' ')
                            throw new Exception("Не верно задано имя (имеются не только буквы)");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Err;
                }

            Err1:
                try
                {
                    Console.WriteLine("Логин: ");
                    login = Console.ReadLine();

                    if (login == "")
                        throw new Exception("Пустая строка");

                    /*foreach (var item in login.ToLower())
                    {
                        if ((item < 'а' || item > 'я') && item != ' ')
                            throw new Exception("Не верно задано место работы (имеются не только буквы)");
                    }
                    */
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Err1;
                }

            Err2:
                try
                {
                    Console.WriteLine("Специализация: ");
                    spec = Console.ReadLine();

                    if (spec == "")
                        throw new Exception("Пустая строка");

                    foreach (var item in spec.ToLower())
                    {
                        if ((item < 'а' || item > 'я') && item != ' ')
                            throw new Exception("Не верно задана спец. (имеются не только буквы)");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Err2;
                }
            }
            public override bool Equals(object obj)
            {
                return obj is ZavKaf zavkaf &&
                       base.Equals(obj) &&
                       spec == zavkaf.spec;
            }

            public override string ToString()
            {
                return "Имя: " + name + "\nЛогин: " + login 
                    + "\nСпециализация: " + spec;
            }

        }

        static void Main(string[] args)
        {
            Console.Write("Укажите из скольки людей будет состоять массив: ");
            int N = int.Parse(Console.ReadLine());
            Person[] people = new Person[N];


            int choice;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("1. Студент");
                Console.WriteLine("2. Преподаватель");
                Console.WriteLine("3. ЗавКафедры");
                Console.Write("Выберите: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        people[i] = new Student();
                        people[i].input();
                        break;

                    case 2:
                        people[i] = new Prepod();
                        people[i].input();
                        break;

                    case 3:
                        people[i] = new ZavKaf();
                        people[i].input();
                        break;

                    default:
                        break;
                }
            }

            do
            {

                Console.WriteLine("1. Вывод массива");
                Console.WriteLine("2. Сравнить два элемента");
                Console.WriteLine("3. Сравнить");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите: ");
                choice = int.Parse(Console.ReadLine());


                int first, second;
                switch (choice)
                {
                    case 1:
                        foreach (var item in people)
                        {
                            Console.WriteLine(item + "\n\n");
                        }
                        break;

                    case 2:
                    ErrF:
                        try
                        {
                            Console.WriteLine("Введите индекс первого элемента");
                            first = int.Parse(Console.ReadLine());
                            if (first < 0 || first > N)
                                throw new Exception("Выход за диапозон возможных индексов");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto ErrF;
                        }

                    ErrS:
                        try
                        {
                            Console.WriteLine("Введите индекс второго элемента");
                            second = int.Parse(Console.ReadLine());
                            if (second < 0 || second > N)
                                throw new Exception("Выход за диапозон возможных индексов");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto ErrS;
                        }


                        Console.WriteLine(people[first] + "\n\n" + people[second] + "\n" + people[first].Equals(people[second]));
                        break;

                    case 3:
                        Console.WriteLine("\nКого хотите сравнить");
                        Console.WriteLine("1. Всех");
                        Console.WriteLine("2. Только препода");
                        Console.WriteLine("3. Только завкафедры");
                        Console.Write("Выберите: ");
                        choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                foreach (Person pers1 in people)
                                {
                                    foreach (Person pers2 in people)
                                    {
                                        Console.WriteLine(pers1 + "\n\n" + pers2 + "\n\n" + pers1.Equals(pers2));
                                        Console.WriteLine("---------------------------------------------------------------\n");
                                    }
                                }
                                break;

                            case 2:
                                foreach (Person pers1 in people)
                                {
                                    if (pers1 is ZavKaf)
                                        foreach (Person pers2 in people)
                                        {
                                            if (pers2 is ZavKaf)
                                            {
                                                Console.WriteLine(pers1 + "\n\n" + pers2 + "\n\n" + pers1.Equals(pers2));
                                                Console.WriteLine("---------------------------------------------------------------\n");
                                            }
                                        }
                                }
                                break;

                            case 3:
                                foreach (Person pers1 in people)
                                {
                                    if (pers1 is Prepod)
                                        foreach (Person pers2 in people)
                                        {
                                            if (pers2 is Prepod)
                                            {
                                                Console.WriteLine(pers1 + "\n\n" + pers2 + "\n\n" + pers1.Equals(pers2));
                                                Console.WriteLine("---------------------------------------------------------------\n");
                                            }
                                        }
                                }
                                break;

                            default:
                                break;
                        }

                        choice = 3;
                        break;


                    default:
                        break;
                }

                Console.WriteLine("\n\n");

            } while (choice != 0);



            Console.Read();
        }
    }
}


/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{

    class Program
    {
        abstract class Person
        {
            protected string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public abstract void input();
            public abstract bool Equals(object obj);
        }
        class Worker : Person
        {
            protected string place;
            protected string profession;

            public string Place
            {
                get { return place; }
                set { place = value; }
            }

            public override void input()
            {
            Err:
                try
                {
                    Console.WriteLine("Введите имя: ");
                    Name = Console.ReadLine();

                    if (Name == "")
                        throw new Exception("Пустая строка");

                    foreach (var item in name.ToLower())
                    {
                        if ((item < 'а' || item > 'я') && item != ' ')
                            throw new Exception("Не верно задано имя (имеются не только буквы)");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Err;
                }

            Err1:
                try
                {
                    Console.WriteLine("Место работы: ");
                    place = Console.ReadLine();

                    if (place == "")
                        throw new Exception("Пустая строка");

                    foreach (var item in place.ToLower())
                    {
                        if ((item < 'а' || item > 'я') && item != ' ')
                            throw new Exception("Не верно задано место работы (имеются не только буквы)");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Err1;
                }

            Err2:
                try
                {
                    Console.WriteLine("Введите профессию: ");
                    profession = Console.ReadLine();

                    if (profession == "")
                        throw new Exception("Пустая строка");

                    foreach (var item in profession.ToLower())
                    {
                        if ((item < 'а' || item > 'я') && item != ' ')
                            throw new Exception("Не верно задана профессия (имеются не только буквы)");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Err2;
                }
            }

            public override bool Equals(object obj)
            {
                return obj is Worker worker &&
                       name == worker.name &&
                       place == worker.place &&
                       profession == worker.profession;
            }

            public override string ToString()
            {
                return "Имя: " + name + "\nМесто работы: " + place + "\nПрофессия: " + profession;
            }
        }

        class OfficeWorker : Worker
        {
            private string position;


            public string Position
            {
                get { return position; }
                set { position = value; }
            }

            public override void input()
            {
            Err:
                try
                {
                    Console.WriteLine("Введите имя: ");
                    Name = Console.ReadLine();

                    if (Name == "")
                        throw new Exception("Пустая строка");

                    foreach (var item in name.ToLower())
                    {
                        if ((item < 'а' || item > 'я') && item != ' ')
                            throw new Exception("Не верно задано имя (имеются не только буквы)");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Err;
                }

            Err1:
                try
                {
                    Console.WriteLine("Место работы: ");
                    place = Console.ReadLine();

                    if (place == "")
                        throw new Exception("Пустая строка");

                    foreach (var item in place.ToLower())
                    {
                        if ((item < 'а' || item > 'я') && item != ' ')
                            throw new Exception("Не верно задано место работы (имеются не только буквы)");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Err1;
                }

            Err2:
                try
                {
                    Console.WriteLine("Должность: ");
                    position = Console.ReadLine();

                    if (position == "")
                        throw new Exception("Пустая строка");

                    foreach (var item in position.ToLower())
                    {
                        if ((item < 'а' || item > 'я') && item != ' ')
                            throw new Exception("Не верно задана должность (имеются не только буквы)");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Err2;
                }
            }
            public override bool Equals(object obj)
            {
                return obj is OfficeWorker officeWorker &&
                       base.Equals(obj) &&
                       position == officeWorker.position;
            }

            public override string ToString()
            {
                return "Имя: " + name + "\nМесто работы: " + place + "\nСлужащий"
                    + "\nДолжность: " + position;
            }
        }
        class Engieneer : Worker
        {
            private string specialization;

            public string Specialization
            {
                get { return specialization; }
                set { specialization = value; }
            }

            public override void input()
            {
            Err:
                try
                {
                    Console.WriteLine("Введите имя: ");
                    Name = Console.ReadLine();

                    if (Name == "")
                        throw new Exception("Пустая строка");

                    foreach (var item in name.ToLower())
                    {
                        if ((item < 'а' || item > 'я') && item != ' ')
                            throw new Exception("Не верно задано имя (имеются не только буквы)");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Err;
                }

            Err1:
                try
                {
                    Console.WriteLine("Место работы: ");
                    place = Console.ReadLine();

                    if (place == "")
                        throw new Exception("Пустая строка");

                    foreach (var item in place.ToLower())
                    {
                        if ((item < 'а' || item > 'я') && item != ' ')
                            throw new Exception("Не верно задано место работы (имеются не только буквы)");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Err1;
                }

            Err2:
                try
                {
                    Console.WriteLine("Специализация: ");
                    specialization = Console.ReadLine();

                    if (specialization == "")
                        throw new Exception("Пустая строка");

                    foreach (var item in specialization.ToLower())
                    {
                        if ((item < 'а' || item > 'я') && item != ' ')
                            throw new Exception("Не верно задана специализация (имеются не только буквы)");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Err2;
                }
            }
            public override bool Equals(object obj)
            {
                return obj is Engieneer engieneer &&
                       base.Equals(obj) &&
                       specialization == engieneer.specialization;
            }

            public override string ToString()
            {
                return "Имя: " + name + "\nМесто работы: " + place + "\nИнженер"
                    + "\nСпециализация: " + specialization;
            }

        }

        static void Main(string[] args)
        {
            Console.Write("Укажите из скольки людей будет состоять массив: ");
            int N = int.Parse(Console.ReadLine());
            Person[] people = new Person[N];


            int choice;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("1. Рабочий");
                Console.WriteLine("2. Служащий");
                Console.WriteLine("3. Инженер");
                Console.Write("Выберите: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        people[i] = new Worker();
                        people[i].input();
                        break;

                    case 2:
                        people[i] = new OfficeWorker();
                        people[i].input();
                        break;

                    case 3:
                        people[i] = new Engieneer();
                        people[i].input();
                        break;

                    default:
                        break;
                }
            }

            do
            {

                Console.WriteLine("1. Вывод массива");
                Console.WriteLine("2. Сравнить два элемента");
                Console.WriteLine("3. Сравнить");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите: ");
                choice = int.Parse(Console.ReadLine());


                int first, second;
                switch (choice)
                {
                    case 1:
                        foreach (var item in people)
                        {
                            Console.WriteLine(item + "\n\n");
                        }
                        break;

                    case 2:
                    ErrF:
                        try
                        {
                            Console.WriteLine("Введите индекс первого элемента");
                            first = int.Parse(Console.ReadLine());
                            if (first < 0 || first > N)
                                throw new Exception("Выход за диапозон возможных индексов");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto ErrF;
                        }

                    ErrS:
                        try
                        {
                            Console.WriteLine("Введите индекс второго элемента");
                            second = int.Parse(Console.ReadLine());
                            if (second < 0 || second > N)
                                throw new Exception("Выход за диапозон возможных индексов");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto ErrS;
                        }


                        Console.WriteLine(people[first] + "\n\n" + people[second] + "\n" + people[first].Equals(people[second]));
                        break;

                    case 3:
                        Console.WriteLine("\nКого хотите сравнить");
                        Console.WriteLine("1. Всех");
                        Console.WriteLine("2. Только инженеров");
                        Console.WriteLine("3. Только служащих");
                        Console.Write("Выберите: ");
                        choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                foreach (Person pers1 in people)
                                {
                                    foreach (Person pers2 in people)
                                    {
                                        Console.WriteLine(pers1 + "\n\n" + pers2 + "\n\n" + pers1.Equals(pers2));
                                        Console.WriteLine("---------------------------------------------------------------\n");
                                    }
                                }
                                break;

                            case 2:
                                foreach (Person pers1 in people)
                                {
                                    if (pers1 is Engieneer)
                                        foreach (Person pers2 in people)
                                        {
                                            if (pers2 is Engieneer)
                                            {
                                                Console.WriteLine(pers1 + "\n\n" + pers2 + "\n\n" + pers1.Equals(pers2));
                                                Console.WriteLine("---------------------------------------------------------------\n");
                                            }
                                        }
                                }
                                break;

                            case 3:
                                foreach (Person pers1 in people)
                                {
                                    if (pers1 is OfficeWorker)
                                        foreach (Person pers2 in people)
                                        {
                                            if (pers2 is OfficeWorker)
                                            {
                                                Console.WriteLine(pers1 + "\n\n" + pers2 + "\n\n" + pers1.Equals(pers2));
                                                Console.WriteLine("---------------------------------------------------------------\n");
                                            }
                                        }
                                }
                                break;

                            default:
                                break;
                        }

                        choice = 3;
                        break;


                    default:
                        break;
                }

                Console.WriteLine("\n\n");

            } while (choice != 0);



            Console.Read();
        }
    }
}
*/