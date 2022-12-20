using SuperDoc.Services.Reviews.Models;
using SuperDoc.Services.Reviews.Models.NewFolder;

namespace SuperDoc.Services.Reviews
{
    public interface IReviewService
    {
        void Create(
            string patientId,
            string physicianId,
            string appointmentId,
            int rating,
            string comment);

        AllReviewsQueryModel AllReviews(
            string physicianId,
            ReviewsSorting sorting,
            int currentPage,
            int reviewsPerPage);
    }
}
