using _20_DbFirstRepositoryDesignNorthwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_DbFirstRepositoryDesignNorthwind.Repositories
{
    public class GenericRepository<TEntity> where TEntity : class, new() //TEntity gelecek class için placeholder. where koşuluyla verilen class yollasın interface struct falan yollamasın diye. new de abstract yollamasın diye.
    {
        public NorthwindContext context;

        public GenericRepository()
        {
            context = new NorthwindContext();
        }
        public List<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        //GetById

        public TEntity GetById(int id)
        {
            try
            {
                return context.Set<TEntity>().Find(id);
            }
            catch (Exception)
            {
                throw new Exception("Aranılan kayıt bulunamadı");
            }
        }

        //Add
        public int Add(TEntity entity)
        {
            try
            {
                context.Set<TEntity>().Add(entity);
                return context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Ekleme işlemi başarısız oldu");
            }
        }

        //Update
        public int Update(TEntity entity)
        {
            try
            {
                context.Set<TEntity>().Update(entity);
                return context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Güncelleme işlemi başarısız oldu");
            }
        }

        //Delete
        public int Delete(TEntity entity)
        {
            try
            {
                context.Set<TEntity>().Remove(entity);
                return context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Silinemedi");
            }
        }
        //DeleteByID
        public int DeleteByID(int id)
        {
            try
            {
                TEntity entity = context.Set<TEntity>().Find(id);
                context.Set<TEntity>().Remove(entity);
                return context.SaveChanges();
            }
            catch
            {
                throw new Exception("Silemedik");
            }   
        }
    }
}
