using System;

namespace L4_Console
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
            throw new NotImplementedException();
        }

        public bool Equals(Residents other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"| {StreetName,20} | {FlatOwner,20} | {AmountOfAdults,20} | {AmountOfKids,20} | {FlatArea,20} | ";
        }
    }
}
