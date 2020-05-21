using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DublinBikeLocation.Models;
namespace DublinBikeLocation.Service
{
    public interface IStation
    {
        Task<List<StationModel>> GetStations();
    }
}
