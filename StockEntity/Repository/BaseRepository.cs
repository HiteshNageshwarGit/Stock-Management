﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StockEntity.DataEntity
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        internal StockDBContext context;
        internal DbSet<TEntity> dbSet;

        public BaseRepository()
        {
            this.context = StockDBContext.GetStockDBContext(); 
            this.dbSet = context.Set<TEntity>();
        }

        public virtual void Add(TEntity entity)
        {
            dbSet.Add(entity);
            this.context.SaveChanges();
        }
        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
            this.context.SaveChanges();
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
            this.context.SaveChanges();
        }

        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        //public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        //{
        //    IQueryable<TEntity> query = dbSet;

        //    if (filter != null)
        //    {
        //        query = query.Where(filter);
        //    }

        //    if (includeProperties != null)
        //    {
        //        foreach (var includeProperty in includeProperties.Split
        //        (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        //        {
        //            query = query.Include(includeProperty);
        //        }
        //    }

        //    if (orderBy != null)
        //    {
        //        return orderBy(query).ToList();
        //    }
        //    else
        //    {
        //        return query.ToList();
        //    }
        //}

        //public virtual IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters)
        //{
        //    return dbSet.SqlQuery(query, parameters).ToList();
        //}

    }
}