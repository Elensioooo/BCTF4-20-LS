

namespace Homework_10
{
    internal class Cello : MusicalInstrument
    {
      
        public Cello():base("Cello")
        {
            Console.WriteLine("The Instrument is Cello");
        }
        public override void Sound()
        {
            Console.WriteLine("Cello Sound");

        }
        public override void Show()
        {
            Console.WriteLine("Instrument Name is Cello");
        }
        public override void Desc()
        {
            Console.WriteLine("A cello is a large four-stringed bowed instrument");
        }
        public override void History()
        {
            Console.WriteLine("The cello originated in 16th-century Italy");
        }
    }
}
