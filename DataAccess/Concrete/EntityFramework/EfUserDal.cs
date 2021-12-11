using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, DbReCapProjectContext>, IUserDal
    {
        public List<UserDetailDto> GetUserDetails()
        {
            using (DbReCapProjectContext context = new DbReCapProjectContext())
            {
                var result = from user in context.Users
                             join customer in context.Customers
                             on user.UserId equals customer.UserId
                             select new UserDetailDto { CompanyName = customer.CompanyName, Email = user.Email, FirstName = user.FirstName, LastName = user.LastName, Password = user.Password, UserId = user.UserId };

                return result.ToList();
            }
        }
    }
}
