using SallyPieShop.Models;

namespace SallyPieShop.Data
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext _appDbContext;

        public FeedbackRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AddFeedback(Feedback feedback)
        {
            _appDbContext.Feedbacks.Add(feedback);
        }

        public void SaveChanges()
        {
            _appDbContext.SaveChanges();
        }
    }
}
