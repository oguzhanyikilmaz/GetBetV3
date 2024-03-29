﻿using GetBet.Core.Context;
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
        public IRepository<Stats> Stats { get; private set; }
        public IRepository<IY0StatsModel> IY0Stats { get; private set; }

        public IRepository<UserAgent> UserAgent { get; private set; }

        public UnitOfWork(MongoSettings settings)
        {
            _context = new MongoDbContext(settings);

            Plays = new MongoRepositoryBase<Play>(_context);
            Stats = new MongoRepositoryBase<Stats>(_context);
            IY0Stats = new MongoRepositoryBase<IY0StatsModel>(_context);
            UserAgent = new MongoRepositoryBase<UserAgent>(_context);

        }

    }
}
