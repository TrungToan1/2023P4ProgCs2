﻿    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMon
    {

        public ConsoleMon() 
        {

        }

        internal ConsoleMon(int health, int energy, string name, Element weakness)
        {
            this.health = health;
            this.energy = energy;
            this.name = name;
            this.weakness = weakness;

        }
        
        public int health { get; set; }
        public int energy { get; set; }
        public string name { get; set; }
        public List<Skill> skills { get; set; }
        public Element weakness { get; set; }




        internal void TakeDamage(int damage)
        {
            health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;

        }





    }




}
