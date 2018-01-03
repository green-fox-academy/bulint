using System;

namespace InstrumentsToStringedInstruments
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar(int numberOfStrings)
        {
            numberOfStrings = NumberOfStrings;
            Name = "Electric guitar";
        }

        public ElectricGuitar()
        {
            NumberOfStrings = 6;
            Name = "Electric guitar";
        }

        public override void Play()
        {
            Console.WriteLine(Name + ", a " + NumberOfStrings + " stringed instrument that goes " + Sound());
        }

        public override string Sound()
        {
            return "Twang";
        }
    }
}
