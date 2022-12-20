using System.ComponentModel.DataAnnotations;
using static BeautyZone.Data.DataConstants.Review;

namespace BeautyZone.Models.Reviews
{
    public class ReviewFormModel
    {
        [Required]
        public string PatientId { get; init; }

        [Required]
        public string PhysicianId { get; init; }

        [Required]
        public string AppointmentId { get; init; }

        [Range(RatingMinValue, RatingMaxValue)]
        public int Rating { get; init; }

        [StringLength(CommentMaxLength)]
        public string Comment { get; init; }
    }
}
