namespace P01._FileStream_Before
{
    public class Progress
    {
        private readonly IProgresable progresable;

        public Progress(IProgresable progresable)
        {
            this.progresable = progresable;
        }

        public int CurrentPercent()
        {
            return this.progresable.Sent * 100 / this.progresable.Length;
        }
    }
}
