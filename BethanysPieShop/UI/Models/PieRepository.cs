using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext dbContext;

        public PieRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return dbContext.Pies;
        }
        public Pie GetPieById(int id)
        {
            return dbContext.Pies.FirstOrDefault(item => item.ID == id);
        }
    }
}
