using System.Collections.Generic;

namespace L4_WebPage
{
    public class ResidentsList
    {
        public  string ListStreetName { get; set; }
        public  List<Residents> ListOfResidents { get; set; }

        public ResidentsList()
        {
            ListStreetName = "";
            ListOfResidents = new List<Residents>();
        }

        public ResidentsList(string listStreetName, List<Residents> newList)
        {
            ListStreetName = listStreetName;
            ListOfResidents = newList;
        }
    }
}
