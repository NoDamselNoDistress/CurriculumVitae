﻿using System.ComponentModel.DataAnnotations;

namespace CurriculumVitae.Data
{
    public class Address
    {
        public int Id { get; set; }
        [Required]
        
        public int Housenumber { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        
        public int Postcode { get; set; }

    }
}
