
using ConsoleApp2_clPerson;

void main()
{
    IPerson _person = new Person_Data();
    int menu = 1;
    while(menu != 0)
    {
        if(menu == 1)
        {
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Menu");
            Console.WriteLine("2 - AddPerson");
            Console.WriteLine("3 - PrintPerson");
            Console.WriteLine("4 - WriteFile - Person");
            Console.WriteLine("5 - ReadFile - Person");
            Console.Write("Enter Menu__ ");
            menu = Int32.Parse(Console.ReadLine());

        }
        else if(menu == 2)
        {
            Person person = new Person();
            Console.Clear();
            Console.Write("Enter First Name__ ");
            person.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name__ ");
            person.LastName = Console.ReadLine();
            Console.Write("Enter Age__ ");
            person.Age = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Other Info__ ");
            person.OtherInfo = Console.ReadLine();
            _person.AddPerson(person);
            Console.Clear();
            Console.WriteLine("\t\t\t Data added successfully");
            Thread.Sleep(10);
            menu = 1;
            Console.Clear();

        }
        else if(menu == 3)
        {
            Console.Clear();
            List < Person > p= _person.Print_AllPerson();

            if(p!=null)
            {
                foreach(var l in p)
                {
                    Console.WriteLine("FirstName - " + l.FirstName + " LastName - " + l.LastName);
                    Console.WriteLine("Age - " + l.Age);
                    Console.WriteLine("Other Info - " + l.OtherInfo);
                }
            }

            Console.ReadKey();
            Console.Clear();
            menu = 1;
        }
        else if(menu == 4)
        {
            Console.Write("Enter Path File__ ");
            string path = Console.ReadLine();
            if(path != null)
            {
                _person.WriteFile(path);
            }
            else
            {
                Console.WriteLine("Error!");
            }
            menu = 1;
            Console.Clear();
           
        }
        else if (menu == 5)
        {
            Console.Write("Enter Path File__ ");
            string path = Console.ReadLine();
            if (path != null)
            {
                _person.ReadFile(path);
            }
            else
            {
                Console.WriteLine("Error!");
            }
            menu = 1;
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Goodbaye");
            break;
        }

    }

}

main();
