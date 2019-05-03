using System;

namespace L4_WebPage
{
    public class TerritoryCleaning: IComparable<TerritoryCleaning>, IEquatable<TerritoryCleaning>
    {
        public  int CleaningAmountOfAdults { get; set; }
        public  int CleaningAmountOfKids { get; set; }
        public  double PriceForSquare { get; set; }

        public int CompareTo(TerritoryCleaning other)
        {
            if (other == null)
            {
                return 1;
            }
            return Math.Abs(PriceForSquare - other.PriceForSquare) < 0 ? CleaningAmountOfAdults.CompareTo(other.CleaningAmountOfAdults) : PriceForSquare.CompareTo(other.PriceForSquare);
        }

        public bool Equals(TerritoryCleaning other)
        {
            return other != null && Math.Abs(PriceForSquare - other.PriceForSquare) < 0.0;
        }

        public override string ToString()
        {
            return $"| {CleaningAmountOfAdults,20} | {CleaningAmountOfKids,20} | {PriceForSquare,20} |";
        }
    }
}
