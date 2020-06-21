//using StockEntity.DataEntity;
//using StockEntity.Entity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StockEntity.EntitySQLite
//{
//    public class UnitOfWork : IUnitOfWork
//    {

//        private StockDBContext _dbContext;
//        private BaseRepository<ProductMaster> _productMasters;
//        private BaseRepository<Dealer> _dealers;

//        public UnitOfWork()
//        {
//            _dbContext = new StockDBContext();
//        }

//        public IBaseRepository<ProductMaster> ProductMasters
//        {            
//            get { return _productMasters ?? (_productMasters = new BaseRepository<ProductMaster>(_dbContext)); }
//        }

//        public IBaseRepository<Dealer> Dealers
//        {
//            get
//            { return _dealers ?? (_dealers = new BaseRepository<Dealer>(_dbContext)); }
//        }

//        public void Commit()
//        {            
//            _dbContext.SaveChanges();
//        }
//    }
//}
