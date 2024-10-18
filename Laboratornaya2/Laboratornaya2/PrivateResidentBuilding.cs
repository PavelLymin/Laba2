using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya2
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
