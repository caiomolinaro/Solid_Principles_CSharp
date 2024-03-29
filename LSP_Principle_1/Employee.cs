﻿namespace LSP_Principle_1;

internal class Employee
{
    public Employee(string? name, string? role)
    {
        Name = name;
        Role = role;
    }

    private string? Name { get; set; }
    private string? Role { get; set; }

    public virtual Double CalculateSalary(double salary)
    {
        return salary;
    }
}