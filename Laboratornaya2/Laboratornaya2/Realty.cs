using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya2
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
