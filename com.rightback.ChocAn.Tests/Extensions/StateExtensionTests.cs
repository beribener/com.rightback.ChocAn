﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.rightback.ChocAn.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.rightback.ChocAn.DAL.Enums.Tests
{
    [TestClass()]
    public class StateExtensionTests
    {
        [TestMethod()]
        public void GetStateFullNameTest()
        {
            string alaska = StateExtension.GetStateFullName(State.AK);
            Assert.AreEqual("ALASKA",alaska);
        }

        [TestMethod()]
        public void GetStateByNameTest()
        {
            State alaska = StateExtension.GetStateByName("ALASKA");
            Assert.AreEqual(alaska,State.AK);
        }


    }
}