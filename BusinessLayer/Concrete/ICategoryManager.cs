using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ICategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAllBL()
        {
            return repo.List();
        }

        public void CategpryAddBL(Category p)
        {
            if(p.Name == "" || p.Name.Length <=3|| p.Description ==""|| p.Name.Length >= 51)
            {
                //error message
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
