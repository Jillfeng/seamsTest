using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ShapeTest
    {
        [TestMethod]
        public void GetJsonFileData_ReturnsShapeType_WhenReadsJsonFile_()
        {
            ShapeDto shapes = new ShapeDto();
            Assert.AreEqual("Triangle", shapes.Triangle.ShapeType);

        }
    }
}
