using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FormSubmit
{
    public static class InstituteAccountDetails
    {
        public static void Create(IWebDriver driver)
        {
            driver.FindElement(By.LinkText("Add New")).Click();
            Wait();
            var selectList = new SelectElement(driver.FindElement(By.Id("status")));
            selectList.SelectByText("Active");
            Wait();
            selectList = new SelectElement(driver.FindElement(By.Id("institute")));
            selectList.SelectByValue("102");
            Wait();
            selectList = new SelectElement(driver.FindElement(By.Id("instituteAccount")));
            selectList.SelectByValue("118");
            Wait();
            driver.FindElement(By.Id("Name")).SendKeys("Selenium Test by Sabbir");
            Wait();
            driver.FindElement(By.Id("Email")).SendKeys("Selenium@Sabbir.com");
            Wait();
            driver.FindElement(By.Id("TokenGenerationTime")).Click();
            Wait();
            driver.FindElement(By.CssSelector("body>div.tempus-dominus-widget.light.show>div.date-container.td-collapse.show>div.date-container-days>div:nth-child(31)")).Click();
            Wait();
            driver.FindElement(By.CssSelector("body>div.tempus-dominus-widget.light.show>div.time-container.td-collapse.show>div.time-container-clock>div:nth-child(5)")).Click();
            Wait();
            driver.FindElement(By.CssSelector("body>div.tempus-dominus-widget.light.show>div.time-container.td-collapse.show>div.time-container-hour>div:nth-child(2)")).Click();
            Wait();
            driver.FindElement(By.CssSelector("body>div.tempus-dominus-widget.light.show>div.time-container.td-collapse.show>div.time-container-clock>div:nth-child(7)")).Click();
            Wait();
            driver.FindElement(By.CssSelector("body>div.tempus-dominus-widget.light.show>div.time-container.td-collapse.show>div.time-container-minute>div:nth-child(1)")).Click();
            Wait();
            Wait();
            driver.FindElement(By.Id("ExpireTime")).Click();
            Wait();
            driver.FindElement(By.CssSelector("body>div.tempus-dominus-widget.light.show>div.date-container.td-collapse.show>div.date-container-days>div:nth-child(31)")).Click();
            Wait();
            //driver.FindElement(By.CssSelector("body>div.tempus-dominus-widget.light.show>div.toolbar>div:nth-child(2)>svg")).Click();
            //Wait();
            driver.FindElement(By.CssSelector("body>div.tempus-dominus-widget.light.show>div.time-container.td-collapse.show>div.time-container-clock>div:nth-child(7)")).Click();
            Wait();
            driver.FindElement(By.CssSelector("body>div.tempus-dominus-widget.light.show>div.time-container.td-collapse.show>div.time-container-minute>div:nth-child(7)")).Click();
            Wait();
            driver.FindElement(By.Id("btnSubmit")).Click();
        }

        static void Wait()
        {
            Thread.Sleep(3000);
        }
    }
}
