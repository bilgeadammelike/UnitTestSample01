using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestApp.UI;
using UnitTestApp.UI.Model;
using System.Collections.Generic;

namespace UnitTestApp.TestApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ShipperDal dal = new ShipperDal();
            List<Shippers> list = dal.Select();
        }

        [TestMethod]
        public void TestMethod2()
        {
            ShipperDal dal = new ShipperDal();
            int deger = dal.Insert(new Shippers()
            {
                CompanyName = "GeneralElectric",
                Phone = "12345"
            });
        }
    }
}
