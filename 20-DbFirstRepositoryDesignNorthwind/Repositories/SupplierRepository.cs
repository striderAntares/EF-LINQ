using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20_DbFirstRepositoryDesignNorthwind.Models;

namespace _20_DbFirstRepositoryDesignNorthwind.Repositories
{
    internal class SupplierRepository : GenericRepository<Supplier>
    {
        #region eski
        //NorthwindContext context;

        //public SupplierRepository()
        //{
        //    context = new NorthwindContext();
        //}

        ////Add to database

        //public int AddByObject(Supplier gusto)
        //{
        //    try
        //    {
        //        context.Suppliers.Add(gusto);
        //        return context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}

        ////GetByID
        //public Supplier GetByID(int i)
        //{
        //    try
        //    {
        //        return context.Suppliers.Find(i);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}

        ////UpdateDb
        //public int UpdateByObject(Supplier gusto)
        //{
        //    try
        //    {
        //        context.Suppliers.Update(gusto);
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
        //        Supplier gusto = context.Suppliers.Find(i);
        //        context.Suppliers.Remove(gusto);
        //        return context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}
        ////DeleteByOnject
        //public int DeleteByObject(Supplier gusto)
        //{
        //    try
        //    {
        //        context.Suppliers.Remove(gusto);
        //        return context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}
        ////UpdateByList
        //public int UpdateByList(List<Supplier> gustoes)
        //{
        //    try
        //    {
        //        foreach (Supplier custo in gustoes)
        //        {
        //            context.Suppliers.Update(custo);
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
