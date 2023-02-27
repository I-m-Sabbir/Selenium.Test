using OpenQA.Selenium;
using System.Runtime.CompilerServices;

namespace ToolsQA.Demo;

public static class Login
{
    public static void LoginToBookStore(this IWebDriver driver)
    {
        driver.FindElement(By.Id("userName")).SendKeys("user_sabbir");
        Thread.Sleep(1000);
        driver.FindElement(By.Id("password")).SendKeys("Asd123!@#");
        Thread.Sleep(1000);
        driver.FindElement(By.Id("login")).Click();
    }
}
