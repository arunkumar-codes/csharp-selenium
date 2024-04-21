using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharp.Pages;

public class POMTest
{
    [Test]
    public void TestOne()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://google.com");
        
        //POM implementation
        LoginPage loginPage = new LoginPage(driver);
        
        loginPage.ClickLogin();
        loginPage.Login("dkumar@gmail.com", "loginpassword");
    }
}