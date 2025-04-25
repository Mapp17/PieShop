using SallyPieShop.Models;

namespace SallyPieShop.Data
{
    public interface IFeedbackRepository
    {
        void AddFeedback(Feedback feedback);
        void SaveChanges();
    }
}
