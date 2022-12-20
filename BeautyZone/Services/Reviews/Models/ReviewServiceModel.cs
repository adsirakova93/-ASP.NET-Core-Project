using System;

namespace BeautyZone.Services.Reviews.Models
{
    public class ReviewServiceModel
    {
        public string PatientId { get; init; }

        public string PhysicianId { get; init; }

        public int Rating { get; init; }

        public string Comment { get; init; }

        public DateTime CreatedOn { get; init; }
    }
}
