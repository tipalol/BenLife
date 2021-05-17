using System;
using BenLife.Core.Places;

namespace BenLife.Core
{
    public class Person
    {
        public readonly string Name;
        public float Health { get; private set; }
        public float Hungry { get; private set; }
        public float Tired { get; private set; }
        public float Money { get; private set; }
        public float Mood { get; private set; }

        public bool IsAlive => Health > 0.01f;

        private const float HungryModifer = 1.1f;
        private const float TiredModifer = 1.1f;
        
        public Person(string name, float health, float hungry, float tired, float money, float mood)
        {
            Name = name;
            Health = health;
            Hungry = hungry;
            Tired = tired;
            Money = money;
            Mood = mood;
        }

        public void Hurt(float damage)
        {
            if (damage < 0)
                throw new ArgumentException("Damage can not be negative");

            Health -= damage;

            if (Health < 0f)
                Health = 0f;
        }

        public void Eat(float amountOfFood)
        {
            if (amountOfFood < 0)
                throw new ArgumentException("Amount can not be negative");

            Hungry -= amountOfFood;

            if (Hungry < 0f)
                Hungry = 0f;
        }

        public void Relax(float relaxQuality)
        {
            if (relaxQuality < 0)
                throw new ArgumentException("Relax quality can not be negative");
            
            Tired *= relaxQuality;

            if (Tired < 0f)
                Tired = 0f;

            if (Tired > 1f)
                Tired = 1f;
        }

        public void BecomeHungry()
        {
            Hungry = Hungry * HungryModifer + 0.01f;

            if (Hungry > 1f)
                Hungry = 1f;
        }

        public void BecomeTired()
        {
            Tired = Tired * TiredModifer + 0.01f;

            if (Tired > 1f)
                Tired = 1f;
        }

        public void ChangeMood(float moodModifer)
        {
            if (moodModifer < 0)
                throw new ArgumentException("Mood modifer can not be negative");

            Mood *= moodModifer;

            if (Mood > 100f)
                Mood = 100f;
        }

        public void EarnMoney(float amountOfMoney)
        {
            if (amountOfMoney < 0f)
                throw new ArgumentException("Amount of money can not be negative");

            Money += amountOfMoney;
        }

        public void SpendMoney(float amountOfMoney)
        {
            if (amountOfMoney < 0f)
                throw new ArgumentException("Amount of money can not be negative");

            Money -= amountOfMoney;
        }
        
        public void Go(IPlace to) => to.Go(this);
    }
}