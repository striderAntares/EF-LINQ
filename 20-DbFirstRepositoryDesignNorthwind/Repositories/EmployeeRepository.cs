using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20_DbFirstRepositoryDesignNorthwind.Models;

namespace _20_DbFirstRepositoryDesignNorthwind.Repositories
{
    internal class EmployeeRepository : GenericRepository<Employee>
    {
        #region eski
        //NorthwindContext context;

        //public EmployeeRepository()
        //{
        //    context = new NorthwindContext();
        //}

        ////Add to database

        //public int AddByObject(Employee gusto)
        //{
        //    try
        //    {
        //        context.Employees.Add(gusto);
        //        return context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}

        ////GetByID
        //public Employee GetByID(int i)
        //{
        //    try
        //    {
        //        return context.Employees.Find(i);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}

        ////UpdateDb
        //public int UpdateByObject(Employee gusto)
        //{
        //    try
        //    {
        //        context.Employees.Update(gusto);
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
        //        Employee gusto = context.Employees.Find(i);
        //        context.Employees.Remove(gusto);
        //        return context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}
        ////DeleteByOnject
        //public int DeleteByObject(Employee gusto)
        //{
        //    try
        //    {
        //        context.Employees.Remove(gusto);
        //        return context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Bazı başarısızlıklar söz konusu");
        //    }
        //}
        ////UpdateByList
        //public int UpdateByList(List<Employee> gustoes)
        //{
        //    try
        //    {
        //        foreach (Employee custo in gustoes)
        //        {
        //            context.Employees.Update(custo);
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
