using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_clPerson
{
    public interface IPerson
    {
        public List<Person> Print_AllPerson();
        public void WriteFile(string path);

        public List<Person> ReadFile(string path);

        public void AddPerson(Person person);


    }
}
