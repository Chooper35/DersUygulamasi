using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DersUygulaması;
using NUnit.Extensions.Forms;

namespace TestProjesi
{
    [TestClass]
    public class UnitTest1 
    {
        [TestMethod]
        public void GirisForm_AcilmaTesti()
        {
            GirisForm form = new GirisForm();
            form.Show();
        }
        [TestMethod]
        public void GirisForm_ÖgrenciButonTest()
        {
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
            ButtonTester button = new ButtonTester("btnÖgrenci");
            button.Click();
        }
        [TestMethod]
        public void GirisForm_ÖgretmenButonTest()
        {
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
            System.Threading.Thread.Sleep(2000);
            ButtonTester button = new ButtonTester("btnÖgretmen");
            button.Click();
        }
        //[TestMethod]
        //public void ÖgrenciLogin_Test()
        //{
        //    ÖgrenciGiris form = new ÖgrenciGiris();
        //    form.Show();

        //    ControlTester textBox = new ControlTester("txtAd");
        //    TextBoxTester
        //    KeyboardController key = new KeyboardController(textBox);
        //    key.UseOn(textBox);
        //    key.Click(Key.A);
        //    key.Click(Key.B);
        //    key.Press(Key.SHIFT);
        //    key.Click(Key.C);
        //    key.Release(Key.SHIFT);
        //    Assert.AreEqual("abC", textBox.Text);
        //}
        //[TestMethod]
        //public void Deneme()
        //{
        //    new DenemeForm().Show();
        //    System.Threading.Thread.Sleep(4000);
        //    TextBoxTester box = new TextBoxTester("textBox1");
        //    box.Click();
        //    box.Click();
        //    box.Click();
        //    System.Threading.Thread.Sleep(2000);
        //    KeyboardController key = new KeyboardController(box);
        //    System.Threading.Thread.Sleep(2000);
        //    key.UseOn(box);

        //    key.Click(Key.A);
        //    key.Click(Key.B);
        //    key.Press(Key.SHIFT);
        //    key.Click(Key.C);
        //    key.Release(Key.SHIFT);

        //    Assert.AreEqual("abC", box.Text);
        //}

    }
}

