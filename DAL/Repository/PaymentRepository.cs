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
    public class PaymentRepository : IRepository<Payment>
    {
        private Model1 db;

        public PaymentRepository(Model1 context)
        {
            this.db = context;
        }


        public void Create(Payment item)
        {
            db.Payment.Add(item);
        }

        public void Delete(int id)
        {
            Payment item = db.Payment.Find(id);
            if (item != null)
                db.Payment.Remove(item);
        }

        public Payment GetItem(int id)
        {
            return db.Payment.Find(id);
        }

        public ObservableCollection<Payment> GetList()
        {
            return new ObservableCollection<Payment>(db.Payment.ToList());
        }

        public void Update(Payment item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
