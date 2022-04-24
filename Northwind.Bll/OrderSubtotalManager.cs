﻿using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class OrderSubtotalManager : GenericManager<OrderSubtotal, DtoOrderSubtotal>, IOrderSubtotalService
    {
        public OrderSubtotalManager(IServiceProvider service) : base(service)
        {
        }

        public IQueryable<DtoOrderSubtotal> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}