using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Principle3;

internal class Penguim : Bird
{
    public Penguim(string name) : base(name)
    { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} eat fish");
    }

    public override void LayEggs()
    {
        Console.WriteLine($"{Name} lay 2 eggs");
    }
}