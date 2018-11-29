using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NUnit.Framework;


namespace homework3
{
    [SetUpFixture]
    class SetUpFixture
    {
       private  string folderName = @"C:\CreatedFolder";

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {         
            TestContext.WriteLine("call OneTimeSetUp Method");
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
           
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            TestContext.WriteLine("call OneTimeTearDown Method");
            //string folder = @"C:\\CreatedFolder";
           // string destinationPath = @"C:\\TestResult";
           

        }
        


        }
}
