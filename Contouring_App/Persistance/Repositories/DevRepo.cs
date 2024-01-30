﻿using Contouring_App.Application.Entities;
using Contouring_App.Persistance.Context;
using Contouring_App.Persistance.Repositories.Interfaces;

namespace Contouring_App.Persistance.Repositories
{
    public class DevRepo : IDevRepo
    {
        private readonly AppDbContext _appDbContext;

        public DevRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public List<Dev> GetStackList(string techstack)
        {
            List<Dev> result = new List<Dev>();
             IQueryable<Dev> techstck = _appDbContext.Devs.Where(d => d.Techstack == techstack);
            result= techstck.ToList();
            return result;
        }
    }
}
