﻿using System.ComponentModel.DataAnnotations;

namespace SuperDoc.Models.Appointments
{
    public class AppointmentFormModel
    {
        public string PhysicianId { get; init; }

        public string PatientId { get; init; }

        [Required]
        public string Date { get; init; }

        [Required]
        public string Hour { get; init; }

        public bool IsApproved { get; init; }
    }
}
