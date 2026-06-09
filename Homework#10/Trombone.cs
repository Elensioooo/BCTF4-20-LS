

namespace Homework_10
{
    internal class Trombone : MusicalInstrument
    {
        public Trombone():base("Trombone")
        {
            Console.WriteLine("The Instrument is Trombone");
        }
        public override void Sound()
        {
            Console.WriteLine("Trombone Sound");
        }
        public override void Show()
        {
            Console.WriteLine("The Instrument Name is Trombone");
        }
        public override void Desc()
        {
            Console.WriteLine("The trombone is a brass instrument with a deep, powerful sound.");
        }
        public override void History()
        {
            Console.WriteLine("The trombone was developed in 15th-century Germany.");
        }
    }
}
