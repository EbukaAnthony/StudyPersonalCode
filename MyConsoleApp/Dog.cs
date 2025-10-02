using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    internal class Dog
    {
        private string name;
        private string color;
        private string description;
        private int age;
        
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public Dog()
        {
            this.name = "";
            this.color = "";
            this.description = "";
            this.age = 0;
        }

        public Dog(string name, string color, string description, int age)
        {
            this.name = name;
            this.color = color;
            this.description = description;
            this.age = age;
        }


        public string ValidateName(string name)
        {
            if (name is null)
            {
                return "Name cannot be null";
            }
            return name;
        }

        public string ValidateColor(string color)
        {
            if (color == null)
            {
                return "Color cannot be null";
            }
            return color;
        }

        public string ValidateDescription(string description)
        {
            if (description is null)
            {
                return "Description cannot be null";
            }
            return description;
        }

        public int ValidateAge(int age)
        {
            if (age <= 0)
            {
                return 0;
            }
            return age;
        }
    }
}
