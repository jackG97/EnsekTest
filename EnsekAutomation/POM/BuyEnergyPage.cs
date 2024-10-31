using NUnit.Framework;
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
    public class BuyEnergyPage
    {
        private IWebDriver driver;
        By ResetButton = By.XPath("//input[contains(name, 'Reset')]");
        By GasField = By.XPath("//input[contains(name, 'energyType.AmountPurchased')]");
        By ElectricityField = By.XPath("//input[contains(name, 'energyType.AmountPurchased')]");
        By OilField = By.XPath("//input[contains(name, 'energyType.AmountPurchased')]");
        By BuyEnergyUnitButton = By.XPath("//input[contains(name, 'Buy')]");
        By PurchaseCompleteMessage = By.XPath("//div[contains(., 'Thank you for your purchase of 300 units of Gas. We have popped it in the post and it will be with you shortly.')]");
        


        public BuyEnergyPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private void SelectResetButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(ResetButton)).Click();
        }

        private void BuyUnitsOfEnergy()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(GasField)).SendKeys('300');

            //wait.Until(ExpectedConditions.ElementExists(ElectricityField)).SendKeys('300');

            //wait.Until(ExpectedConditions.ElementExists(OilField)).SendKeys('300');
            wait.Until(ExpectedConditions.ElementExists(BuyEnergyUnitButton)).Click();

            wait.Until(ExpectedConditions.ElementExists(PurchaseCompleteMessage));
        }


    }
}
