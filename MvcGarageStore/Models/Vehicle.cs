using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace MvcGarageStore.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        
        [Required]
        public string Model { get; set; }
        
        [Required]
        public string Type { get; set; }
        public decimal Price { get; set; }
        
        [Required]
        [Display(Name = "Engine Type")]
        public string EngineType { get; set; }

        [Display(Name = "Engine Capacity")]
        public int EngineCapacity { get; set; }
        public bool Automatic { get; set; }

        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; }

        [Required]
        public int Kilometer { get; set; }

        [Required]
        public int Doors { get; set; }

        [Required]
        public virtual Color Color { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Release")]
        public DateTime DateRelease { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

    }
}