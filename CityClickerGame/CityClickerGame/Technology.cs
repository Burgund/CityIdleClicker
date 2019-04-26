﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityClickerGame
{
    class Technology
    {
        private int id;
        private bool isInvented = false;
        private string name;
        private string description;

        public int Id { get => id; set => id = value; }
        public bool IsInvented { get => isInvented; set => isInvented = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }

        public Technology(string name, string description, int id)
        {
            this.name = name;
            this.description = description;
            this.id = id;
        }

        public Technology(string name, string description, int id, bool isInvented)
        {
            this.name = name;
            this.description = description;
            this.id = id;
            this.isInvented = isInvented;
        }
    }
}
