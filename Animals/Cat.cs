using System.Diagnostics;

namespace Animals
{
    public class Cat : Animal
    {
        public override void Eat()
        {
            Debug.WriteLine("Cat eats.");
        }

        public override void Speak()
        {
            Debug.WriteLine("Dog speaks.");
        }
    }
}
