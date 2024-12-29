﻿using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderdal;
        public OrderManager(IOrderDal orderdal)
        {
            _orderdal = orderdal;
        }

        public void TDelete(Order entity)
        {
            _orderdal.Delete(entity);
        }

        public List<Order> TGetAll()
        {
            return _orderdal.GetAll();
        }

        public Order TGetById(int id)
        {
            return _orderdal.GetById(id);
        }

        public void TInsert(Order entity)
        {
            _orderdal.Insert(entity);
        }

        public void TUpdate(Order entity)
        {
            _orderdal.Update(entity);
        }
    }
}
