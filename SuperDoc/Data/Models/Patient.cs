﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static SuperDoc.Data.DataConstants.Patient;

namespace SuperDoc.Data.Models
{
    public class Patient
    {
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(NameMaxLength)]
        public string FullName { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string UserId { get; set; }

        public IEnumerable<Appointment> Appointments { get; init; } = new List<Appointment>();

        public IEnumerable<Review> Reviews { get; init; } = new List<Review>();
    }
}
