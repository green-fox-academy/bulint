using System;

namespace InstrumentsToStringedInstruments
{
    class BassGuitar : StringedInstrument
    {
        public BassGuitar(int numberOfStrings)
        {
            numberOfStrings = NumberOfStrings;
        }

        public BassGuitar()
        {
            NumberOfStrings = 4;
        }

        public override void Play()
        {
            Sound();
        }

        public override void Sound()
        {
            Console.WriteLine("Duum Duum Duum");
        }
    }
}
