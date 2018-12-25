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
    public class DeliverymanRepository : IRepository<Deliveryman>
    {
        private Model1 db;

        public DeliverymanRepository(Model1 context)
        {
            this.db = context;
        }


        public void Create(Deliveryman item)
        {
            db.Deliveryman.Add(item);
        }

        public void Delete(int id)
        {
            Deliveryman item = db.Deliveryman.Find(id);
            if (item != null)
                db.Deliveryman.Remove(item);
        }

        public Deliveryman GetItem(int id)
        {
            return db.Deliveryman.Find(id);
        }

        public ObservableCollection<Deliveryman> GetList()
        {
            return new ObservableCollection<Deliveryman>(db.Deliveryman.ToList());
        }

        public void Update(Deliveryman item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
