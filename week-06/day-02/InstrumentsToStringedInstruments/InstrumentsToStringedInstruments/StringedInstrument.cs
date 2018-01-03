namespace InstrumentsToStringedInstruments
{
    abstract class StringedInstrument : Instrument
    {
        public int NumberOfStrings { get; set; }

        public abstract override void Play();
        public abstract string Sound();

    }
}
