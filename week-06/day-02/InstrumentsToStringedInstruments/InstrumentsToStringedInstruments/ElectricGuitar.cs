using System;

namespace InstrumentsToStringedInstruments
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar(int numberOfStrings)
        {
            numberOfStrings = NumberOfStrings;
        }

        public ElectricGuitar()
        {
            NumberOfStrings = 6;
        }

        public override void Play()
        {
            Sound();
        }

        public override void Sound()
        {
            Console.WriteLine("Twaang!");
        }
    }
}
