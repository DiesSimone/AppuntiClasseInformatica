﻿using ObjectsDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kid
{
    public void CallTheDog(Dog dog)
    {
        Console.WriteLine("Come, " + dog.Name);
    }
    public void WagTheDog(Dog dog)
    {
        dog.Bark();
    }
}
