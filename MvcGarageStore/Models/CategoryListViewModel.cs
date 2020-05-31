using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcGarageStore.Models
{
    public class CategoryListViewModel
    {
        public int Id { get; set; }
        public String Name { get; set; }

        [Display(Name = "Count Of Vehicles")]
        public int CountOfVehicles { get; set; }
    }
}