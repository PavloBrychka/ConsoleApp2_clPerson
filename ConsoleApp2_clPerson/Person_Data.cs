using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_clPerson
{
    public class Person_Data : IPerson
    {
        private readonly List<Person> _persons;

        public Person_Data()
        {
            _persons = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            _persons.Add(person);
        }

        public List<Person> Print_AllPerson()
        {
            return _persons;
        }

        public List<Person> ReadFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            Person person = new Person();
            while(sr.EndOfStream)
            {
                while(sr.ReadLine() != "*")
                {
                    person.FirstName = sr.ReadLine();
                    person.LastName = sr.ReadLine();
                    person.Age = Int32.Parse(sr.ReadLine());
                    person.OtherInfo = sr.ReadLine();
                    _persons.Add(person);
                    person = new Person();
                }
            }
            return _persons;
        }

        public void WriteFile(string path)
        {
           StreamWriter sw = new StreamWriter(path);
            
            foreach(var l in _persons)
            {
                sw.WriteLine(l.FirstName);
                sw.WriteLine(l.LastName);
                sw.WriteLine(l.Age);
                sw.WriteLine(l.OtherInfo);
                sw.WriteLine("*");
            }
           
            sw.Close();
        }
    }
}
