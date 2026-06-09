

namespace Homework_10
{
    internal class Violin : MusicalInstrument
    {
        public Violin() : base("Violin")
        {
            Console.WriteLine("The instrument is Violin");
        }
        public override void Sound() 
        {
            Console.WriteLine("Violin Sound");
        }
        public override void Show()
        {
            Console.WriteLine("The Instrument Name is Violin");
        }
        public override void Desc()
        {
            Console.WriteLine("The violin is a four-string instrument with a clear sound.");
        }
        public override void History()
        {
            Console.WriteLine("The violin was developed in 16th-century Italy.");
        }
    }
}
