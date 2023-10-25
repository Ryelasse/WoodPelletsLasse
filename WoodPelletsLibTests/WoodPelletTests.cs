using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoodPelletsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodPelletsLib.Tests
{
    [TestClass()]
    public class WoodPelletTests
    {
        [TestMethod()]
        public void BrandTestOK()       //tester Brand længde der opfylder krav om minimumslængde
        {
            //Arrange
            WoodPellet woodpellet = new WoodPellet();

            //Act
            woodpellet.Brand = "OK";

            //Assert
            Assert.IsTrue(woodpellet.Brand.Length >= 2);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void BrandTestFail()         //tester Brand længde der ikke opfylder minimumskrav ved at tjekke vores exception
        {
            WoodPellet woodpellet = new WoodPellet();

            woodpellet.Brand = "W";

            Assert.IsTrue(woodpellet.Brand.Length >= 2);

        }


        [TestMethod()]
        public void QualityTestOK1()         //tester Quality på den nedre grænse
        {
            WoodPellet woodpellet = new WoodPellet();

            woodpellet.Quality = 1;

            Assert.IsTrue(woodpellet.Quality >= 1 &&  woodpellet.Quality <= 5);
        }

        [TestMethod()]
        public void QualityTestOK5()         //tester Quality på den øvre grænse
        {
            WoodPellet woodpellet = new WoodPellet();

            woodpellet.Quality = 5;

            Assert.IsTrue(woodpellet.Quality >= 1 && woodpellet.Quality <= 5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void QualityTestLow()        //tester Quality hvor værdien er under minimumskravet
        {
            WoodPellet woodpellet = new WoodPellet();

            woodpellet.Quality = 0;

            Assert.IsTrue(woodpellet.Quality >= 1 && woodpellet.Quality <= 5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void QualityTestHigh()       //tester Quality hvor værdien er over minimumskravet
        {
            WoodPellet woodpellet = new WoodPellet();

            woodpellet.Quality = 6;

            Assert.IsTrue(woodpellet.Quality >= 1 && woodpellet.Quality <= 5);
        }


        //Code Coverage viser at alle blokke i Brand og Quality er Covered

    }
}