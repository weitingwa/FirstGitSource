using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employee_class;
using log4net.Config;
using log4net;


namespace FirstTest
{
    [TestClass]
    public class Taiwaneese_Test
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(Taiwaneese_Test).Name);

        [TestMethod]
        public void Employee_Cindy_Name()
        {
            log.Info("Employee的姓名是Cindy");
            Employee Cindy = new Taiwaneese("Cindy");

            Assert.AreEqual(Cindy.Name, "Cindy");
        }

        [TestMethod]
        public void Employee_Cindy_Age()
        {
            log.Debug("Cindy的年齡");
            Employee Cindy = new Taiwaneese("Cindy");
            Cindy.Age = 20;

            Assert.AreEqual(Cindy.Age, 20);
        }

        [TestMethod]
        public void Employee_Cindy_Cannot_Hire()
        {
            Employee Cindy = new Taiwaneese("Cindy");
            Cindy.Age = 19;

            Assert.AreEqual(Cindy.Hire(), false);
        }

        [TestMethod]
        public void Employee_Cindy_Hire()
        {
            Employee Cindy = new Taiwaneese("Cindy");
            Cindy.Age = 20;

            Assert.AreEqual(Cindy.Hire(), true);
        }

        [TestMethod]
        public void Employee_Amy_Cannot_Hire()
        {
            Employee Amy = new Taiwaneese("Amy");
            Amy.Age = 20;

            Assert.AreEqual(Amy.Hire(), false);
        }

        [TestMethod]
        public void Employee_Amy_Hire()
        {
            Employee Amy = new Taiwaneese("Amy");
            Amy.Age = 30;

            Assert.AreEqual(Amy.Hire(), true);
        }
    }
}
