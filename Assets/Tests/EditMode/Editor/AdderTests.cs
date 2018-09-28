using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class AdderTests {
    [Test]
    public void AdderTestsSimplePasses() {
        Assert.AreEqual(2, 1 + 1);
    }

    [Test]
    public void MyAdderTest()
    {
        Assert.AreEqual(MyAdder.AddTwoInt(1, 1), 2);
    }
}
