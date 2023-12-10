namespace HelloSeleniumTest;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[TestClass]
public class UnitTest1
{
    IWebDriver driver;

    [TestMethod]
    public void TestMethod1()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://spacecoin.click/");
        driver.FindElement(By.Id("Tokenomics"));
        Assert.IsTrue(driver.PageSource.Contains("About"));
        driver.Quit();
    }
}