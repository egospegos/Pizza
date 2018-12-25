using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL.Repository
{
    public class OrderRepository : IRepository<Order>
    {
        private Model1 db;

        public OrderRepository(Model1 context)
        {
            this.db = context;
        }


        public void Create(Order item)
        {
            db.Order.Add(item);
        }

        public void Delete(int id)
        {
            Order item = db.Order.Find(id);
            if (item != null)
                db.Order.Remove(item);
        }

        public Order GetItem(int id)
        {
            return db.Order.Find(id);
        }

        public ObservableCollection<Order> GetList()
        {
            return new ObservableCollection<Order>(db.Order.ToList());
        }

        public void Update(Order item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
