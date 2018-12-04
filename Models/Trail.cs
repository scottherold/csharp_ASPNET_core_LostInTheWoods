using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LostInTheWoods.Models
{

    // Model to validate the trail. Will need to recast 
    public class Trail
    {
        public int trail_id{ get; set; }
        [Required(ErrorMessage = "Name is required!")]
        [Display(Name="Trail name")]
        [MinLength(5, ErrorMessage = "Trail Name must be at least 5 characters!")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Description is required!")]
        [Display(Name="Trail Description")]
        [MinLength(10, ErrorMessage = "Description must be at least 10 characters!")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Trail Length is required!")]
        [Display(Name="Trail Length")]
        [Range(0.1, double.MaxValue, ErrorMessage="Trail length must be positive decimal number!")]
        // [MaxLength(5, ErrorMessage = "Trail Length cannot exceed 5 characters!")]
        public double? Length { get; set; }
        
        [Required(ErrorMessage = "Elevation is required!")]
        [Display(Name="Trail Elevation")]
        public double? Elevation { get; set; }
        
        [Required(ErrorMessage = "Longitude is required!")]
        [Display(Name="Trail Longitude")]
        [Range(-180, 180, ErrorMessage="Longitude must be a number in decimal format between -180 and 180!")]
        public double? Longitude { get; set; }
        
        [Required(ErrorMessage = "Latitude is required!")]
        [Display(Name="Trail Latitude")]
        [Range(-90, 90, ErrorMessage="Latitude must be a number in decimal format between -90 and 90!")]
        public double? Latitude { get; set; }
    }
}