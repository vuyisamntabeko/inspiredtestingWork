using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InspiredTestingAssessment.Pages
{
    public class HomePage
    {

        public IWebDriver WebDriver { get; }

        public HomePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }


        //Web Elements
        //public IWebElement item => WebDriver.FindElement(By.XPath("//*[@id='0c95e62c-40fd-4330-81a4-beec804f1d81']/div[2]/div/div/div/div[3]/div[1]/div/a"));
        public IWebElement item => WebDriver.FindElement(By.XPath("//*[@id='0c95e62c-40fd-4330-81a4-beec804f1d81']/div[2]/div/div/div/div[3]/div[1]/div"));

        public IWebElement element => WebDriver.FindElement(By.XPath("//*[@id='0c95e62c-40fd-4330-81a4-beec804f1d81']/div[2]/div/div/div/div[3]/div[1]/div/div[2]/div[2]/a/h4"));

        string itemHeading = string.Empty;

        //Methods
        public bool IsTakealotHomePageDisplayed()
        {
            Thread.Sleep(5000);
            if (WebDriver.Title == "Takealot.com: Online Shopping | SA's leading online store")
                return true;
            else
                return false;
        }

        public void ClickOnItem()
        {
            Thread.Sleep(5000);

            IJavaScriptExecutor js = (IJavaScriptExecutor)this.WebDriver;

            js.ExecuteScript("arguments[0].scrollIntoView(true);", item);

            item.Click();
        }

        public string getItemText()
        {
            return element.Text;
        }



    }
}
