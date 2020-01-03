using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersUygulaması
{
    public class SoruDal
    {
        public List<Soru> GetAll()
        {
            using (ClassProjectDBContext context = new ClassProjectDBContext())
            {
                return context.SoruTbl.ToList();
            }
        }
        public void Add(Soru soru)
        {
            using (ClassProjectDBContext context = new ClassProjectDBContext())
            {
                context.SoruTbl.Add(soru);
                context.SaveChanges();
            }
        }
        public void Update(Soru soru)
        {
            using (ClassProjectDBContext context = new ClassProjectDBContext())
            {
                var entity = context.Entry(soru);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public List<Soru> ListByKonu(int konuId)
        {
            using (ClassProjectDBContext context = new ClassProjectDBContext())
            {
                return context.SoruTbl.ToList().Where(p => p.soruKonu==konuId).ToList();
            }
        }
        public void Delete(Soru soru)
        {
            using (ClassProjectDBContext context = new ClassProjectDBContext())
            {
                var entity = context.Entry(soru);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
