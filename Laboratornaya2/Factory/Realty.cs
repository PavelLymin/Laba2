using System;

namespace Factory
{
    public abstract class Realty
    {
        public string NameOwner { get; set; }
        public DateTime DateCreated { get; set; }
        public int Cost { get; set; }

        public Realty(string NameOwner, DateTime DateCreated, int Cost)
        {
            this.NameOwner = NameOwner;
            this.DateCreated = DateCreated;
            this.Cost = Cost;
        }
        public abstract void printInfo();
    }
}
