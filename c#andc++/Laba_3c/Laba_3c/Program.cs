using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3c
{
    class Program
    {
        static void Main(string[] args)
        {  
            public class record
        {
            public int id;
            public string Name;
            public string Surname;
            public DateTime Birthday;
            public string PhoneNumber;

            public record(int id, string Name, string Surname, DateTime Birthday, string PhoneNumber)
            {
                this.id = id;
                this.Name = Name;
                this.Surname = Surname;
                this.Birthday = Birthday;
                this.PhoneNumber = PhoneNumber;
            }
        }

        public class Notebook
        {
            private List<record> notebookRecords;
            public List<record> NotebookRecords
            {
                get { return notebookRecords; }
                set { notebookRecords = value; }
            }

            public Notebook()
            {
                notebookRecords = new List<record>();
            }

            public List<record> SearchRecords(string Name, string Surname, DateTime? Birthday, string PhoneNumber)
            {
                List<record> ret = new List<record>();
                foreach (record rec in notebookRecords)
                    if (rec.Name == Name || rec.Surname == Surname || rec.Birthday == Birthday || rec.PhoneNumber == PhoneNumber)
                        ret.Add(rec);
                return ret;
            }

            public void AddRecord(int id, string Name, string Surname, DateTime Birthday, string PhoneNumber)
            {
                record rec = new record(id, Name, Surname, Birthday, PhoneNumber);
                notebookRecords.Add(rec);
            }

            public void DeleteRecords(string Name, string Surname, DateTime Birthday, string PhoneNumber)
            {
                List<record> records = SearchRecords(Name, Surname, Birthday, PhoneNumber);
                foreach (record rec in records)
                    notebookRecords.Remove(rec);
            }

            public void SortBySurname()
            {
                notebookRecords.OrderBy(x => x.Surname);
            }

            private void test()
            {
                SearchRecords(null, null, null, null); //вернёт все записи
            }
        

    }
    }
}
