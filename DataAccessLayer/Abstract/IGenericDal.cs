using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        //once burada tum dallardakı metotlar aynı oldugu ıcın generic yapı olusturmusun tmm
        
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
       List<T> GetList();
    }
}
