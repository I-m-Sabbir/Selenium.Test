using OpenQA.Selenium;

namespace ToolsQA.Demo;

public static class Logout
{
    public static void LogoutFromBookStore(this IWebDriver driver)
    {
        Console.WriteLine("Loging Out.");
        Thread.Sleep(1000);
        driver.FindElement(By.XPath("//*[@id=\"books-wrapper\"]/div[3]/button")).Click();
    }
}
