using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya2
{
    public class CountryHouse : Realty
    {
        public double LandPlotArea { get; set; }

        public CountryHouse(string NameOwner, DateTime DateCreated, int Cost, double LandPlotArea)
            : base(NameOwner, DateCreated, Cost)
        {
            this.LandPlotArea = LandPlotArea;
        }

        public override void printInfo()
        {
            Console.WriteLine($"Owner: {NameOwner}, Date: {DateCreated:dd.MM.yyyy}, Cost: {Cost}, Plot area: {LandPlotArea}");
        }
    }
}
