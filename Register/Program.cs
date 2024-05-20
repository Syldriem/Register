

namespace Register
{
    internal class Program
    {
        public class Employee
        {
            public string Name { get; set; }
            public int Salary { get; set; }

            public Employee(string name, int salary)
            {
                Name = name;
                Salary = salary;
            }
        }
        static List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1. Add an employee");
                Console.WriteLine("2. Show all employees");
                Console.WriteLine("3. Exit");
                Console.Write("Input corresponding number: ");

                string opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        ShowRegister();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("you must choose 1, 2 or 3");
                        break;
                }
            }
        }

        private static void ShowRegister()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees in register");
                return;
            }
            foreach (var emp in employees)
            {
                Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}");
            }

        }

        private static void AddEmployee()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Salary: ");
            if (int.TryParse(Console.ReadLine(), out int salary))
            {
                employees.Add(new Employee(name, salary));
            } else
            {
                Console.WriteLine("Salary must be a number");
                return;
            }
        }
    }
}
