using System;

namespace BenLife.Core.Places
{
    internal class Shop : Place
    {
        private const float BasePrice = 1;
        private const int MinPriceModifer = 5;
        private const int MaxPriceModifer = 15;

        private const float MoodModifer = 1.2f;
        private const float HungryModifer = 0.7f;

        private Random _random;
        
        public override void Go(Person person)
        {
            base.Go(person);

            _random ??= new Random();
            
            var priceModifer = _random.Next(MinPriceModifer, MaxPriceModifer) / 10f;
            var price = BasePrice * priceModifer;

            if (person.Money <= price) return;
                
            person.SpendMoney(BasePrice * priceModifer);
            person.ChangeMood(MoodModifer);
            person.Eat(HungryModifer);
        }
    }
}