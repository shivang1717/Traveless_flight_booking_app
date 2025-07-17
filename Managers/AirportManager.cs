using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Traveless.Models;

namespace Traveless.Managers
{
    public static class AirportManager
    {
        public static List<Airport> LoadAirports(string path)
        {
            var airports = new List<Airport>();
            foreach (var line in File.ReadAllLines(path))
            {
                var parts = line.Split(',');
                if (parts.Length >= 2)
                    airports.Add(new Airport(parts[0], parts[1]));
            }
            return airports;
        }
    }
}
