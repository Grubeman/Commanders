using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _TESTING_Commanders
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Commanders.Services.CommandersDatabase test = new Commanders.Services.CommandersDatabase();
            test.Connect();

            test.Close();

        }
    }
}
