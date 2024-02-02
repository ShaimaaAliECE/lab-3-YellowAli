using System;
namespace Lab3App
{
	internal class Diamond : Treasure
	{

		private String plx;
        public Diamond(String plx, int score) : base(score,plx)
		{

			this.plx = plx;
		}

        public override void Display()
        {
            Console.WriteLine("Diamond " + plx + " is displayed");
        }

    }
}

