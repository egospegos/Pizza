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
    public class OrderStringRepository : IRepository<OrderString>
    {
        private Model1 db;

        public OrderStringRepository(Model1 context)
        {
            this.db = context;
        }


        public void Create(OrderString item)
        {
            db.OrderString.Add(item);
        }

        public void Delete(int id)
        {
            OrderString item = db.OrderString.Find(id);
            if (item != null)
                db.OrderString.Remove(item);
        }

        public OrderString GetItem(int id)
        {
            return db.OrderString.Find(id);
        }

        public ObservableCollection<OrderString> GetList()
        {
            return new ObservableCollection<OrderString>(db.OrderString.ToList());
        }

        public void Update(OrderString item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
