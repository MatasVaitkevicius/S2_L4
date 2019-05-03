using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace L4_Console
{
    class Program
    {
        private const string DirectoryOfResidents = "App_Data/Residents";
        private const string TerritoryCleaning = "App_Data/TerritoryCleaningData.txt";
        static void Main(string[] args)
        {
            var money = 1000;
            var residentsList = ReadResidentsData(DirectoryOfResidents);
            var territoryCleaningList = ReadTerritoryCleaningData(TerritoryCleaning);
            var filteredResidents = FilterResidentsByMoney(money, territoryCleaningList, residentsList);
            Console.WriteLine("hey");
            Console.ReadKey();
        }

        public static List<ResidentsList> ReadResidentsData(string directoryName)
        {
            var residentsList = new List<ResidentsList>();

            foreach (var thisFile in Directory.GetFiles(directoryName))
            {
                var temporaryList = new List<Residents>();
                string[] lines;
                try
                {
                    lines = File.ReadAllLines(thisFile);
                }
                catch (Exception e)
                {
                    continue;
                }
                var data = lines[0];

                for (var i = 1; i < lines.Length; i++)
                {
                    try
                    {
                        var values = lines[i].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        temporaryList.Add(new Residents
                        {
                            FlatOwner = values[0],
                            AmountOfAdults = int.Parse(values[1]),
                            AmountOfKids = int.Parse(values[2]),
                            FlatArea = double.Parse(values[3])
                        });
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Klaida");
                    }
                }

                var smallerList = new ResidentsList(data, temporaryList);
                residentsList.Add(smallerList);
            }

            return residentsList;
        }

        public static List<TerritoryCleaning> ReadTerritoryCleaningData(string fileName)
        {
            var territoryCleaningList = new List<TerritoryCleaning>();
            var lines = File.ReadAllLines(fileName);

            foreach (var territoryCleaning in lines)
            {
                try
                {
                    var values = territoryCleaning.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    territoryCleaningList.Add(new TerritoryCleaning
                    {
                        CleaningAmountOfAdults = int.Parse(values[0]),
                        CleaningAmountOfKids = int.Parse(values[1]),
                        PriceForSquare = double.Parse(values[2])
                    });
                }
                catch (Exception e)
                {
                    Console.WriteLine("Klaida");
                }
            }

            return territoryCleaningList;
        }

        static bool CheckForAdultsAndKids(Residents resident, TerritoryCleaning territoryCleaning)
        {
            return resident.AmountOfAdults == territoryCleaning.CleaningAmountOfAdults &&
                   resident.AmountOfKids == territoryCleaning.CleaningAmountOfKids;
        }

        static double CalculateMoneySpent(Residents resident, TerritoryCleaning territoryCleaning)
        {
            return resident.FlatArea * territoryCleaning.PriceForSquare;
        }

        static List<ResidentsList> FilterResidentsByMoney(double chosenMoneyFloor,
            List<TerritoryCleaning> territoryCleaningList, List<ResidentsList> residentsLists)
        {
            return (from street in residentsLists
                    let temporaryList = street.ListOfResidents
                    .Where(resident => territoryCleaningList
                    .Where(territoryCleaning => CheckForAdultsAndKids(resident, territoryCleaning))                           
                    .Any(territoryCleaning => chosenMoneyFloor < CalculateMoneySpent(resident, territoryCleaning)))
                    .ToList()
                    select new ResidentsList(street.ListStreetName, temporaryList)).ToList();
        }
    }
}
