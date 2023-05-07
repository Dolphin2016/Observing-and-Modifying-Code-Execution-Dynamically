using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared;

public class Animal
{
    [Coder("Mark Price", "22 August 2022")]
    [Coder("Johnni Rasmussen", "13 September 2022")]
    [Obsolete($"use {nameof(SpeakBetter)} instead.")]
    public void Speak()
    {
        WriteLine("Woof...");
    }

    public void SpeakBetter()
    {
        WriteLine("Woooooooooooooof...");
    }
}
