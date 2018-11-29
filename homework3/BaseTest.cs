using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;    
using OpenQA.Selenium.Support.UI;

namespace homework3
{

  public class BaseTest
    {
      public  IWebDriver driver = null;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            TestContext.WriteLine("call OneTimeSetUp Method from BaseTest");

            string browser = TestContext.Parameters["browser"];
            if (browser == "chrome")
            {
                driver = new ChromeDriver();
            }
            else if (browser == "firefox")
            {

                driver = new FirefoxDriver();
            }
            else 
            {
                driver = new ChromeDriver();
            }


            driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            TestContext.WriteLine("call OneTimeTearDown Method from BaseTest");
            driver.Quit();
        }

        [SetUp]
        public void SetUp()
        {
            TestContext.WriteLine("call SetUp Method");
            driver.Navigate().GoToUrl("https://atata-framework.github.io/atata-sample-app/#!/");

            var headerSingInButton = driver.FindElement(By.LinkText("Sign In"));
            headerSingInButton.Click();

            var email = driver.FindElements(By.CssSelector("b")).First().Text;
            var password = driver.FindElements(By.CssSelector("b")).Last().Text;

            var inputEmail = driver.FindElement(By.Id("email"));
            inputEmail.SendKeys(email.ToString());

            var inputPassword = driver.FindElement(By.Id("password"));
            inputPassword.SendKeys(password.ToString());

            var signInButton = driver.FindElement(By.XPath("//input[@value = 'Sign In']"));
            signInButton.Click();

        }

        [TearDown]
        public void TearDown()
        {
            TestContext.WriteLine("call TearDown Method");
            var account = driver.FindElement(By.XPath("//a[@data-toggle='dropdown']"));
            account.Click();

            var signOutButton = driver.FindElement(By.XPath("//a[contains(text(),'Sign Out')]"));
            signOutButton.Click();
        }


    }
}
