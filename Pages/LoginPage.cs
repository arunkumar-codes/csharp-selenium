using OpenQA.Selenium;

namespace SeleniumCSharp.Pages;

public class LoginPage
{
    private readonly IWebDriver driver;
    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
    }
    
    IWebElement LoginLink => driver.FindElement(By.Id("loginLink"));

    IWebElement TxtUsr => driver.FindElement(By.Id("UserName"));
    
    IWebElement TxtPassword => driver.FindElement(By.Id("Password"));
    
    IWebElement BtnLogin => driver.FindElement(By.CssSelector(".btn"));

    public void ClickLogin()
    {
        LoginLink.Click();
    }

    public void Login(String username, String password)
    {
        TxtUsr.SendKeys(username);
        TxtPassword.SendKeys(password);
        BtnLogin.Click();
    }
}