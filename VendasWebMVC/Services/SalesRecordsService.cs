using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVC.Models;

namespace VendasWebMVC.Services
{
    public class SalesRecordsService
    {
        private readonly VendasWebMVCContext _context;

        public SalesRecordsService(VendasWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? dateMin, DateTime? dateMax)
        {
            var result = from obj in _context.SalesRecord select obj;

            if (dateMin.HasValue)
            {
                result = result.Where(x => x.Date >= dateMin.Value);
            }

            if (dateMax.HasValue)
            {
                result = result.Where(x => x.Date <= dateMax.Value);
            }

            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Departament)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Departament, SalesRecord>>> FindByDateGroupingAsync(DateTime? dateMin, DateTime? dateMax)
        {
            var result = from obj in _context.SalesRecord select obj;

            if (dateMin.HasValue)
            {
                result = result.Where(x => x.Date >= dateMin.Value);
            }

            if (dateMax.HasValue)
            {
                result = result.Where(x => x.Date <= dateMax.Value);
            }

            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Departament)
                .OrderByDescending(x => x.Date)
                .GroupBy(x => x.Seller.Departament)
                .ToListAsync();
        }
    }
}
