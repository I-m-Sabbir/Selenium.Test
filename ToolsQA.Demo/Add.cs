using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace ToolsQA.Demo;

public static class Add
{
    public static void AddToCollection(this IWebDriver driver)
    {
        Console.WriteLine("Add To Collection");
        var item = driver.FindElement(By.ClassName("show"));
        item.FindElement(By.Id("item-2")).Click();
        Thread.Sleep(1000);
        PerformAdd(driver);
    }

    private static void PerformAdd(IWebDriver driver)
    {
        var elements = driver.FindElements(By.CssSelector("#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div.books-wrapper > div.ReactTable.-striped.-highlight > div.rt-table > div.rt-tbody > div"));
        if (elements is not null && elements.Count > 0)
        {
            for (int i = 0; i < 4; i++)
            {
                var items = driver.FindElements(By.CssSelector("#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div.books-wrapper > div.ReactTable.-striped.-highlight > div.rt-table > div.rt-tbody > div"));
                Console.WriteLine(items.Count);
                items[i].FindElement(By.CssSelector("div > div:nth-child(2) > div > span > a")).Click();
                Thread.Sleep(1000);
                var buttons = driver.FindElements(By.CssSelector("#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div.books-wrapper > div.profile-wrapper > div.mt-2.fullButtonWrap.row > div"));
                Console.WriteLine(items.Count);
                Thread.Sleep(5000);
                buttons[1].FindElement(By.Id("addNewRecordButton")).Click();
                Thread.Sleep(1000);
                IAlert addAlert = driver.SwitchTo().Alert();
                Console.WriteLine(addAlert.Text);
                Thread.Sleep(1000);
                addAlert.Accept();
                Thread.Sleep(1000);
                buttons[0].FindElement(By.Id("addNewRecordButton")).Click();
                Thread.Sleep(1000);
            }
        }
        else
        {
            Console.WriteLine("No books to add");
        }
        Console.WriteLine("Adding Book Finished");
    }
}