using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCSharp;

public class Tests
{
    [Test]
    public void BasicTest()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://google.com");
        driver.Manage().Window.Maximize();

        //using IWebElement
        IWebElement textBox = driver.FindElement(By.Name("q"));
        textBox.SendKeys("Selenium");
        textBox.SendKeys(Keys.Return);

        //reduced line of code
        driver.FindElement(By.Name("q")).SendKeys("selenium");

        //can use var instead of IWebElement
        var submitBtn = driver.FindElement(By.CssSelector(".btn"));
        submitBtn.Click();

        driver.Close();
    }

    [Test]
    public void DropdownMulti()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://google.com");
        driver.Manage().Window.Maximize();

        //using SelectElement on drop down
        SelectElement selectElement = new SelectElement(driver.FindElement(By.Id(("dropdown"))));
        selectElement.SelectByText("option 3");

        //using selectElement for multiselect
        SelectElement multiSelect = new SelectElement(driver.FindElement(By.Id(("multiselect"))));
        multiSelect.SelectByText("multi1");
        multiSelect.SelectByText("multi2");

        //Finding the selected option in the multiselect
        IList<IWebElement> selectOption = multiSelect.AllSelectedOptions;

        //using foreach to go through the list of webelement
        foreach (IWebElement option in selectOption)
        {
            Console.WriteLine(option.Text);
        }
        driver.Close();
    }
}