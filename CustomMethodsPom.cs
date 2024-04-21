using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCSharp;

public class CustomMethodsPom
{
    public static void Click(IWebElement locator)
    {
        locator.Click();
    }
    
    public static void EnterText(IWebElement locator, String text)
    {
        locator.Clear();
        locator.SendKeys(text);
    }

    public static void Submit(IWebElement locator)
    {
        locator.Submit();
    }
    
    public static void SelectDropDownByText(IWebElement locator, String text)
    {
        SelectElement selectElement = new SelectElement(locator);
        selectElement.SelectByText(text);
    }
    
    public static void SelectDropDownByValue(IWebElement locator, String value)
    {
        SelectElement selectElement = new SelectElement(locator);
        selectElement.SelectByText(value);
    }
    
    public static void MultiSelectElements(IWebElement locator, String[] values)
    {
        SelectElement multiSelect = new SelectElement(locator);
        foreach (var value in values)
        {
            multiSelect.SelectByText(value);
        }
    }

    public static List<String> GetAllSelectedLists(IWebElement locator)
    {
        //creating a list called options to find the selected options and add it to the list
        List<string> options = new List<string>();
        //declaring the select option
        SelectElement multiSelect = new SelectElement(locator);
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