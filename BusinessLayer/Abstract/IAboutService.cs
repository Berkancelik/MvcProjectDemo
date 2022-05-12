using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetList();
        void Add(About sbout);
        About GetById(int id);
        void Delete(About sbout);
        void Update(About sbout);
    }
}
