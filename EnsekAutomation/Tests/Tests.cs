using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnsekAutomation.POM;

namespace EnsekAutomation.Tests
{


    public class Tests
    {
        IWebDriver driver = new ChromeDriver();

        private void OpenApplication(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl('https://ensekautomationcandidatetest.azurewebsites.net/');
        }

        private void CloseApplication(IWebDriver driver)
        {
            driver.Close();
        }

        [Test]
        // The first test case is for reseting the energy units
        public void ResetData()
        {
            IWebDriver driver = new ChromeDriver();
            HomePage hp = new HomePage(driver);
            BuyEnergyPage be = new BuyEnergyPage(driver);
            OpenApplication();
            hp.SelectBuyButton();
            be.SelectResetButton();
            CloseApplication();
        }

        // The second test case is for Buying energy of units
        [Test]
        public void BuyUnitsOfEnergy()
        {
            IWebDriver driver = new ChromeDriver();
            HomePage hp = new HomePage(driver);
            BuyEnergyPage be = new BuyEnergyPage(driver);
            OpenApplication();
            hp.SelectBuyButton();
            be.BuyUnitsOfEnergy();
            CloseApplication();


        }
        



    }
}
