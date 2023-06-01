using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    class Program
    {
        public class Date
        {
            int year;

            public int Year
            {
                get { return year; }
                set
                {
                    
                    year = value;
                }
            }

            int month;

            public int Month
            {
                get { return month; }
                set
                {
                    
                    month = value;
                }
            }

            int day;
            public int Day
            {
                get { return day; }
                set
                {
                    
                    day = value;
                }
            }

            public Date()
            {
                year = 2002;
                month = 1;
                day = 1;
            }


            public override string ToString()
            {
                return day+"."+month + "."+year;
            }



            public static int NDaysMonthYear(int m, int y)
            {
                return (int)(28 + ((m + Math.Floor((double)m / 8)) % 2) + 2 % m + Math.Floor((double)(1 + (1 - (y % 4 + 2) % (y % 4 + 1)) * ((y % 100 + 2) % (y % 100 + 1)) + (1 - (y % 400 + 2) % (y % 400 + 1))) / m) + Math.Floor(1.0 / m) - Math.Floor((double)((1 - (y % 4 + 2) % (y % 4 + 1)) * ((y % 100 + 2) % (y % 100 + 1)) + (1 - (y % 400 + 2) % (y % 400 + 1))) / m));
            }

        }

        public class Record
        {
            private string surname;
            public string Surname
            {
                get { return surname; }
                set
                {

                    //foreach (var item in value)
                    //{
                    //    if (item >= '0' && item <= '9')
                    //        throw new Exception("Цифры в фамилии");
                    //}
                    surname = value;
                }
            }

            private string name;
            public string Name
            {
                get { return name; }
                set
                {

                    
                    name = value;
                }
            }

            private string num;
            public string Phone
            {
                get { return num; }
                set
                {
                    


                   

                    num = value;
                }
            }

            public Date DateBirth { get; set; } = new Date();





            public Record(string Surname, string Name, string Phone)
            {
                this.Surname = Surname;
                this.Name = Name;
                this.Phone = Phone;
            }

            public Record()
            {
            }



            public override string ToString()
            {
                return Surname + ' ' + Name + ' ' + Phone+ " " + DateBirth;
            }



        }




        class Notebook
        {
           




            //список даёт возможность записывать в него какое угодно число записей
            private List<Record> records = new List<Record>();

            public int Count { get { return records.Count; } }



            public Notebook()
            { }




            public void Add(string Surname, string Name, string Phone)
            {
                records.Add(new Record(Surname, Name, Phone));
            }


            public void Add(Record record)
            {
                records.Add(record);
            }

            public void Del(int ind)
            {
                records.RemoveAt(ind);
            }

            public override string ToString()
            {
                string outStr = "";
                foreach (Record item in records)
                {
                    outStr += item.ToString();
                    outStr += '\n';
                }
                return outStr;
            }


            public Notebook Search(string Surname)
            {
                Notebook notebook = new Notebook();
                foreach (Record item in records)
                {
                    if (item.Surname == Surname)
                        notebook.Add(item);
                }
                return notebook;
            }




            public void SortDate()
            {
                records.Sort((x, y) => (x.DateBirth.Year*365+ x.DateBirth.Month*30+ x.DateBirth.Day).CompareTo(y.DateBirth.Year * 365 + y.DateBirth.Month * 30 + y.DateBirth.Day));
            }

            public void SortSur()
            {
                records.Sort((x, y) => x.Surname.CompareTo(y.Surname));
            }

            public void SortName()
            {
                records.Sort((x, y) => x.Name.CompareTo(y.Name));
            }

            public void SortPhone()
            {
                records.Sort((x, y) => x.Phone.CompareTo(y.Phone));
            }
        }











        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();

            int vibor;
            do
            {
                ViborERR:
                try
                {
                    Console.Write(
                        "1. Добавить\n" +
                        "2. Удалить\n" +
                        "3. Сортировать\n" +
                        "4. Поиск\n" +
                        "5. Вывод\n" +
                        "0. Выход\n" +
                        "Выберите: "
                        );
                    vibor = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto ViborERR;
                }


                switch (vibor)
                {
                    case 1:
                        {
                            Record record = new Record();

                        SurERR:
                            try
                            {
                                Console.Write("Введите фамилию: ");
                                record.Surname = Console.ReadLine();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                goto SurERR;
                            }


                        NameERR:
                            try
                            {
                                Console.Write("Введите имя: ");
                                record.Name = Console.ReadLine();
                            }
                                catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                goto NameERR;
                            }


                        PhoneERR:
                            try
                            {
                                Console.Write("Введите номер телефона: ");
                            string value = Console.ReadLine();
                                foreach (var item in value)
                                {
                                    if (item < '0' || item > '9')
                                        throw new Exception("Буквы в номере телефона");
                                }

                                if (value.Length != 11)
                                    throw new Exception("Нужно 11 цифр");
                                record.Phone = value;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                goto PhoneERR;
                            }





                        MonthERR:
                            try
                            {
                                
                                Console.Write("Введите месяц рождения: ");
                                int value = int.Parse(Console.ReadLine());
                                if (value < 1 || value > 12)
                                    throw new Exception("Не верный месяц");
                                record.DateBirth.Month = value;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                goto MonthERR;
                            }


                        YearERR:
                            try
                            {
                                Console.Write("Введите год рождения: ");
                                int value = int.Parse(Console.ReadLine());
                                if (value < 1900 || value > 2022)
                                    throw new Exception("Не верный год");
                                record.DateBirth.Year = value;


                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                goto YearERR;
                            }


                        DayERR:
                            try
                            {
                                Console.Write("Введите день рождения: ");
                                int value = int.Parse(Console.ReadLine());
                                if (value < 1 || value > Date.NDaysMonthYear(record.DateBirth.Month, record.DateBirth.Year))
                                    throw new Exception("Не верный день");
                                record.DateBirth.Day = value;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                goto DayERR;
                            }



                            notebook.Add(record);
                            
                            
                        }
                        break;

                    case 2:
                        {
                        IndERR:
                            try
                            {
                                Console.Write("Введите индекс: ");
                                int ind = int.Parse(Console.ReadLine());
                                notebook.Del(ind);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                goto IndERR;
                            }
                        }
                        break;

                    case 3:
                        {
                        ViborSortERR:
                            try
                            {
                                Console.Write(
                                    "1. Фамилия\n" +
                                    "2. Имя\n" +
                                    "3. Номер телефона\n" +
                                    "4. Дата рождения\n" +
                                    "Выберите поле сортироваки: "
                                    );
                                vibor = int.Parse(Console.ReadLine());

                                if (vibor < 1 || vibor > 4)
                                    throw new Exception("Выберите существующий вариант");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                goto ViborSortERR;
                            }


                            switch (vibor)
                            {
                                case 1:
                                    notebook.SortSur();
                                    break;

                                case 2:
                                    notebook.SortName();
                                    break;

                                case 3:
                                    notebook.SortPhone();
                                    break;

                                case 4:
                                    notebook.SortDate();
                                    break;

                                default:
                                    break;
                            }


                            vibor = 3;
                        }
                        break;

                    case 4:
                        {
                            Notebook searh = new Notebook();

                            Console.Write("Введите фамилию для поиска: ");
                            string surname = Console.ReadLine();
                            searh = notebook.Search(surname);

                            if (searh.Count == 0)
                                Console.WriteLine("Ничего не найдено");
                            else
                                Console.WriteLine(searh.ToString());

                        }
                        break;

                    case 5:
                        Console.WriteLine(notebook.ToString());
                        break;

                    default:
                        break;
                }


            } while (vibor!=0);
        }
    }
}
