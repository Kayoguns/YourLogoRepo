using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using YourLogoTest.PageObject;

namespace YourLogoTest.StepDefinition
{
    [Binding]
    public class YourLogo1Steps
    {
        YourLogopage1 yourLogopage1;


        public YourLogo1Steps()
        {
            yourLogopage1 = new YourLogopage1();
        }
            
             
        
        
        
        [Given(@"I Navigate to the website ""(.*)""")]
        public void GivenINavigateToTheWebsite(string p0)
        {
           yourLogopage1.NavigateToWebsite();
        }
        
        [Given(@"I search For ""(.*)""")]
        public void GivenISearchFor(string p0)
        {
           yourLogopage1.EnterSearch();
        }
        
        [Given(@"I click On search Button")]
        public void GivenIClickOnSearchButton()
        {
            yourLogopage1.ClickOnSearchButton();
        }
        
        [Given(@"I click on printed summer dress")]
        public void GivenIClickOnPrintedSummerDress()
        {
            yourLogopage1.ClickOnPrintedSummerDress();
        }
        
        [Given(@"I click on blue color")]
        public void GivenIClickOnBlueColor()
        {
            yourLogopage1.ClickOnBlueColor();
        }
        
        [Given(@"I click on drop down")]
        public void GivenIClickOnDropDown()
        {
            yourLogopage1.ClickOnDropdown();
        }
        
        [Given(@"I select medium")]
        public void GivenISelectMedium()
        {
            yourLogopage1.SelectMedium();
        }
        
        [Given(@"I click on plus sign to add two quatities to basket")]
        public void GivenIClickOnPlusSignToAddTwoQuatitiesToBasket()
        {
           yourLogopage1.ClickOnPlusSign();
        }
        
        [Given(@"I click on Add to cart")]
        public void GivenIClickOnAddToCart()
        {
            yourLogopage1.ClickOnAddToCart();
        }
        [Then(@"I should be able to see product suceesfully added")]
        public void ThenIShouldBeAbleToSeeProductSuceesfullyAdded()
        {
            Assert.That(yourLogopage1.IsProductAddedDisplayed);
        }

        [When(@"I click on proceed to check out")]
        public void WhenIClickOnProceedToCheckOut()
        {
            yourLogopage1.ClickOnProceedToCheckout();
        }
       
        [Then(@"I validate total value in the basket")]
        public void ThenIValidateTotalValueInTheBasket()
        {
            Assert.That(yourLogopage1.IsPaymentDisplayed);
        }
        
        [When(@"I click on the plus sign Button to add three quantities to basket")]
        public void WhenIClickOnThePlusSignButtonToAddThreeQuantitiesToBasket()
        {
            yourLogopage1.ClickOnPlusSignButton();
        }
            
        
        [Then(@"I confirm the quanties in the basket has been updated sucessfully")]
        public void ThenIConfirmTheQuantiesInTheBasketHasBeenUpdatedSucessfully()
        {
            Assert.That(yourLogopage1.IsShippingDisplayed);
        }
    }
}
