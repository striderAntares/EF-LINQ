using _20_DbFirstRepositoryDesignNorthwind.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_DbFirstRepositoryDesignNorthwind.Repositories
{
    internal class CustomerRepository : GenericRepository<Customer>
    {
        #region eski
        //NorthwindContext context;

        //public CustomerRepository()
        //{
        //    context = new NorthwindContext();
        //}

        ////Add to database

        //public int AddByObject(Customer gusto)
        //{
        //    try
        //    {
        //        context.Customers.Add(gusto);
        //        return context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}

        ////GetByID
        //public Customer GetByID(int i)
        //{
        //    try
        //    {
        //        return context.Customers.Find(i);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}

        ////UpdateDb
        //public int UpdateByObject(Customer gusto)
        //{
        //    try
        //    {
        //        context.Customers.Update(gusto);
        //        return context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}

        ////DeleteDb
        //public int DeleteById(int i)
        //{
        //    try
        //    {
        //        Customer gusto = context.Customers.Find(i);
        //        context.Customers.Remove(gusto);
        //        return context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}
        ////DeleteByOnject
        //public int DeleteByObject(Customer gusto)
        //{
        //    try
        //    {
        //        context.Customers.Remove(gusto);
        //        return context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}
        ////UpdateByList
        //public int UpdateByList(List<Customer> gustoes)
        //{
        //    try
        //    {
        //        foreach (Customer custo in gustoes)
        //        {
        //            context.Customers.Update(custo);
        //        }
        //        return context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //} 
        #endregion
    }
}
