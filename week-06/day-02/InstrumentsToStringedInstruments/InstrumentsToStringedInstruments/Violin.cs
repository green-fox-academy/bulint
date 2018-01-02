using System;

namespace InstrumentsToStringedInstruments
{
    class Violin : StringedInstrument
    {
        public Violin(int numberOfStrings)
        {
            numberOfStrings = NumberOfStrings;
        }

        public Violin()
        {
            NumberOfStrings = 4;
        }

        public override void Play()
        {
            Sound();
        }

        public override void Sound()
        {
            Console.WriteLine("Screech");
        }
    }
}
