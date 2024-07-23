using NUnit.Framework;
using YouSourceCodingExam.Class;
using YouSourceCodingExam.Controller;
using YouSourceCodingExam.Model;

[TestFixture]
public class SortControllerTests
{

    //Bubble Sorting Test
    [Test]
    public void SortController_SortsUsingBubbleSort()
    {
       
        var model = new SortModel();
        var controller = new SortController(model);
        controller.SetSortStrategy(new BubbleSortStrategy());
        string input = "befdac";
        string expected = "abcdef";

       
        controller.UpdateModel(input);
        controller.Sort();
        string result = controller.GetSortedString();

       
        Assert.AreEqual(expected, result);
    }


    //Quick Sorting Test
    [Test]
    public void SortController_SortsUsingQuickSort()
    {
      
        var model = new SortModel();
        var controller = new SortController(model);
        controller.SetSortStrategy(new QuickSortStrategy());
        string input = "befdac";
        string expected = "abcdef";


        controller.UpdateModel(input);
        controller.Sort();
        string result = controller.GetSortedString();

       
        Assert.AreEqual(expected, result);
    }
}

