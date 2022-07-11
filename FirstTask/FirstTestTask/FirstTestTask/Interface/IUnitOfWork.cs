using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstTestTask.Interface
{
    public interface IUnitOfWork
    {
        IRandomElementRepository randomElementRepository { get; set; }
    }
}
