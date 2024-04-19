using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCSharp;

public class CustomMethod
{
    public static void Click(IWebDriver driver, By locator)
    {
        driver.FindElement(locator).Click();
    }
    
    public static void EnterText(IWebDriver driver, By locator, String text)
    {
        driver.FindElement(locator).Clear();
        driver.FindElement(locator).SendKeys(text);
    }
    
    public static void SelectDropDownByText(IWebDriver driver, By locator, String text)
    {
        SelectElement selectElement = new SelectElement(driver.FindElement(locator));
        selectElement.SelectByText(text);
    }
    
    public static void SelectDropDownByValue(IWebDriver driver, By locator, String value)
    {
        SelectElement selectElement = new SelectElement(driver.FindElement(locator));
        selectElement.SelectByText(value);
    }
    
    public static void MultiSelectElements(IWebDriver driver, By locator, String[] values)
    {
        SelectElement multiSelect = new SelectElement(driver.FindElement(locator));
        foreach (var value in values)
        {
            multiSelect.SelectByText(value);
        }
    }

    public static List<String> GetAllSelectedLists(IWebDriver driver, By locator)
    {
        //creating a list called options to find the selected options and add it to the list
        List<string> options = new List<string>();
        //declaring the select option
        SelectElement multiSelect = new SelectElement(driver.FindElement(locator));
        //Finding the selected option in the multiselect
        IList<IWebElement> selectOption = multiSelect.AllSelectedOptions;
        //using foreach to go through the list of webelement
        foreach (IWebElement option in selectOption)
        {
            options.Add(option.Text);
        }

        return options;
    }
}