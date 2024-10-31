using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsekAutomation.POM
{
    public class HomePage
    {

        private IWebDriver driver;
        By BuyEnergyButton = By.XPath("//a[contains(., 'Buy energy')]");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private void SelectBuyButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(BuyEnergyButton)).Click();
        }

     


    }


    }
}
