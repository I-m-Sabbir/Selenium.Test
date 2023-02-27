using FormSubmit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.UI;

IWebDriver driver = new ChromeDriver();
driver.Url = "https://om-admin.osl.team/";
driver.Manage().Window.Maximize();
Wait();
Login(driver);
Wait();

var items = driver.FindElements(By.XPath(".//*[@id=\"flush-headingOne\"]/button"));
items[0].Click();
Wait();
driver.FindElement(By.LinkText("Manage Institute Account Details")).Click();
Wait();
InstituteAccountDetails.Create(driver);
Wait();
items = driver.FindElements(By.LinkText("Details"));
if (items.Count() > 0)
    items[0].Click();

Wait();
IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
Wait();
js = (IJavaScriptExecutor)driver;
js.ExecuteScript("window.scrollTo(0, 0)");
Wait();

driver.FindElement(By.LinkText("Back to Manage")).Click();
Wait();
var deleteItems = driver.FindElements(By.LinkText("Delete"));
deleteItems[0].Click();
Wait();
driver.FindElement(By.ClassName("bootbox-accept")).Click();
Wait();

driver.FindElement(By.Id("loginDropdown")).Click();
Wait();
driver.FindElement(By.LinkText("Logout")).Click();
Wait();
driver.Close();

void Login(IWebDriver driver)
{
    var result = driver.FindElement(By.XPath(string.Format("//*[@id=\"main-navbar\"]/div/a"))).Displayed;
    if (result)
        driver.FindElement(By.CssSelector("#main-navbar > div > a")).Click();
    else
    {
        driver.FindElement(By.XPath(string.Format("/html/body/header/nav/div/button"))).Click();
        var a = driver.FindElement(By.CssSelector("#main-navbar > div > a")).Displayed;
        Console.WriteLine(a);
    }

    Wait();
    driver.FindElement(By.Id("Email")).SendKeys("superadmin@gmail.com");
    Wait();
    driver.FindElement(By.Id("Password")).SendKeys("superAdmin123@gmail.com");
    Wait();
    driver.FindElement(By.Id("login-submit")).Click();
}

void Traverse(IWebDriver driver)
{
    var items = driver.FindElements(By.XPath(".//*[@id=\"flush-headingOne\"]/button"));
    items[0].Click();
    Wait();
    Surf("Manage Institute");
    Wait();
    Surf("Manage Institute Account");
    Wait();
    Surf("Manage Institute Account Details");
    Wait();
    items = driver.FindElements(By.XPath(".//*[@id=\"flush-headingOne\"]/button"));
    items[1].Click();
    Wait();
    Surf("Manage Stream Provider");
    Wait();
    items = driver.FindElements(By.XPath(".//*[@id=\"flush-headingOne\"]/button"));
    items[2].Click();
    Wait();
    Surf("Manage Institute Host");
    Wait();
    items = driver.FindElements(By.XPath(".//*[@id=\"flush-headingOne\"]/button"));
    items[3].Click();
    Wait();
    Surf("Manage Quiz Default Settings");
    Wait();
    items = driver.FindElements(By.XPath(".//*[@id=\"flush-headingOne\"]/button"));
    items[4].Click();
    Wait();
    Surf("Chat Settings");
    Wait();
    items = driver.FindElements(By.XPath(".//*[@id=\"flush-headingOne\"]/button"));
    items[5].Click();
    Wait();
    Surf("Manage Role");
    Wait();
    Surf("Manage User");
    Wait();
    items = driver.FindElements(By.XPath(".//*[@id=\"flush-headingOne\"]/button"));
    items[6].Click();
    Wait();
    Surf("Manage Meeting");
    Wait();
    items = driver.FindElements(By.XPath(".//*[@id=\"flush-headingOne\"]/button"));
    items[7].Click();
    Wait();
    Surf("Manage Global App Settings");
    Wait();
    items = driver.FindElements(By.XPath(".//*[@id=\"flush-headingOne\"]/button"));
    items[8].Click();
    Wait();
    Surf("Manage Institute Quiz");
    Wait();
    driver.FindElement(By.LinkText("OMA")).Click();
    Wait();
}


void Wait()
{
    Thread.Sleep(3000);
}

void Surf(string linkText)
{
    driver.FindElement(By.LinkText(linkText)).Click();
    Wait();
    var items = driver.FindElements(By.LinkText("Details"));
    if (items.Count() > 0)
        items[0].Click();
    Wait();
}
