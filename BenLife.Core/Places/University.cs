namespace BenLife.Core.Places
{
    internal class University : Place
    {
        private const float TiredModifer = 1.2f;
        private const float MoodModifer = 0.8f;
        
        public override void Go(Person person)
        {
            base.Go(person);

            person.Relax(TiredModifer);
            person.ChangeMood(MoodModifer);
        }
    }
}