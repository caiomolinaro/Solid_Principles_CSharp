using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Principle3;

internal class Duck : FlyingBirds
{
    public Duck(string name) : base(name)
    { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} eat corn");
    }

    public override void LayEggs()
    {
        Console.WriteLine($"{Name} lay 6 eggs");
    }

    public override void Fly()
    {
        Console.WriteLine($"{Name} fly low");
    }
}