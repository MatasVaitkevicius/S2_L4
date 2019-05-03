using System;

namespace L4_WebPage
{
    public class Residents : IComparable<Residents>, IEquatable<Residents>
    {
        public string StreetName { get; set; }
        public string FlatOwner { get; set; }
        public  int AmountOfAdults { get; set; }
        public  int AmountOfKids { get; set; }
        public  double FlatArea { get; set; }

        public int CompareTo(Residents other)
        {
            if (other == null)
            {
                return 1;
            }
            return FlatOwner == other.FlatOwner ? FlatArea.CompareTo(other.FlatArea) : String.Compare(FlatOwner, other.FlatOwner, StringComparison.Ordinal);
        }

        public bool Equals(Residents other)
        {
            return other != null && FlatOwner == other.FlatOwner;
        }

        public override string ToString()
        {
            return $"| {FlatOwner,20} | {AmountOfAdults,20} | {AmountOfKids,20} | {FlatArea,20} | ";
        }
        public string Results()
        {
            return $"| {FlatOwner,20} | {AmountOfAdults + AmountOfKids,20} |";
        }
    }
}
