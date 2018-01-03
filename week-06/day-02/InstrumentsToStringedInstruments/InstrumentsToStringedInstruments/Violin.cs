using System;

namespace InstrumentsToStringedInstruments
{
    class Violin : StringedInstrument
    {
        public Violin(int numberOfStrings)
        {
            numberOfStrings = NumberOfStrings;
            Name = "Violin";
        }

        public Violin()
        {
            NumberOfStrings = 4;
            Name = "Violin";
        }

        public override void Play()
        {
            Console.WriteLine(Name + ", a " + NumberOfStrings + " stringed instrument that goes " + Sound());
        }

        public override string Sound()
        {
            return "Screech";
        }
    }
}
