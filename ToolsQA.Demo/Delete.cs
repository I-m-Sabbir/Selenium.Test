using OpenQA.Selenium;

namespace ToolsQA.Demo;

public static class Delete
{
    public static void DeleteFromCollection(this IWebDriver driver)
    {
        Console.WriteLine("Step on Delete.");
        var url = driver.Url;
        Console.WriteLine(url);
        Thread.Sleep(1000);
        if (url.Equals("https://demoqa.com/profile") == false)
        {
            Console.WriteLine("false");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            var item = driver.FindElement(By.ClassName("show"));
            item.FindElement(By.Id("item-3")).Click();
        }
        Thread.Sleep(1000);
        PerformDelete(driver);
    }

    private static void PerformDelete(IWebDriver driver)
    {
        Console.WriteLine("Step on Perform Delete.");
        do{
            var items = driver.FindElements(By.Id("delete-record-undefined"));
            if (items.Count == 0)
                break;
            items[0].Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("closeSmallModal-ok")).Click();
            Thread.Sleep(3000);
            IAlert deleteAlert = driver.SwitchTo().Alert();
            Console.WriteLine(deleteAlert.Text);
            Thread.Sleep(1000);
            deleteAlert.Accept();
            Thread.Sleep(1000);
        }
        while(driver.FindElements(By.Id("delete-record-undefined")).Count >= 1);

        Console.WriteLine("Delete Finished.");
    }
}
