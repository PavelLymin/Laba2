using System;

namespace Factory
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
