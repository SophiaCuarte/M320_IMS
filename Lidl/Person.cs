﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl
{
    public abstract class Person
    {
        public string Name { get; set; }  
        public string Vorname { get; set; }

        public void Esse()
        {
            Console.WriteLine($"Person: {Vorname} {Name} isst gern fortniter");
        }

        //public virtual void Trage()
        //{
        //    Console.WriteLine($"Person {Vorname} {Name} trägt mit...");
        //}

        public abstract void Trage();
    }
}
