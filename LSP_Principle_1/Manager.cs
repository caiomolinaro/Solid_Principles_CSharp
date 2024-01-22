using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Principle_1;

internal class Manager : Employee
{
    private double bonus = 3000;

    public Manager(string name, string role) : base(name, role)
    { }

    public override double CalculateSalary(double salary)
    {
        return salary + bonus;
    }
}