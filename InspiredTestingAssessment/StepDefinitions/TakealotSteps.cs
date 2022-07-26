using InspiredTestingAssessment.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace InspiredTestingAssessment.StepDefinitions
{
    [Binding]
    public sealed class TakealotSteps
    {
        // For additional details on SpecFlow step definitseleions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        IWebDriver webDriver = null;

        HomePage homePage = null;
        ItemPage itemPage = null;
        CartPage cartPage = null;

        string itemText = string.Empty;

        public TakealotSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I launch Takealot Site")]
        public void GivenILaunchTakealot()
        {

            var options = new ChromeOptions();

            

            options.AddArguments("start-maximized");

            webDriver = new ChromeDriver(options);

            webDriver.Navigate().GoToUrl("https://www.takealot.com/");

            homePage = new HomePage(webDriver);
            itemPage = new ItemPage(webDriver);
            cartPage = new CartPage(webDriver);
        }


        [Then(@"I should see Takealot Home Page")]
        public void ThenIShouldSeeTakealotHomePage()
        {
            
            Assert.IsTrue(homePage.IsTakealotHomePageDisplayed(),"The Home Page did not load");
            itemText = homePage.getItemText();
        }

        [When(@"I Click on the Item")]
        public void WhenIClickOnTheItem()
        {
            homePage.ClickOnItem();
        }

        [Then(@"I should see Item Page")]
        public void ThenIShouldSeeItemPage()
        {
            Assert.IsTrue(itemPage.IsTakealotItemPageDisplayed(itemText), "The Item Page did not load");
        }

        [When(@"I Click on add To Cart")]
        public void WhenIClickOnAddToCart()
        {
            itemPage.ClickOnAddToCart();
        }

        [When(@"I Click on Go To Cart")]
        public void WhenIClickOnGoToCart()
        {
            itemPage.ClickOnGoToCart();
        }

        [Then(@"I should See Cart Screen")]
        public void ThenIShouldSeeCartScreen()
        {
            Assert.IsTrue(cartPage.IsTakealotHomePageDisplayed(), "The Home Page did not load");
        }


        [Then(@"I Click on Proceed To Checkout")]
        public void WhenIClickOnProceedToCheckout()
        {
            cartPage.ClickProceedToCheckOut();
        }


    }
}
