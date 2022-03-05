using System;
using System.Collections.Generic;
using System.Text;

namespace poo.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string Type)
        {
            this.Name = Name;
            this.Level = Level;
            this.Type = Type;
        }
    }
}
