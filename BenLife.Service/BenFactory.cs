using BenLife.Core;

namespace BenLife.Service
{
    public class BenFactory
    {
        public Person GenerateBen()
            => new Person("Ben", 100f, 0f, 0f, 10f, 100f);
    }
}