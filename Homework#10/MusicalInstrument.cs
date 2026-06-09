

namespace Homework_10
{
    internal abstract class MusicalInstrument
    {
        public string Name { get; set; }

        public MusicalInstrument(string name)
        {
            Name = name;
        }
        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();
        public abstract void History();
    }
}
