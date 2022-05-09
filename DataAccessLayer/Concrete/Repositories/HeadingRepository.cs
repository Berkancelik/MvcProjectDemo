using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public  class HeadingRepository:IHeadingDal
    {
        public void Delete(Heading p)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Heading, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Heading p)
        {
            throw new NotImplementedException();
        }

        public List<Heading> List()
        {
            throw new NotImplementedException();
        }

        public List<Category> List(Expression<Func<Heading, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Heading p)
        {
            throw new NotImplementedException();
        }

        Heading IRepository<Heading>.Get(Expression<Func<Heading, bool>> filter)
        {
            throw new NotImplementedException();
        }

        List<Heading> IRepository<Heading>.List(Expression<Func<Heading, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
