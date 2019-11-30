using System;
using Julia;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SaveTest()
        {
            //organizar 
            Company compañia = new Company("alicia", 110.15);
            double ve = 125.15;

            //actuar 
            compañia.Save(15);
            double vo = compañia.SaveProject;

            //comprobar 
            Assert.AreEqual(ve, vo);
        }

        [TestMethod]
        public void SpendTest()
        {
            //organizar 
            Company compañia = new Company("alicia", 140.15);
            double ve = 125.15;

            //actuar 
            compañia.Spend(15);
            double vo = compañia.SaveProject;

            //comprobar 
            Assert.AreEqual(ve, vo);
        }


        [TestMethod]
        public void ChangeNameTest()
        {  
            //organizar 
            Company compañia = new Company("julia", 110.15);
            string ve = "aliciaguzman";

            //actuar 
            compañia.ChangeName("aliciaguzman");
            string vo = compañia.Name;

            //comprobar 
            Assert.AreEqual(ve, vo);

        }
    }
}

