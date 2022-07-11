using FirstTestTask.Interface;
using FirstTestTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstTestTask.Repository
{
    public class RandomElementRepository : IRandomElementRepository
    {
        RandomElementContext db;
        public RandomElementRepository(RandomElementContext context)
        {
            db = context;
        }
        public IQueryable<RandomElements> FindaAll()
        {
            return db.RandomElements;
        }
    }
}
