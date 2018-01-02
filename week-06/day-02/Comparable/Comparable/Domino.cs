using System;

namespace Comparable
{
    public class Domino : IComparable
    {
        private readonly int[] Values;
        private int A { get; set; }

        public Domino(int valueA, int valueB)
        {
            Values = new int[] { valueA, valueB };
            A = valueA;
        }

        public int CompareTo(object obj)
        {
            var otherDomino = obj as Domino;

            if (A > otherDomino.A)
            {
                return 1;
            }
            else if (A < otherDomino.A)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public int[] GetValues()
        {
            return Values;
        }
    }
}
