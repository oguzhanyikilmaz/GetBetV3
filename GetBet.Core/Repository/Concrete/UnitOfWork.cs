using GetBet.Core.Context;
using GetBet.Core.Repository.Abstract;
using GetBet.Core.Settings;
using GetBet.DataAccess.Repository;
using GetBet.Entities.Concrete;
using Microsoft.Extensions.Options;

namespace GetBet.Core.Repository.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MongoDbContext _context;
        public IRepository<Play> Plays { get; private set; }

        public UnitOfWork(MongoSettings settings)
        {
            _context = new MongoDbContext(settings);

            Plays = new MongoRepositoryBase<Play>(_context);

        }

    }
}
