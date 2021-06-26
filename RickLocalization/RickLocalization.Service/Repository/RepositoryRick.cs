using RickLocalization.Domain.Entities;
using RickLocalization.Repository.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RickLocalization.Service.Repository
{
    public class RepositoryRick : IRickRepository
    {

        RickLocalizationContext _context;
        public RepositoryRick(RickLocalizationContext context)
        {
            _context = context;
        }


        public async Task<int> Add(Rick rick)
        {
            _context.Ricks.Add(rick);

           return await _context.SaveChangesAsync();
        }
    }
}
