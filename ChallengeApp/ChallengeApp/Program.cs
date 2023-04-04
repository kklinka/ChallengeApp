using ChallengeApp;

Employee employee1 = new Employee("Kasia", "Kowalska", 43);
Employee employee2 = new Employee("Bartek", "Nowak", 44);
Employee employee3 = new Employee("Michał", "Miozga", 53);

employee1.AddScore(5);
employee1.AddScore(9);
employee1.AddScore(2);
employee1.AddScore(3);
employee1.AddScore(4);

employee2.AddScore(3);
employee2.AddScore(4);
employee2.AddScore(5);
employee2.AddScore(4);
employee2.AddScore(7);

employee3.AddScore(4);
employee3.AddScore(7);
employee3.AddScore(8);
employee3.AddScore(6);
employee3.AddScore(7);

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
   if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine("Najwyższą ocenę uzyskał:");
Console.WriteLine(employeeWithMaxResult.Name+" "+employeeWithMaxResult.Surname);
Console.WriteLine("Lat: "+employeeWithMaxResult.Age);
Console.WriteLine("Ocena: "+ maxResult);
