using System;
using EvaluationSampleCode;

namespace Evalutation_RomainGILOT_UnitTest;

[TestClass]
public class HtmlFormatHelperTest
{
    private HtmlFormatHelper _htmlFormat;

    [TestInitialize]
    public void Init()
    {
        _htmlFormat = new HtmlFormatHelper();
    }

    [DataTestMethod]
    [DataRow("Romain GILOT en gras", "<b>Romain GILOT en gras</b>")]
    public void GetBoldFormat_ContentInBoldTags(string content, string expectedResult)
    {
        var result = _htmlFormat.GetBoldFormat(content);

        Assert.AreEqual(expectedResult, result);
    }

    [DataTestMethod]
    [DataRow("Romain GILOT en italique", "<i>Romain GILOT en italique</i>")]
    public void GetItalicFormat_ContentInItalicTags(string content, string expectedResult)
    {
        var result = _htmlFormat.GetItalicFormat(content);

        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void GetFormattedListElements_ReturnFormattedList()
    {
        var result = _htmlFormat.GetFormattedListElements(new List<string> { "DFS", "GROUPE 1", "2023" });

        Assert.AreEqual("<ul><li>DFS</li><li>GROUPE 1</li><li>2023</li></ul>", result);
    }

    [TestMethod]
    public void GetFormattedListElements_WithEmptyList_ReturnEmptyList()
    {
        var result = _htmlFormat.GetFormattedListElements(new List<string>());

        Assert.AreEqual("<ul></ul>", result);
    }

}


