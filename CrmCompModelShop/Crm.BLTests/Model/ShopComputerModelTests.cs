using Microsoft.VisualStudio.TestTools.UnitTesting;
using Crm.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BL.Model.Tests
{
    [TestClass()]
    public class ShopComputerModelTests
    {
        [TestMethod()]
        public void StartTest()
        {
            ShopComputerModel model = new ShopComputerModel();
            model.Start();
        }
    }
}