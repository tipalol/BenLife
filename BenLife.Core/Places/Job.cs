namespace BenLife.Core.Places
{
    internal class Job : Place
    {
        private const float BaseIncome = 5;
        private const float TiredModifer = 1.1f;
        private const float MoodModifer = 0.8f;
        
        public override void Go(Person person)
        {
            base.Go(person);

            person.Relax(TiredModifer);
            person.ChangeMood(MoodModifer);
            person.EarnMoney(BaseIncome);
        }
    }
}