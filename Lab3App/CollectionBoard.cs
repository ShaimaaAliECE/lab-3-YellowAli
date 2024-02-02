namespace Lab3App
{
    internal class CollectionBoard
    {
        private int TotalScore;
        private int TotalValue;
        public CollectionBoard()
        {
        

        }

        public int totalScore
        {
            get
            {
                return this.TotalScore;

            }
            set
            {
                this.TotalScore = value;

            }
        }

        public int totalvalue
        {
            get
            {
                return this.TotalValue;
            }
            set
            {
                this.TotalValue = value;
            }
        }
    }
}