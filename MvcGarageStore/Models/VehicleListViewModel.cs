using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace MvcGarageStore.Models
{
    public class VehicleListViewModel
    {
        public Vehicle Vehicle { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}