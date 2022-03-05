using System;
using System.Collections.Generic;
using System.Text;

namespace poo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string Type)
        {
            this.Name = Name;
            this.Level = Level;
            this.Type = Type;
        }

        public override string Attack()
        {
            return this.Name + " usou magia canalizada.";
        }

        public string Attack(int Critical)
        {
            if (Critical > 6)
            {
                return this.Name + " Lançou Magia Canalizada super efetiva com bônus de " + Critical;
            }
            else
            {
                return this.Name + " Lançou Magia Canalizada pouco efetiva";
            }

        }
    }
}
