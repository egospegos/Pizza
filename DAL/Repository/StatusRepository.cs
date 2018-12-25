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
    public class StatusRepository : IRepository<Status>
    {
        private Model1 db;

        public StatusRepository(Model1 context)
        {
            this.db = context;
        }


        public void Create(Status item)
        {
            db.Status.Add(item);
        }

        public void Delete(int id)
        {
            Status item = db.Status.Find(id);
            if (item != null)
                db.Status.Remove(item);
        }

        public Status GetItem(int id)
        {
            return db.Status.Find(id);
        }

        public ObservableCollection<Status> GetList()
        {
            return new ObservableCollection<Status>(db.Status.ToList());
        }

        public void Update(Status item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
