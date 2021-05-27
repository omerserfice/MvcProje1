using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IHeadingService
    {
        List<Heading> GetList();
        void HeadingAdd(Heading category);
        Heading GetByID(int id);

        void HeadingDelete(Heading category);
        void HeadingUpdate(Heading category);
    }
}
