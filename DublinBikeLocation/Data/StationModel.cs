using System;
namespace DublinBikeLocation.Data
{
    public class StationModel
    {
        public int number { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
    }
}
