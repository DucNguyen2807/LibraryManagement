using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class RepositoryBase<T> where T : class
    {
        LibraryManagementContext LibraryManagementContext;
        DbSet<T> DbSet;

        public RepositoryBase()
        {
            LibraryManagementContext = new LibraryManagementContext();
            DbSet = LibraryManagementContext.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public void Create(T entity)
        {
            DbSet.Add(entity);
            LibraryManagementContext.SaveChanges();
        }

        public void Update(T entity)
        {
            var tracker = LibraryManagementContext.Attach(entity);
            tracker.State = EntityState.Modified;
            LibraryManagementContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            DbSet?.Remove(entity);
            LibraryManagementContext.SaveChanges();
        }

    }

}