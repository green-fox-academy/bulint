using System;

namespace InstrumentsToStringedInstruments
{
    class BassGuitar : StringedInstrument
    {
        public BassGuitar(int numberOfStrings)
        {
            numberOfStrings = NumberOfStrings;
            Name = "Bass guitar";
        }

        public BassGuitar()
        {
            NumberOfStrings = 4;
            Name = "Bass guitar";
        }

        public override void Play()
        {
            Console.WriteLine(Name + ", a " + NumberOfStrings + " stringed instrument that goes " + Sound());
        }

        public override string Sound()
        {
            return "Duum duum duum";
        }
    }
}
