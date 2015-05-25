using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Users
{
    public interface IUserRepository
    {
        IEnumerable<AppUser> GetAll();
        //Article Add(Article item);
        //void Update(Article item);
        //void Delete(Article item);
        //Article Get(Guid id);
    }

    public class UserRepository : IUserRepository
    {
        private readonly WebDbContext _context;

        public UserRepository(IWebDbContext context)
        {
            this._context = context as WebDbContext;
        }

        
        public IEnumerable<AppUser> GetAll()
        {
            return _context.Users;
        }



        public void Update(AppUser item)
        {
            // Check there's not an object with same identifier already in context
            //if (_context.Users.Local.Select(x => x.Id == item.Id).Any())
            //{
            //    throw new ApplicationException("Object already exists in context");
            //}
            //_context.Entry(item).State = EntityState.Modified;
        }

    }
}
