using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharp;

public class GoogleWithCustomMethods
{
    [Test]
    public void DropdownMulti()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://google.com");
        driver.Manage().Window.Maximize();
        
        //using selectElement for multiselect with custom methods
        CustomMethod.SelectDropDownByText(driver, By.Id(("dropdown")), "multi1");
        CustomMethod.SelectDropDownByText(driver, By.Id(("dropdown")), "multi2");
        
        //using selectElement for multiselect with custom methods for array of values
        CustomMethod.MultiSelectElements(driver, By.Id(("multiselect")), ["multi1", "multi2"]);

        var getSelectedOptions = CustomMethod.GetAllSelectedLists(driver, By.Id("multiselect"));
        //ForEach to traverse through a list
        getSelectedOptions.ForEach(Console.WriteLine);
    }
}