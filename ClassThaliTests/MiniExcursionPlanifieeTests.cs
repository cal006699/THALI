using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassThali;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassThali.Tests
{
    [TestClass()]
    public class MiniExcursionPlanifieeTests
    {
        [TestMethod()]
        public void GetCodeTest()
        {
            MiniExcursion mini = new MiniExcursion(1, "Visite de l'ile au large de THALI", 20);
            MiniExcursionPlanifiee test = new MiniExcursionPlanifiee("1", mini, new DateTime(2026, 10, 9, 10, 20, 0) );
            Assert.AreEqual("1", test.GetCode());
        }

        [TestMethod()]
        public void SetNombreInscritsTest()
        {
            MiniExcursion mini = new MiniExcursion(1, "Visite de l'ile au large de THALI", 50);
            MiniExcursionPlanifiee test = new MiniExcursionPlanifiee("1", mini, new DateTime(2026, 10, 9, 10, 20, 0));
            test.SetNombreInscrits(50);
            Assert.AreEqual(50, test.GetNombreInscrits());
        }

        [TestMethod()]
        public void EstCompleteTest()
        {
            MiniExcursion mini = new MiniExcursion(1, "Visite de l'ile au large de THALI", 20);
            MiniExcursionPlanifiee test = new MiniExcursionPlanifiee("1", mini, new DateTime(2026, 10, 9, 10, 20, 0));
            test.SetNombreInscrits(20);
            Assert.AreEqual(true, test.EstComplete());
        }

        [TestMethod()]
        public void HeureRetourPrevueTest()
        {
            MiniExcursion mini = new MiniExcursion(1, "Visite de l'ile au large de THALI", 20);
            mini.AjouteEtape("a", 30);
            MiniExcursionPlanifiee test = new MiniExcursionPlanifiee("1", mini, new DateTime(2026, 10, 9, 10, 20, 0));
            Assert.AreEqual(new DateTime(2026, 10, 9, 10, 50, 0), test.HeureRetourPrevue());
        }
    }
}