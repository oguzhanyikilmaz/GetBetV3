using GetBet.Core.Repository.Abstract;
using GetBet.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBet.Core.Repository.Abstract
{
    public interface IUnitOfWork
    {
        IRepository<Play> Plays { get; }
        IRepository<Stats> Stats { get; }
        IRepository<IY0StatsModel> IY0Stats { get; }
        IRepository<UserAgent> UserAgent { get; }

    }
}
