﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntitiyLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity_Framework
{
    public class EfNewsLatterDal:GenericRepository<Newslatter>, INewsLatterDal
    {
    }
}
