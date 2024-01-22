using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Principle3;

internal class FlyingBirds : Bird
{
    public FlyingBirds(string name) : base(name)
    { }

    public virtual void Fly()
    {
        Console.WriteLine($"{Name} penguim can't fly");
    }
}