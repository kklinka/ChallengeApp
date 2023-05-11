using ChallengeApp;
using System;

var employee1 = new Employee("Kasia", "Kowalska", 43);
var employee2 = new Employee("Bartek", "Nowak", 44);
employee1.AddGrade(2);
employee1.AddGrade(3);
employee1.AddGrade(5);

employee2.AddGrade(6);
employee2.AddGrade(4);
employee2.AddGrade(2);

var statistics1 = employee1.GetStatisties();
var statistics2 = employee2.GetStatisties();


Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");

Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");