using FirstTestTask.Interface;
using FirstTestTask.Repository;

namespace FirstTestTask.Models
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRandomElementRepository randomElementRepository { get; set; }
        public RandomElementContext context { get; set; }

        public UnitOfWork()
        {
            context = new RandomElementContext();
            randomElementRepository = new RandomElementRepository(context);
        }

    }
}
