using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InspiredTestingAssessment.Pages
{
    public class CartPage
    {
        public IWebDriver WebDriver { get; }

        public CartPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }


        //Web Elements
        public IWebElement proceedToCheckout => WebDriver.FindElement(By.XPath("//*[@id='shopfront-app']/div[3]/div[2]/section/div[2]/div[2]/div/div[1]/div[1]/div/div[2]/a"));

        //Methods
        public bool IsTakealotHomePageDisplayed()
        {
            Thread.Sleep(5000);
            if (WebDriver.Title == "Cart - TAKEALOT")
                return true;
            else
                return false;
        }

        public void ClickProceedToCheckOut()
        {
            Thread.Sleep(5000);
            proceedToCheckout.Click();
        }
    }
}
