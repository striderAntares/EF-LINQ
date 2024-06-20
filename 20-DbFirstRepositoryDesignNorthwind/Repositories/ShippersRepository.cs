using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20_DbFirstRepositoryDesignNorthwind.Models;
namespace _20_DbFirstRepositoryDesignNorthwind.Repositories
{
    internal class ShippersRepository : GenericRepository<Shipper>
    {
        #region eski
        //NorthwindContext context;

        //public ShippersRepository()
        //{
        //    context = new NorthwindContext();
        //}

        ////Add to database

        //public int AddByObject(Shipper gusto)
        //{
        //    try
        //    {
        //        context.Shippers.Add(gusto);
        //        return context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}

        ////GetByID
        //public Shipper GetByID(int i)
        //{
        //    try
        //    {
        //        return context.Shippers.Find(i);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}

        ////UpdateDb
        //public int UpdateByObject(Shipper gusto)
        //{
        //    try
        //    {
        //        context.Shippers.Update(gusto);
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
        //        Shipper gusto = context.Shippers.Find(i);
        //        context.Shippers.Remove(gusto);
        //        return context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}
        ////DeleteByOnject
        //public int DeleteByObject(Shipper gusto)
        //{
        //    try
        //    {
        //        context.Shippers.Remove(gusto);
        //        return context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}
        ////UpdateByList
        //public int UpdateByList(List<Shipper> gustoes)
        //{
        //    try
        //    {
        //        foreach (Shipper custo in gustoes)
        //        {
        //            context.Shippers.Update(custo);
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
