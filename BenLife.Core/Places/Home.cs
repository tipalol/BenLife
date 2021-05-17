namespace BenLife.Core.Places
{
    internal class Home : Place
    {
        private const float TiredModifer = 0.8f;
        
        public override void Go(Person person)
        {
            base.Go(person);

            person.Relax(TiredModifer);
        }
    }
}