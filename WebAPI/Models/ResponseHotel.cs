using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Entity;

namespace WebAPI.Models
{
    public class ResponseHotel
    {
        public ResponseHotel(Hotel hotel)
        {
            ID = hotel.Id;
            Name = hotel.Name;
            CountOfStars = (int)hotel.CountOfStars;
            CountryCode = hotel.CountryCode ;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int CountOfStars { get; set; }
        public string CountryCode { get; set; }
    }
}