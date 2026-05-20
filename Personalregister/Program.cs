// Uppgift 1  - Vilka klasser bör ingå i programmet?
// 
// Employee        - Representerar en anställd med namn och lön
// EmployeeRegister - Hanterar och lagrar en lista av anställda
// Program         - Startpunkt för applikationen, hanterar användarens input

// Uppgift 2   - Vilka attribut och metoder bör ingå i dessa klasser?
//
// Employee:
//   Attribut:
//     - Name (string)   : Den anställdes namn
//     - Salary (decimal): Den anställdes lön
//   Metoder:
//     - Employee(name, salary) : Konstruktor som sätter namn och lön
//     - ToString()             : Returnerar en formaterad sträng med info om den anställde
//
// EmployeeRegister:
//   Attribut:
//     - _employees (List<Employee>) : Lista som lagrar alla anställda
//   Metoder:
//     - AddEmployee(employee) : Lägger till en anställd i listan
//     - PrintAll()            : Skriver ut alla anställda i registret
//
// Program:
//   Metoder:
//     - Main(args) : Startar programmet och hanterar menyval från användaren





namespace Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeRegister register = new EmployeeRegister();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n1. Lägg till anställd");
                Console.WriteLine("2. Visa alla anställda");
                Console.WriteLine("3. Avsluta");
                Console.Write("Välj: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Namn: ");
                        string name = Console.ReadLine();

                        Console.Write("Lön: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal salary) && salary >= 0)
                        {
                            register.AddEmployee(new Employee(name, salary));
                            Console.WriteLine($"{name} har lagts till.");
                        }
                        else
                        {
                            Console.WriteLine("Ogiltig lön. Försök igen.");
                        }
                        break;

                    case "2":
                        register.PrintAll();
                        break;

                    case "3":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
            }
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Namn: {Name,-20} Lön: {Salary:C}";
        }
    }

    class EmployeeRegister
    {
        private List<Employee> _employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public void PrintAll()
        {
            if (_employees.Count == 0)
            {
                Console.WriteLine("Inga anställda i registret.");
                return;
            }

            Console.WriteLine("\n========= Personalregister =========");
            Console.WriteLine($"{"Namn",-20} {"Lön"}");
            Console.WriteLine(new string('-', 36));

            foreach (var emp in _employees)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine(new string('=', 36));
            Console.WriteLine($"Totalt antal anställda: {_employees.Count}");
        }
    }
}