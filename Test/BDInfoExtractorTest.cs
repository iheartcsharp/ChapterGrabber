﻿using JarrettVance.ChapterTools.Extractors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JarrettVance.ChapterTools;
using System.Collections.Generic;

namespace Test
{
    /// <summary>
    ///This is a test class for Ifo2ExtractorTest and is intended
    ///to contain all Ifo2ExtractorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BDInfoExtractorTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        ///A test for GetStreams
        ///</summary>
        [TestMethod()]
        public void BDInfoTest()
        {
            BDInfoExtractor ex = new BDInfoExtractor();
            ex.GetStreams(@"F:\ISOs\HELLBOY2_D1\BDMV\PLAYLIST\00000.mpls");

        }
    }
}
