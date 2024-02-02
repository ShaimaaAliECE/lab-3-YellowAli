using System;
using System.Collections.Generic;

namespace Lab3App
{
	internal class Tool : Collectable
	{


        private String description;

        public Tool(String description)
        {
            this.description = description;
        }
        public virtual void DoAction()
        {

        }

        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(this.description + " Collected, Congrats!!!!");
            DoAction();
        }
    }
}

