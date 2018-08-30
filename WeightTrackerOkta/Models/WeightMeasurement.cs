﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WeightTrackerOkta.Models
{
    public class WeightMeasurement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public float Value { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime MeasuredAt { get; set; }
    }
}