using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20_DbFirstRepositoryDesignNorthwind.Models;

namespace _20_DbFirstRepositoryDesignNorthwind.Repositories
{
    public class CategoryRepository : GenericRepository<Category>
    {

        #region EskiBlok
        //NorthwindContext context;

        //public CategoryRepository()
        //{
        //    context = new NorthwindContext();
        //}

        ////Add to database

        //public int AddByObject(Category gusto)
        //{
        //    try
        //    {
        //        context.Categories.Add(gusto);
        //        return context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}
        //public List<Category> GetCatToList()
        //{
        //    try
        //    { 
        //    return context.Categories.ToList();
        //    }
        //    catch (Exception ex) 
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}


        ////GetByID
        //public Category GetByID(int i)
        //{
        //    try
        //    {
        //        return context.Categories.Find(i);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}

        ////UpdateDb
        //public int UpdateByObject(Category gusto)
        //{
        //    try
        //    {
        //        context.Categories.Update(gusto);
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
        //        Category gusto = context.Categories.Find(i);
        //        context.Categories.Remove(gusto);
        //        return context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}
        ////DeleteByOnject
        //public int DeleteByObject(Category gusto)
        //{
        //    try
        //    {
        //        context.Categories.Remove(gusto);
        //        return context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}
        ////UpdateByList
        //public int UpdateByList(List<Category> gustoes)
        //{
        //    try
        //    {
        //        foreach (Category custo in gustoes)
        //        {
        //            context.Categories.Update(custo);
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
