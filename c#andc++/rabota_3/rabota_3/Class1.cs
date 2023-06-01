using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rabota_3
{
    class Class1
    {
        public class Record
        {
            public int Id;
            public string Name;
            public string Surname;
            public DateTime Birthday;
            public string PhoneNumber;
            public static bool Brake = false;

            public Record(int id, string name, string surname, DateTime birthday, string phoneNumber)
            {
                Id = id;
                Name = name;
                Surname = surname;
                Birthday = birthday;
                PhoneNumber = phoneNumber;
            }
        }

        public class Notebook
        {
            private List<Record> _notebookRecords;

            public List<Record> NotebookRecords
            {
                get { return _notebookRecords; }
                set { _notebookRecords = value; }
            }

            public Notebook()
            {
                _notebookRecords = new List<Record>();
            }

            public List<Record> SearchRecords(Record r)
            {
                Console.WriteLine("Ввведите имя: ");
                r.Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите дату рожденя: ");
                r.Birthday = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Введите номер телефона: ");
                r.PhoneNumber = Convert.ToString(Console.ReadLine());

                var ret = _notebookRecords.Where(rec => rec.Name == r.Name
                || rec.Birthday == r.Birthday || rec.PhoneNumber == r.PhoneNumber).ToList();

                foreach (var record in ret)
                {
                    Console.WriteLine("Name: " + record.Name + "Birthday: "
                    + record.Birthday.ToString("R") + "Phone number: " + record.PhoneNumber);
                }

                return ret;
            }

            public void AddRecord(Record r)
            {
                Console.WriteLine("Enter ID");
                r.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");
                r.Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Surname");
                r.Surname = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Birthday");
                r.Birthday = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter phone number");
                r.PhoneNumber = Convert.ToString(Console.ReadLine());
                var rec = new Record(r.Id, r.Name, r.Surname, r.Birthday, r.PhoneNumber);
                _notebookRecords.Add(rec);
            }

            public void DeleteRecords(Record r)
            {
                Console.WriteLine("Enter Name");
                r.Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Surname");
                r.Surname = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Birthday");
                r.Birthday = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter phone number");
                r.PhoneNumber = Convert.ToString(Console.ReadLine());

                List<Record> records = SearchRecords(r);
                foreach (Record rec in records)
                    _notebookRecords.Remove(rec);
            }

            public void SortBySurname()
            {
                var n = _notebookRecords.OrderBy(x => x.Surname);
                foreach (var record in n)
                {
                    Console.WriteLine(record.Surname);//здесь выводится только 
                                                      //фамилия, можно конкатенировать все поля класса Record 
                }
            }
        }

        class Program
        {
            static void Main()
            {
                var r = new Record(0, null, null, new DateTime(), null);
                var n = new Notebook();

                while (true)
                {
                    Console.WriteLine("Выберите пункт\n1.добавить в книжку.\n2. удалить из книжки." +
                    "\n3. поиск по имени или дате или номеру телефона\n4. сортировка " +
                    "по фамилии и вывод книжки.\n5. выход из программы.");
                    var mode = Convert.ToInt32(Console.ReadLine());

                    switch (mode)
                    {
                        case 1:
                            n.AddRecord(r);
                            continue;
                        case 2:
                            n.DeleteRecords(r);
                            continue;
                        case 3:
                            n.SearchRecords(r);
                            continue;
                        case 4:
                            n.SortBySurname();
                            continue;
                        case 5:
                            Record.Brake = true;
                            break;
                    }
                }
            }
        }
    }
}

