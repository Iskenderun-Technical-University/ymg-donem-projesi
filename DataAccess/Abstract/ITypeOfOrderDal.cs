﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.Concrete.Combobox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ITypeOfOrderDal : IEntityRepository<TypeOfOrder>
    {
        List<CbbTypeOfOrder> CbbTypeOfOrderGetAll(bool state);
    }
}
