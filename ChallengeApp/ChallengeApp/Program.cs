using ChallengeApp;
using System;

var employee = new Employee("Kasia", "Kowalska", 43);

employee.AddGrade(2);
employee.AddGrade(3);
employee.AddGrade(5);

var statistics = employee.GetStatisties();
var statistics1 = employee.GetStatistiesWithForEach();
var statistics2 = employee.GetStatistiesWithFor();
var statistics3 = employee.GetStatistiesWithDoWhile();
var statistics4 = employee.GetStatistiesWithWhile();


Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

