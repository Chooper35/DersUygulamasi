using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersUygulaması
{
    public class TestDal
    {
        public void Add(TestClass test)
        {
            using (ClassProjectDBContext context = new ClassProjectDBContext())
            {
                context.testClasses.Add(test);
                context.SaveChanges();
            }
        }

        public List<TestClass> GetAll()
        {
            using (ClassProjectDBContext context = new ClassProjectDBContext())
            {
                return context.testClasses.ToList();
            }
        }
    }

}

    

