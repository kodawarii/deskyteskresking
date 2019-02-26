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

        /* 1 Number Of Players Selection */
        private By playerButton1 = By.CssSelector("#root > div > header > div:nth-child(4) > form > ul:nth-child(1) > li:nth-child(1) > button");
        private By playerButton2 = By.CssSelector("#root > div > header > div:nth-child(4) > form > ul:nth-child(1) > li:nth-child(2) > button");
        private By playerButton3 = By.CssSelector("#root > div > header > div:nth-child(4) > form > ul:nth-child(1) > li:nth-child(3) > button");
        private By playerButton4 = By.CssSelector("#root > div > header > div:nth-child(4) > form > ul:nth-child(2) > li:nth-child(1) > button");
        private By playerButton5 = By.CssSelector("#root > div > header > div:nth-child(4) > form > ul:nth-child(2) > li:nth-child(2) > button");
        private By playerButton6 = By.CssSelector("#root > div > header > div:nth-child(4) > form > ul:nth-child(2) > li:nth-child(3) > button");
        private By playerButton7 = By.CssSelector("#root > div > header > div:nth-child(4) > form > ul:nth-child(3) > li:nth-child(1) > button");
        private By playerButton8 = By.CssSelector("#root > div > header > div:nth-child(4) > form > ul:nth-child(3) > li:nth-child(2) > button");
        private By playerButton8Plus = By.CssSelector("#root > div > header > div:nth-child(4) > form > ul:nth-child(3) > li:nth-child(3) > button");

        /* 2 Number of Holes Selection */
        private By holeButton9 = By.CssSelector("#nineHoles");
        private By holeButton18 = By.CssSelector("#eighteenHoles");
        private By playersTab;

        /* 3 Enter Names of Players */
        private List<string> listOfPlayers = new List<string>();
        private By player1 = By.CssSelector("#root > div > header > div:nth-child(4) > form > div:nth-child(1) > input");
        private By player2 = By.CssSelector("#root > div > header > div:nth-child(4) > form > div:nth-child(2) > input");
        private By player3 = By.CssSelector("#root > div > header > div:nth-child(4) > form > div:nth-child(3) > input");
        private By player4 = By.CssSelector("#root > div > header > div:nth-child(4) > form > div:nth-child(4) > input");
        private By player5 = By.CssSelector("#root > div > header > div:nth-child(4) > form > div:nth-child(5) > input");
        private By player6 = By.CssSelector("#root > div > header > div:nth-child(4) > form > div:nth-child(6) > input");
        private By player7 = By.CssSelector("#root > div > header > div:nth-child(4) > form > div:nth-child(7) > input");
        private By player8 = By.CssSelector("#root > div > header > div:nth-child(4) > form > div:nth-child(8) > input");

        private By startGameBtn = By.CssSelector("#submitButton");

        /* 4 PlayGameState Elements */
        // Basic Elements
        private By gameDetails = By.CssSelector("#root > div > header > div.banner > div");
        private By holeNavInitial = By.CssSelector("#root > div > header > div:nth-child(4) > div > div > div:nth-child(1) > div.holeBannerContainer > span.holeBannerNumberCell.holeNumber1.greyOutThisHole");
        private By holeNavFinalHole9 = By.CssSelector("#root > div > header > div:nth-child(4) > div > div > div:nth-child(1) > div.holeBannerContainer > span.holeBannerNumberCell.holeNumber9");
        private By holeNavFinalHole18 = By.CssSelector("#root > div > header > div:nth-child(4) > div > div > div:nth-child(1) > div.holeBannerContainer > span.holeBannerNumberCell.holeNumber18");
        private By holeScrollerArrowLEFT = By.CssSelector("#root > div > header > div:nth-child(4) > div > div > div:nth-child(1) > div:nth-child(2) > span > button.HoleArrowButton.disableLeftHoleArrowButton");
        private By holeScrollerArrowRIGHT = By.CssSelector("#root > div > header > div:nth-child(4) > div > div > div:nth-child(1) > div:nth-child(2) > span > button:nth-child(2)");
        private By holeScrollerHOLE = By.CssSelector("#root > div > header > div:nth-child(4) > div > div > div:nth-child(1) > div:nth-child(2) > span");
        private By lastPlayedHole = By.CssSelector("#root > div > header > div:nth-child(4) > div > div > div:nth-child(1) > div:nth-child(3) > span > b");

        // List of Player Names
        private string namesByCssPRE = "#root > div > header > div:nth-child(4) > div > div > div:nth-child(4) > table > tbody > tr:nth-child(";
        private string namesByCssSUFF = ") > td:nth-child(1) > span";
        private List<By> listOfPlayerByCssSelector = new List<By>();

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
            this.listOfPlayers.Add(name);

            switch (index)
            {
                case 1:
                    this.driver.FindElement(player1).SendKeys(name);
                    this.listOfPlayerByCssSelector.Add(By.CssSelector(namesByCssPRE + "1" + namesByCssSUFF));
                    break;
                case 2:
                    this.driver.FindElement(player2).SendKeys(name);
                    this.listOfPlayerByCssSelector.Add(By.CssSelector(namesByCssPRE + "2" + namesByCssSUFF));
                    break;
                case 3:
                    this.driver.FindElement(player3).SendKeys(name);
                    this.listOfPlayerByCssSelector.Add(By.CssSelector(namesByCssPRE + "3" + namesByCssSUFF));
                    break;
                case 4:
                    this.driver.FindElement(player4).SendKeys(name);
                    this.listOfPlayerByCssSelector.Add(By.CssSelector(namesByCssPRE + "4" + namesByCssSUFF));
                    break;
                case 5:
                    this.driver.FindElement(player5).SendKeys(name);
                    this.listOfPlayerByCssSelector.Add(By.CssSelector(namesByCssPRE + "5" + namesByCssSUFF));
                    break;
                case 6:
                    this.driver.FindElement(player6).SendKeys(name);
                    this.listOfPlayerByCssSelector.Add(By.CssSelector(namesByCssPRE + "6" + namesByCssSUFF));
                    break;
                case 7:
                    this.driver.FindElement(player7).SendKeys(name);
                    this.listOfPlayerByCssSelector.Add(By.CssSelector(namesByCssPRE + "7" + namesByCssSUFF));
                    break;
                case 8:
                    this.driver.FindElement(player8).SendKeys(name);
                    this.listOfPlayerByCssSelector.Add(By.CssSelector(namesByCssPRE + "8" + namesByCssSUFF));
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

        /* Assert Intial state of PlayGameState*/
        public void AssertInitialPlayGameState(string players, string holes)
        {
            /* Asserting game details */
            string actualValueDetails = this.driver.FindElement(gameDetails).Text.ToString();
            string expectedValueDetails = "Players: " + players + " | Holes: " + holes + "\r\n\r\nReset Game ↻";
            Console.WriteLine("Asserting Game Details");
            Assert.AreEqual(actualValueDetails, expectedValueDetails);

            /* Asserting Hole Number-nav */
            Console.WriteLine("Asserting Hole Number-nav");
            Assert.AreEqual(HasClass(this.driver.FindElement(holeNavInitial), "greyOutThisHole"), "greyOutThisHole");

            /* Assert last hole is as selected either 9 or 18 */
            Console.WriteLine("Asserting last hole number-nav");
            if (holes.Equals("18"))
            {
                Assert.AreEqual(this.driver.FindElement(holeNavFinalHole18).Text.ToString(), holes);
            }
            else
            {
                Assert.AreEqual(this.driver.FindElement(holeNavFinalHole9).Text.ToString(), holes);
            }

            /* Asserting that left arrow is disabled */
            Console.WriteLine("Asserting left Arrow disabled");
            Assert.AreEqual(HasClass(this.driver.FindElement(holeScrollerArrowLEFT), "disableLeftHoleArrowButton"), "disableLeftHoleArrowButton");

            /* Asserting Hole Scroller Number */
            string actualValueScroller = this.driver.FindElement(holeScrollerHOLE).Text.ToString();
            Console.WriteLine("Asserting Hole Scroller Value");
            Assert.AreEqual(actualValueScroller, "◀   Hole 1   ▶");

            /* Asserting last played hole */
            Console.WriteLine("Asserting last played hole value");
            Assert.AreEqual(this.driver.FindElement(lastPlayedHole).Text.ToString(), "1");

            /* Asserting players names */
            for (int i = 0; i < listOfPlayerByCssSelector.Count; i++)
            {
                string actualPlayerName = this.driver.FindElement(listOfPlayerByCssSelector[i]).Text.ToString();
                string expectedPlayerName = listOfPlayers[i];
                Console.WriteLine("Asserting Player Name, No: " + i.ToString());
                Assert.AreEqual(actualPlayerName, expectedPlayerName);
            }
        }

        /* Private Methods */
        private string HasClass(IWebElement element, string className)
        {
            string classes = element.GetAttribute("class");
            foreach (string s in classes.Split(' ')){
                if (s.Equals(className))
                {
                    return className;
                }
            }
            return "";
        }
    }
}
