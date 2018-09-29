using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class MyAdderTests
{
    [Test]
    public void MyAdderTestSimple()
    {
        Assert.AreEqual(MyAdder.Add(1, 2), 3);
    }
}
