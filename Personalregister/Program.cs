// Oppgave 1 - Vilka klasser bör ingå i programmet?
// 
// Employee        - Representerar en anställd med namn och lön
// EmployeeRegister - Hanterar och lagrar en lista av anställda
// Program         - Startpunkt för applikationen, hanterar användarens input

// Oppgave 2 - Vilka attribut och metoder bör ingå i dessa klasser?
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
            Console.WriteLine("Hello, World!");
        }
    }
}
