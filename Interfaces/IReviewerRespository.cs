using PokemonReview.Models;

namespace PokemonReview.Interfaces
{
    public interface IReviewerRespository
    {
        ICollection<Reviewer> GetAllReviewer();

        Reviewer GetReviewerById(int reviewerId);

        ICollection<Review> GetReviewsByReviewer (int reviewerId);

        bool ReviewerExists(int reviewerId);

        bool CreateReviewer(Reviewer reviewer);

        bool UpdateReviewer(Reviewer reviewer);

        bool DeleteReviewer(Reviewer reviewer);

        bool Save();
    }
}
