namespace BenLife.Core.Places
{
    internal abstract class Place : IPlace
    {
        public string Name { get; set; }

        public virtual void Go(Person person)
        {
            person.BecomeHungry();
            person.BecomeTired();

            if (person.Hungry >= 0.9f)
                person.Hurt(1f);

            if (person.Tired >= 0.9f)
                person.Hurt(1f);

            //Generate random event
        }
    }
}