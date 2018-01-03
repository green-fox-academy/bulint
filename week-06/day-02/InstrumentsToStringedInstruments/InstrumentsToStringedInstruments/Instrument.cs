namespace InstrumentsToStringedInstruments
{
    abstract class Instrument
    {
        public string Name { get; set; }

        public abstract void Play();
    }
}
