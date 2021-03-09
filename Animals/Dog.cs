using System.Diagnostics;

namespace Animals
{
    public class Dog : Animal
    {
        public override void Eat()
        {
            Debug.WriteLine("Dog eats.");
        }

        public override void Speak()
        {
            Debug.WriteLine("Dog speaks.");
        }
    }
}
