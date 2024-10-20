using System;

namespace Factory
{
    public class PrivateResidentBuilding : Realty
    {
        public PrivateResidentBuilding(string NameOwner, DateTime DateCreated, int Cost)
        : base(NameOwner, DateCreated, Cost) { }

        public override void printInfo()
        {
            Console.WriteLine($"Owner: {NameOwner}, Date: {DateCreated:dd.MM.yyyy}, Cost: {Cost}");
        }
    }
}
