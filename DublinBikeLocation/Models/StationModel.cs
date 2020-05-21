using System;
namespace DublinBikeLocation.Models
{
    public class StationModel
    {
        public int id { get; set; }
        public string imageUrl { get; set; }
        public string StationName { get; set; }
        public string Address { get; set; }
        public double lng { get; set; }
        public double lat { get; set; }
        public double distance { get; set; }
    }
}
