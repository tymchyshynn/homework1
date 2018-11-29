using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace homework3
{
    [TestFixture]
    class TestFixture: BaseTest
    {
       
        [Test] 
        public void Test1()
        {
          int digit =  TestContext.CurrentContext.Random.Next(4,10);
            Assert.IsNotNull(digit);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(2, 2);
        }
         
        [Test]
        public void Test3()
        {
            Assert.AreEqual(2, 2);
        }


    }
}
