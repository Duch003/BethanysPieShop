using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Models
{
    public class FeedbackRepository : IFeedbackRepositroy
    {
        private readonly AppDbContext context;

        public FeedbackRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void AddFeedback(Feedback feedback)
        {
            context.Feedbacks.Add(feedback);
            context.SaveChanges();
        }
    }
}
