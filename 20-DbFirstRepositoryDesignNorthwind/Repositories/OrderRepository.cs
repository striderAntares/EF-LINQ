using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20_DbFirstRepositoryDesignNorthwind.Models;

namespace _20_DbFirstRepositoryDesignNorthwind.Repositories
{
    internal class OrderRepository : GenericRepository<Order>
    {
        #region eski
        NorthwindContext context;

        public OrderRepository()
        {
            context = new NorthwindContext();
        }

        //Add to database

        public int AddByObject(Order gusto)
        {
            try
            {
                context.Orders.Add(gusto);
                return context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Bazı başarısızlıklar söz konusu");
            }
        }

        //GetByID
        public Order GetByID(int i)
        {
            try
            {
                return context.Orders.Find(i);
            }
            catch (Exception ex)
            {
                throw new Exception("Bazı başarısızlıklar söz konusu");
            }
        }

        //UpdateDb
        public int UpdateByObject(Order gusto)
        {
            try
            {
                context.Orders.Update(gusto);
                return context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Bazı başarısızlıklar söz konusu");
            }
        }

        //DeleteDb
        public int DeleteById(int i)
        {
            try
            {
                Order gusto = context.Orders.Find(i);
                context.Orders.Remove(gusto);
                return context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Bazı başarısızlıklar söz konusu");
            }
        }
        //DeleteByOnject
        public int DeleteByObject(Order gusto)
        {
            try
            {
                context.Orders.Remove(gusto);
                return context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Bazı başarısızlıklar söz konusu");
            }
        }
        //UpdateByList
        public int UpdateByList(List<Order> gustoes)
        {
            try
            {
                foreach (Order custo in gustoes)
                {
                    context.Orders.Update(custo);
                }
                return context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Bazı başarısızlıklar söz konusu");
            }
        } 
        #endregion


    }
}
