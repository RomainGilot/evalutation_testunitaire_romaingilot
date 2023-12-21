using System;
using EvaluationSampleCode;

namespace Evalutation_RomainGILOT_UnitTest;
[TestClass]
public class MathOperationsTest
{
    private MathOperations _operation;

    [TestInitialize]
    public void Init()
    {
        _operation = new MathOperations();
    }

    [TestMethod]
    [DataRow(3, 3, 6)]
    [DataRow(28, 11, 39)]
    public void Add_WithTwoNumbers_ReturnInt(int number1, int number2, int expectedResult)
    {
        var result = _operation.Add(number1, number2);

        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    [DataRow(6, 6, 1)]
    [DataRow(14, 2, 7)]
    public void Divide_WithTwoNumbers_ReturnInt(int number1, int number2, int expectedResult)
    {
        var result = _operation.Divide(number1, number2);

        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    [DataRow(1, 0)] 
    [DataRow(23, 0)] 
    public void Divide_WithTwoNumbers_Number2Egal0_ThrowsArgumentException(int number1, int number2)
    {
        Assert.ThrowsException<ArgumentException>(() => _operation.Divide(number1, number2));
    }

    [TestMethod]
    [DataRow(5, 1, 3, 5)] 
    public void GetOddNumbers_PositiveLimit_ReturnsCorrectResult(int limit, int listItem1, int listItem2, int listeItem3)
    {
     
        var result = _operation.GetOddNumbers(limit);

        CollectionAssert.AreEqual(new List<int> { listItem1, listItem2, listeItem3 }, result.ToList());
    }

    [TestMethod]
    [DataRow(0)]
    public void GetOddNumbers_ZeroLimit_ReturnsEmptyList(int zeroValue)
    {
        var result = _operation.GetOddNumbers(zeroValue);

        CollectionAssert.AreEqual(new List<int>(), result.ToList());
    }

    [TestMethod]
    [DataRow(-1)]
    public void GetOddNumbers_NegativeLimit_ThrowsArgumentException(int negativeValue)
    {
        Assert.ThrowsException<ArgumentException>(() => _operation.GetOddNumbers(negativeValue));
    }
}


