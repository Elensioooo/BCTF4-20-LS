
namespace Homework_10
{
    internal class Ukulele : MusicalInstrument
    {
        public Ukulele() : base("Ukulele")
        {
            Console.WriteLine("The instrument is Ukulele");
        }
        public override void Sound()
        {
            Console.WriteLine("UkuleleSound");
        }
        public override void Show()
        {
            Console.WriteLine("The Instrument Name is Ukulele");
        }
        public override void Desc()
        {
            Console.WriteLine("The ukulele is a small four-string instrument with a bright sound.");
        }
        public override void History()
        {
            Console.WriteLine("The ukulele originated in Hawaii in the late 19th century");
        }
    }
}
