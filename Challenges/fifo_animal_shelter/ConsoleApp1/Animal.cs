﻿using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter
{
    public class Animal
    {
        public string type { get; set; }
        public Animal next { get; set; }
        public Animal(string AnimalType)
        {
            type = AnimalType;
        }
    }
}
