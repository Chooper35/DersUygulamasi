using DersUygulamas�;
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
               
            //Buton t�klama testi
            ButtonTester button = new ButtonTester("btn�grenci");
            button.Click();
            
        }
    }
}