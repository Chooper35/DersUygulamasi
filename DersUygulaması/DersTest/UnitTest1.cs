using NUnit.Framework;
using DersUygulaması;
using NUnit.Extensions;
namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DenemeForm form = new DenemeForm();
           
            

            Assert.Pass();
        }
    }
}