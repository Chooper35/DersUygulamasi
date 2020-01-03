using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersUygulaması
{
    public class ÖğrenciDal
    {
        public void Add(Öğrenci ögrenci)
        {
            using (ClassProjectDBContext context = new ClassProjectDBContext())
            {
                context.ÖgrenciTbl.Add(ögrenci);
                context.SaveChanges();
            }
        }
        public void Update(Öğrenci ögrenci)
        {
            using (ClassProjectDBContext context = new ClassProjectDBContext())
            {
                var entity = context.Entry(ögrenci);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        //public Öğrenci GetOneÖgrenci(int öğrenciId)
        //{
        //    using (ClassProjectDBContext context = new ClassProjectDBContext())
        //    {
        //        return context.ÖgrenciTbl.SingleOrDefault(x => x.ögrenciId == öğrenciId);
        //    }
        //}
        public List<Öğrenci> GetAll()
        {
            using (ClassProjectDBContext context = new ClassProjectDBContext())
            {
                return context.ÖgrenciTbl.ToList();
            }
        }
        public List<Öğrenci> ListOneÖgrenci(int ögrenciId)
        {
            using (ClassProjectDBContext context = new ClassProjectDBContext())
            {
                return context.ÖgrenciTbl.ToList().Where(p => p.ögrenciId == ögrenciId).ToList();
            }
        }
    }
}
