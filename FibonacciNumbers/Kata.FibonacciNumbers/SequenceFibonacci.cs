namespace Kata.FibonacciNumbers
{
    public class SequenceFibonacci
    {
        internal int Returned;

        public int Sequence(int steps)
        {
            if (steps == 1 || steps == 2)
                Returned = 1;
            else if (steps > 2) Returned = Sequence(steps - 1) + Sequence(steps - 2);

            return Returned;
        }
    }
}