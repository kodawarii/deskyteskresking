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
        private By player1 = By.CssSelector("#root > div > header > div:nth-child(4) > form > div:nth-child(1) > input");
        private By player2 = By.CssSelector("#root > div > header > div:nth-child(4) > form > div:nth-child(2) > input");
        private By player3;
        private By player4;
        private By player5;
        private By player6;
        private By player7;
        private By player8;

        private By startGameBtn = By.CssSelector("#submitButton");

        /* PlayGameState Elements */
        // ...

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

        /* Enter Names of Players */
        public void EnterNames(string name, int index)
        {
            switch (index)
            {
                case 1:
                    this.driver.FindElement(player1).SendKeys(name);
                    break;
                case 2:
                    this.driver.FindElement(player2).SendKeys(name);
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                default:
                    break;
            }
        }

        /* Start the Game */
        public void StartGame()
        {
            this.driver.FindElement(startGameBtn).Click();
        }
    }
}
