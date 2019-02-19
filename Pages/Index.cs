using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace deskyteskresking.Pages
{
    class Index
    {
        private IWebDriver driver;

        /* By Objects */

        /* Number Of Players Selection */
        private By playerButton1 = By.CssSelector("#root > div > header > div:nth-child(4) > form > ul:nth-child(1) > li:nth-child(1) > button");
        private By playerButton2 = By.CssSelector("#root > div > header > div:nth-child(4) > form > ul:nth-child(1) > li:nth-child(2) > button");
        private By playerButton3 = By.CssSelector("#root > div > header > div:nth-child(4) > form > ul:nth-child(1) > li:nth-child(3) > button");
        private By playerButton4 = By.CssSelector("#root > div > header > div:nth-child(4) > form > ul:nth-child(2) > li:nth-child(1) > button");
        private By playerButton5 = By.CssSelector("#root > div > header > div:nth-child(4) > form > ul:nth-child(2) > li:nth-child(2) > button");
        private By playerButton6 = By.CssSelector("#root > div > header > div:nth-child(4) > form > ul:nth-child(2) > li:nth-child(3) > button");
        private By playerButton7 = By.CssSelector("#root > div > header > div:nth-child(4) > form > ul:nth-child(3) > li:nth-child(1) > button");
        private By playerButton8 = By.CssSelector("#root > div > header > div:nth-child(4) > form > ul:nth-child(3) > li:nth-child(2) > button");
        private By playerButton8Plus = By.CssSelector("#root > div > header > div:nth-child(4) > form > ul:nth-child(3) > li:nth-child(3) > button");

        /* Number of Holes Selection */
        private By holeButton9 = By.CssSelector("#nineHoles");
        private By holeButton18 = By.CssSelector("#eighteenHoles");
        private By playersTab;

        /* Enter Names of Players */


        /* Constructor */
        public Index(IWebDriver driver)
        {
            this.driver = driver;
        }
           
        /* Go To Website */
        public void GoToWebsite(string url)
        {
            this.driver.Navigate().GoToUrl(url);
        }

        /* Select Number of players */
        public void SelectNumberOfPlayer(int a)
        {
            switch (a)
            {
                case 1:
                    this.driver.FindElement(playerButton1).Click();
                    break;
                case 2:
                    this.driver.FindElement(playerButton2).Click();
                    break;
                case 3:
                    this.driver.FindElement(playerButton3).Click();
                    break;
                case 4:
                    this.driver.FindElement(playerButton4).Click();
                    break;
                case 5:
                    this.driver.FindElement(playerButton5).Click();
                    break;
                case 6:
                    this.driver.FindElement(playerButton6).Click();
                    break;
                case 7:
                    this.driver.FindElement(playerButton7).Click();
                    break;
                case 8:
                    this.driver.FindElement(playerButton8).Click();
                    break;
                case 9:
                    this.driver.FindElement(playerButton8Plus).Click();
                    break;
                default:
                    break;
            }
        }

        /* Select Number of Holes */
        public void SelectNumberOfHoles(int a)
        {
            switch (a)
            {
                case 9:
                    this.driver.FindElement(holeButton9).Click();
                    break;
                case 18:
                    this.driver.FindElement(holeButton18).Click();
                    break;
                default:
                    break;
            }
        }
    }
}
