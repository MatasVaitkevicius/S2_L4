using System;

namespace L4_Console
{
    public class TerritoryCleaning: IComparable<TerritoryCleaning>, IEquatable<TerritoryCleaning>
    {
        public  int CleaningAmountOfAdults { get; set; }
        public  int CleaningAmountOfKids { get; set; }
        public  double PriceForSquare { get; set; }

        public int CompareTo(TerritoryCleaning other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(TerritoryCleaning other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"| {CleaningAmountOfAdults,20} | {CleaningAmountOfKids,20} | {PriceForSquare,20} |";
        }
    }
}
