﻿using SignalR.EntiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IDiscountDal : IGenericDal<Discount>
    {
        List<Discount> GetListByStatusTrue();
        void ChangeStatusToTrue(int id);
        void ChangeStatusToFalse(int id);

    }
}
