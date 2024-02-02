using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab3App
{
    internal class MagicWand : Tool
    {

        private String description;
        public MagicWand(string description) :base(description)
        {
            this.description = description;
           
        }

      
        public override void DoAction()
        {
            Console.WriteLine("MagicWand is Used");
        }

        public override void Display()
        {
            Console.WriteLine("MagicWand " + description + " is displayed");
        }
    }
}