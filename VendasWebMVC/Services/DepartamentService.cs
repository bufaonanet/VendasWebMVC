using System.Collections.Generic;
using System.Linq;
using VendasWebMVC.Models;

namespace VendasWebMVC.Services
{
    public class DepartamentService
    {
        private readonly VendasWebMVCContext _context;

        public DepartamentService(VendasWebMVCContext context)
        {
            _context = context;
        }

        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(x => x.Name).ToList();
        }
    }
}
