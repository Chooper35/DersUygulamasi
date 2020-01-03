using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersUygulaması
{
    public class KonuDal
    {
        public List<Konu> GetAll()
        {
            using (ClassProjectDBContext context = new ClassProjectDBContext())
            {
                return context.KonuTbl.ToList();
            }
        }
        public void Add(Konu konu)
        {
            using (ClassProjectDBContext context = new ClassProjectDBContext())
            {
                context.KonuTbl.Add(konu);
                context.SaveChanges();
            }
        }
        public void Update(Konu konu)
        {
            using (ClassProjectDBContext context = new ClassProjectDBContext())
            {
                var entity = context.Entry(konu);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
