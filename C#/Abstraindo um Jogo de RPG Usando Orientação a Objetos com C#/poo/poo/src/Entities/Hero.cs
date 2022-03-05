using System;
using System.Collections.Generic;
using System.Text;

namespace poo.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string Type)
        {
            this.Name = Name;
            this.Level = Level;
            this.Type = Type;
        }

        public Hero()
        {

        }

        public string Name;
        public int Level;
        public string Type;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.Type;
        }

        public virtual string Attack()
        {
            return this.Name + " usou a sua espada.";
        }

    }
}
