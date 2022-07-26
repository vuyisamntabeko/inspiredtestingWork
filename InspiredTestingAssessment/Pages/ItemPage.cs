using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InspiredTestingAssessment.Pages
{


    public class ItemPage
    {
        public IWebDriver WebDriver { get; }

        public ItemPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement addToCart => WebDriver.FindElement(By.XPath("//*[@id='shopfront-app']/div[3]/div[1]/div[2]/aside/div[1]/div[2]/div/div/div[2]/a"));

        public IWebElement goToCart => WebDriver.FindElement(By.XPath("//*[@id='body']/div[7]/div[1]/div/div/div/div/div[2]/div/div[1]/div/div[1]/div/div/div[2]/div[3]/button"));

        

        public bool IsTakealotItemPageDisplayed(string itemText)
        {
            Thread.Sleep(5000);

            string comparingText = itemText + " | Buy Online in South Africa | takealot.com";

            if (WebDriver.Title == comparingText)
                return true;
            else
                return false;
        }

        public void ClickOnAddToCart()
        {
            //Thread.Sleep(2000);
            WebDriver.SwitchTo().DefaultContent();
            addToCart.Click();
        }

        public void ClickOnGoToCart()
        {
            Thread.Sleep(5000);
            goToCart.Click();
        }

    }
}
