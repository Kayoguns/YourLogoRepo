using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using YourLogoTest.Utilities;

namespace YourLogoTest.PageObject
{
    class YourLogopage1
    {
        public YourLogopage1()
        {
            driver = YourLogoHooks.driver;
        }

        IWebDriver driver;

        IWebElement Search => driver.FindElement(By.XPath("(//input[@type='text'])[1]"));
        IWebElement SearchButton => driver.FindElement(By.XPath("//*[@id='searchbox']/button"));
        IWebElement PrintedSummerDress => driver.FindElement(By.XPath("//*[@id='center_column']/ul/li[1]/div/div[2]/h5/a"));
        IWebElement BlueColor => driver.FindElement(By.XPath("//a[@name='Blue']"));
        IWebElement Dropdown => driver.FindElement(By.XPath("//select[@id='group_1']"));
        IWebElement Medium => driver.FindElement(By.XPath("//select[@id='group_1']"));
        IWebElement PlusSign => driver.FindElement(By.XPath("(//a[@data-field-qty='qty'])[2]"));
        IWebElement AddToCart => driver.FindElement(By.XPath("(//button[@type='submit'])[3]"));
        IWebElement ProceedToCheckout => driver.FindElement(By.XPath("//a[@class='btn btn-default button button-medium']"));
        IWebElement ProductAdded => driver.FindElement(By.XPath("//i[@class='icon-ok']"));
        IWebElement payment => driver.FindElement(By.XPath("//li[@id='step_end']"));
        IWebElement PlusSignButton => driver.FindElement(By.XPath("(//a[@rel='nofollow'])[7]"));
        IWebElement Shipping => driver.FindElement(By.XPath("//li[@class='step_todo four']"));


        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
        public void EnterSearch()
        {
            Search.SendKeys("Printed Summer Dress");
        }
        public void ClickOnSearchButton()
        {
            Thread.Sleep(5000);
            SearchButton.Click();
        }
        public void ClickOnPrintedSummerDress()
        {
            PrintedSummerDress.Click();
        }
        public void ClickOnBlueColor()
        {
            BlueColor.Click();
        }
        public void ClickOnDropdown()
        {
            Dropdown.Click();
        }
        public void SelectMedium()
        {
            SelectElement select = new SelectElement(Medium);
            select.SelectByValue("2");
            Medium.Click();
        }
        public void ClickOnPlusSign()
        {
            PlusSign.Click();
        }
        public void ClickOnAddToCart()
        {
            AddToCart.Click();
        }
         public void ClickOnProceedToCheckout()
        {
            ProceedToCheckout.Click();
        }
        public bool IsProductAddedDisplayed()
        {
            Thread.Sleep(3000);
            return ProductAdded.Displayed;
        }
        public bool IsPaymentDisplayed()
        {
            return payment.Displayed;
        }
        public void ClickOnPlusSignButton()
        {
            PlusSignButton.Click();
        }
        public bool IsShippingDisplayed()
        {
            return Shipping.Displayed;
        }





    }   

    





}
