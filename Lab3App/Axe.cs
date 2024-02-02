using System;

namespace Lab3App
{
    internal class Axe : Tool
    {
        private String description;
        public Axe(string description) :base(description)
        {
            this.description = description;

        }

        

        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }

        public override void Display()
        {
            Console.WriteLine("Axe " + description +" is displayed");
        }
    }
}