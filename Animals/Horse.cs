using System.Diagnostics;

namespace Animals
{
    public class Horse : Animal
    {
        public override void Eat()
        {
            Debug.WriteLine("Horse eats.");
        }

        public override void Speak()
        {
            Debug.WriteLine("Horse speaks.");
        }
    }
}
