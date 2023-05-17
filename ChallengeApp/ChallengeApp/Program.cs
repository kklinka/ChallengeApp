using ChallengeApp;
using System;

var employee = new Employee("Kasia", "Kowalska", 43);

employee.AddGrade(2);
employee.AddGrade(3);
employee.AddGrade(5);

var statistics = employee.GetStatisties();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

