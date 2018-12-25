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
    public class PizzaRepository : IRepository<Pizza>
    {
        private Model1 db;

        public PizzaRepository(Model1 context)
        {
            this.db = context;
        }


        public void Create(Pizza item)
        {
            db.Pizza.Add(item);
        }

        public void Delete(int id)
        {
            Pizza item = db.Pizza.Find(id);
            if (item != null)
                db.Pizza.Remove(item);
        }

        public Pizza GetItem(int id)
        {
            return db.Pizza.Find(id);
        }

        public ObservableCollection<Pizza> GetList()
        {
            return new ObservableCollection<Pizza>(db.Pizza.ToList());
        }

        public void Update(Pizza item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
