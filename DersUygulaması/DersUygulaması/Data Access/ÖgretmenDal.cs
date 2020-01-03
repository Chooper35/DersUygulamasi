using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersUygulaması
{
    public class ÖgretmenDal
    {
        public void Add(Öğretmen ögretmen)
        {
            using (ClassProjectDBContext context = new ClassProjectDBContext())
            {
                context.ÖğretmenTbl.Add(ögretmen);
                context.SaveChanges();
            }
        }
        public void Update(Öğretmen ögretmen)
        {
            using (ClassProjectDBContext context = new ClassProjectDBContext())
            {
                var entity = context.Entry(ögretmen);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public List<Öğretmen> ListOneTeacher(int ögretmenId)
        {
            using (ClassProjectDBContext context = new ClassProjectDBContext())
            {
                return context.ÖğretmenTbl.ToList().Where(p => p.ögretmenId == ögretmenId).ToList();
            }
        }

    }
}
