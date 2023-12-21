using System;
using EvaluationSampleCode;

namespace Evalutation_RomainGILOT_UnitTest;

[TestClass]
public class CustomStackTest
{

    private CustomStack _customstack;

    [TestInitialize]
    public void Init()
    {
        _customstack = new CustomStack();
    }

    [TestMethod]
    public void Count_WithEmptyStack_ReturnZero()
    {
        var result = _customstack.Count();

        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Count_AfterPushingValues_ReturnCorrectCount()
    {
        _customstack.Push(1);
        _customstack.Push(2);

        var result = _customstack.Count();

        Assert.AreEqual(2, result);
    }


}


