using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Collectable : Displayable
    {
        public CollectionBoard Board;
        private string description;

        

        public virtual void Display()
        {
            Console.WriteLine(description+" is displayed");
        }

        public virtual void AddMe(List<Collectable> list)
        {
                list.Add(this);
                Console.WriteLine(this.description + " Collected, Congrats!!!!");
        }

        
    }
}