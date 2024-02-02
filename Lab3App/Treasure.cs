using System;
using System.Collections.Generic;

namespace Lab3App
{
	internal class Treasure : Collectable
    {
		private int score;
		private String d;
	
		public Treasure(int score, String d )
		{
			this.d = d;
			this.score = score;

		}

		public void UpdateTotalScore()
		{
			Board.totalScore = score + Board.totalScore;

            Console.WriteLine("Total Score is Updated to: " + (Board.totalScore));
		}

        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(this.d + " Collected, Congrats!!!!");
            UpdateTotalScore();
        }


    }
}

