using Contouring_App.Application.Entities;
using Contouring_App.Application.Entities.Dtos;
using Contouring_App.Persistance.Context;
using Contouring_App.Persistance.Repositories.Interfaces;

namespace Contouring_App.Persistance.Repositories
{
    public class DivisionRepo : IDivisionRepo
    {
        private readonly AppDbContext _context;

        public DivisionRepo(AppDbContext context)
        {
             _context = context;
        }
        public List<Divlist> Get_Divisions(int division)
        {
            IQueryable<Divlist> manager = _context.Manager.Where(x => x.Division_id == division).Select(x => new Divlist { Divid = x.Division_id, Name = x.Name , role="Manager" });
            IQueryable<Divlist> trainee = _context.Trainee.Where(x => x.Division_id == division).Select(x => new Divlist { Divid = x.Division_id, Name = x.Name, role = "Trainee" });
            List<Divlist> a=manager.ToList();
            List<Divlist> b=trainee.ToList();

            IEnumerable<Divlist> result = a.Concat(b);

            return result.ToList();
        }
    }
}
