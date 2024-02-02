using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab3App
{
    internal class Coin : Treasure
    {
        private int value;
        private String discrep;

        public Coin(string discrep,int score, int value):base(score,discrep)
        {
            this.discrep = discrep;
            this.value = value;
           
        }

        public void UpdateTotalValue()
        {
            Board.totalvalue = Board.totalvalue + value;
            Console.WriteLine("Total value is updated to: " + (Board.totalvalue));
            
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue();
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + discrep + " is displayed");
        }
    }

}