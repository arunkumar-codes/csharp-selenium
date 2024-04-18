using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace SeleniumCSharp.Utilities;

public class BrowserUtil : IDisposable
{
    private IWebDriver driver;
    [SetUp] //[OneTimeSetup] to setup once and execute tests in unit test
    public void Open()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Url = "https://www.facebook.com";
        driver.Manage().Window.Maximize();
    }

    [TearDown] //[OneTimeTearDown]
    public void Dispose()
    {
        driver?.Quit();
    }
}