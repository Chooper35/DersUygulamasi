using DersUygulamasý;
using MetroFramework.Forms;
using NUnit.Framework;
using NUnit.Extensions.Forms;
using System;
namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
          
        }
        

        [Test]
        public void Test1()
        {           
            Assert.Pass();
        }
        [Test]
        public void FormTest()
        {
            GirisForm g = new GirisForm();
            
            Assert.Pass(); 
        }
        [Test]
        public void ButonTest()
        {
               
            //Buton týklama testi
            ButtonTester button = new ButtonTester("btnÖgrenci");
            button.Click();
            
        }
    }
}