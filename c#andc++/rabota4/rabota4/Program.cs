using System;
class Program
{
    abstract class Person
    {
        public int Experience;
        public int Salary;
        public abstract void vvod();
        public abstract void vivod();
        public abstract bool Equals(object obj);
    }

    class Worker : Person
    {
        public
        string Workzone;
        public override bool Equals(object obj)
        {
            Worker other = obj as Worker;
            return (other.Experience == this.Experience && other.Salary == this.Salary && other.Workzone == this.Workzone);
        }
        public override void vvod()
        {
        link:
            Console.WriteLine("Введите стаж: ");
            try
            {
                Experience = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("неправильный ввод, введите другой стаж: ");
                goto link;
            }
            if (Experience < 0)
            {
                Console.WriteLine("Значение не может быть отрицательным");
                goto link;

            }
            if (Experience > 65)
            {
                Console.WriteLine("Слишком большое значение, введите другое значение");
                goto link;
            }

        link2:
            Console.WriteLine("Введите зарплату");
            try
            {
                Salary = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("неправильный ввод, введите другую з/п: ");
                goto link2;
            }
            if (Salary <= 0)
            {
                Console.WriteLine("Значение не может быть отрицательным");
                goto link2;
            }

            Console.WriteLine("Введите рабочую зону: ");
            Workzone = Console.ReadLine();
        }
        public override void vivod()
        {
            Console.WriteLine("\nСтаж: " + Experience);
            Console.WriteLine("Запрплата: " + Salary + " рублей");
            Console.WriteLine("Рабочая зона: " + Workzone);
        }

    }
    class Engineer : Person
    {
        public string Rank;
        public override bool Equals(object obj)
        {
            Engineer other = obj as Engineer;
            return (other.Experience == this.Experience && other.Salary == this.Salary && other.Rank == this.Rank);
        }
        public override void vvod()
        {
        link3:
            Console.WriteLine("Введите стаж: ");
            try
            {
                Experience = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("неправильный ввод, введите другой стаж: ");
                goto link3;
            }
            if (Experience < 0)
            {
                Console.WriteLine("Значение не может быть отрицательным");
                goto link3;
            }
            if (Experience > 65)
            {
                Console.WriteLine("Слишком большое значение, введите другое значение");
                goto link3;

            }


        link4:
            Console.WriteLine("Введите зарплату");
            try
            {
                Salary = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("неправильный ввод, введите другую з/п: ");
                goto link4;
            }
            if (Salary <= 0)
            {
                Console.WriteLine("Значение не может быть отрицательным");
                goto link4;
            }
            Console.WriteLine("Введите разряд: ");
            Rank = Console.ReadLine();
        }
        public override void vivod()
        {
            Console.WriteLine("\nСтаж: " + Experience);
            Console.WriteLine("Запрплата: " + Salary + " рублей");
            Console.WriteLine("Разряд: " + Rank);
        }

    }
    class Employee : Person
    {
        public string Education;
        public override bool Equals(object obj)
        {
            Employee other = obj as Employee;
            return (other.Experience == this.Experience && other.Salary == this.Salary && other.Education == this.Education);
        }
        public override void vvod()
        {
        link5:
            Console.WriteLine("Введите стаж: ");
            try
            {
                Experience = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("неправильный ввод, введите другой стаж: ");
                goto link5;
            }
            if (Experience < 0)
            {
                Console.WriteLine("Значение не может быть отрицательным");
                goto link5;

            }
            if (Experience > 65)
            {
                Console.WriteLine("Слишком большое значение, введите другое значение");
                goto link5;

            }

        link6:
            Console.WriteLine("Введите зарплату");
            try
            {
                Salary = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("неправильный ввод, введите другую з/п: ");
                goto link6;
            }
            if (Salary <= 0)
            {
                Console.WriteLine("Значение не может быть отрицательным");
                goto link6;
            }
            Console.WriteLine("Введите образование: ");
            Education = Console.ReadLine();
        }
        public override void vivod()
        {
            Console.WriteLine("\nСтаж: " + Experience);
            Console.WriteLine("Запрплата: " + Salary + " рублей");
            Console.WriteLine("Образование: " + Education);
        }
    }
    static void Main(string[] args)
    {
        int numwork = 5, numeng = 5, numemp = 5, kol = 0, kol1 = 0, kol2 = 0, comwork, comwork1, comeng, comeng1, comemp, comemp1;
        int command = 0;

        Worker[] Worker = new Worker[numwork];
        Engineer[] Engineer = new Engineer[numeng];
        Employee[] Employee = new Employee[numemp];
        do
        {
        link:
            Console.WriteLine("\n1-создать рабочего\n2-создать инженера\n3-создать служащего\n4-показать рабочих\n5-показать инженеров\n6-показать служащих\n7-сравнить рабочих\n8-сравнить инженеров\n9-сравнить сотрудников");
            command = Convert.ToInt32(Console.ReadLine());

            if (command == 1)
            {
            link7:
                Console.WriteLine("Сколько создать рабочих? ");
                try
                {
                    numwork = Convert.ToInt32(Console.ReadLine());
                    kol = numwork;
                }
                catch
                {
                    Console.WriteLine("Значение должно быть числовым");
                    goto link7;
                }
                for (int i = 0; i < numwork; i++)
                {
                    Worker[i] = new Worker();
                }
                for (int i = 0; i < numwork; i++)
                {
                    Console.WriteLine("\nРабочий №" + (i + 1));
                    Worker[i].vvod();
                }
            }
            else if (command == 2)
            {
            link8:
                Console.WriteLine("Сколько создать инженеров? ");
                try
                {
                    numeng = Convert.ToInt32(Console.ReadLine());
                    kol1 = numeng;
                }
                catch
                {
                    Console.WriteLine("Значение должно быть числовым");
                    goto link8;
                }
                for (int i = 0; i < numeng; i++)
                {
                    Engineer[i] = new Engineer();
                }
                for (int i = 0; i < numeng; i++)
                {
                    Console.WriteLine("\nИнженер №" + (i + 1));
                    Engineer[i].vvod();
                }
            }
            else if (command == 3)
            {
            link9:
                Console.WriteLine("Сколько создать сотрудников? ");
                try
                {
                    numemp = Convert.ToInt32(Console.ReadLine());
                    kol2 = numemp;
                }
                catch
                {
                    Console.WriteLine("Значение должно быть числовым");
                    goto link9;
                }
                for (int i = 0; i < numemp; i++)
                {
                    Employee[i] = new Employee();
                }
                for (int i = 0; i < numemp; i++)
                {
                    Console.WriteLine("\nСотрудник №" + (i + 1));
                    Employee[i].vvod();
                }
            }
            else if (command == 4)
            {
                if (kol == 0)
                {
                    Console.WriteLine("Рабочие еще не созданы!");
                }
                else
                {
                    for (int i = 0; i < numwork; i++)
                    {
                        Console.WriteLine("\nРабочий №" + (i + 1));
                        Worker[i].vivod();
                    }
                }
            }
            else if (command == 5)
            {
                if (kol1 == 0)
                {
                    Console.WriteLine("Инженеры еще не созданы!");
                }
                else
                {
                    for (int i = 0; i < numeng; i++)
                    {
                        Console.WriteLine("\nИнженер №" + (i + 1));
                        Engineer[i].vivod();
                    }
                }
            }
            else if (command == 6)
            {
                if (kol2 == 0)
                {
                    Console.WriteLine("Служащие еще не созданы!");
                }
                else
                {
                    for (int i = 0; i < numemp; i++)
                    {
                        Console.WriteLine("\nСлужащий №" + (i + 1));
                        Employee[i].vivod();
                    }
                }
            }
            else if (command == 7)
            {
                if (kol == 0 || kol == 1)
                {
                    Console.WriteLine("Создано недостаточно объектов!");
                    goto link;
                }
            link1:
                Console.WriteLine("Введите номер рабочего: ");
                try
                {
                    comwork = Convert.ToInt32(Console.ReadLine());
                    comwork = comwork - 1;
                }
                catch
                {
                    Console.WriteLine("несуществующий номер");
                    goto link1;
                }
                if (comwork + 1 > numwork)
                {
                    Console.WriteLine("Несуществующий номер!");
                    goto link1;
                }
            link2:
                Console.WriteLine("Введите номер с которым сравнить: ");
                try
                {
                    comwork1 = Convert.ToInt32(Console.ReadLine());
                    comwork1 = comwork1 - 1;
                }
                catch
                {
                    Console.WriteLine("несуществующий номер");
                    goto link2;
                }
                if (comwork1 + 1 > numwork)
                {
                    Console.WriteLine("несуществующий номер");
                    goto link2;
                }
                if (Worker[comwork].Equals(Worker[comwork1]))
                {
                    Console.WriteLine("Одинаковые");
                }
                else Console.WriteLine("Разные");
            }
            else if (command == 8)
            {
                if (kol1 == 0 || kol1 == 1)
                {
                    Console.WriteLine("Создано недостаточно объектов!");
                    goto link;
                }
            link3:
                Console.WriteLine("Введите номер инженера: ");
                try
                {
                    comeng = Convert.ToInt32(Console.ReadLine());
                    comeng = comeng - 1;
                }
                catch
                {
                    Console.WriteLine("нусуществующий номер");
                    goto link3;
                }
                if (comeng + 1 > numeng)
                {
                    Console.WriteLine("несуществующий номер");
                    goto link3;
                }
            link4:
                Console.WriteLine("Введите номер с которым сравнить: ");
                try
                {
                    comeng1 = Convert.ToInt32(Console.ReadLine());
                    comeng1 = comeng1 - 1;
                }
                catch
                {
                    Console.WriteLine("нусуществующий номер");
                    goto link4;
                }
                if (comeng1 + 1 > numeng)
                {
                    Console.WriteLine("несуществующий номер");
                    goto link4;
                }
                if (Engineer[comeng].Equals(Engineer[comeng1]))
                {
                    Console.WriteLine("Одинаковые");
                }
                else Console.WriteLine("Разные");
            }
            else if (command == 9)
            {
                if (kol2 == 0 || kol2 == 1)
                {
                    Console.WriteLine("созднано недостаточно объкетов!");
                    goto link;
                }
            link5:
                Console.WriteLine("Введите номер служащего: ");
                try
                {
                    comemp = Convert.ToInt32(Console.ReadLine());
                    comemp = comemp - 1;
                }
                catch
                {
                    Console.WriteLine("нусуществующий номер");
                    goto link5;
                }
                if (comemp + 1 > numemp)
                {
                    Console.WriteLine("несуществующий номер");
                    goto link5;
                }
            link6:
                Console.WriteLine("Введите номер с которым сравнить: ");
                try
                {
                    comemp1 = Convert.ToInt32(Console.ReadLine());
                    comemp1 = comemp1 - 1;
                }
                catch
                {
                    Console.WriteLine("нусуществующий номер");
                    goto link6;
                }
                if (comemp1 + 1 > numemp)
                {
                    Console.WriteLine("несуществующий номер");
                    goto link6;
                }
                if (Employee[comemp].Equals(Employee[comemp1]))
                {
                    Console.WriteLine("Одинаковые");
                }
                else Console.WriteLine("Разные");
            }
        } while (command == 0 || command != 1 || command != 2 || command != 3 || command != 4 || command != 5 || command != 6 || command != 7 || command != 8 || command != 9);
    }
}
