using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheLocal.Models
{
    public class LocationsModel
    {
        [Key]
        public int ID { get; set; }
        public string UserID { get; set; }
        public string LocationName { get; set; }
        public string LocationDescription { get; set; }
        public string LocationType { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
