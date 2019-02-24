using System;
using TechTalk.SpecFlow;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace deskyteskresking
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private IWebDriver driver;

        private Pages.Index index;

        /* Constructor */
        public SpecFlowFeature1Steps()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            index = new Pages.Index(driver);
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            // Do Things ...
        }

        [Given(@"I am on the ReskyDeskTesking Web Application")]
        public void GivenIAmOnTheReskyDeskTeskingWebApplication()
        {
            index.GoToWebsite("https://kodawarii.github.io/reskydesktesking/");
        }
        
        [Given(@"I select (.*) for the amount of players")]
        public void GivenISelectForTheAmountOfPlayers(int p0)
        {
            index.SelectNumberOfPlayer(p0);
        }
        
        [Given(@"I select (.*) for the hole count")]
        public void GivenISelectForTheHoleCount(int p0)
        {
            index.SelectNumberOfHoles(p0);
        }

        [Given(@"I enter (.*)")]
        public void GivenIEnter(string p0)
        {
            index.EnterNames(p0, 1);
        }

        [Given(@"I also enter (.*)")]
        public void GivenIAlsoEnter(string p0)
        {
            index.EnterNames(p0, 2);
        }

        [When(@"I press start game")]
        public void WhenIPressStartGame()
        {
            index.StartGame();
        }
        
        [Then(@"I should be on the PlayStage")]
        public void ThenIShouldBeOnThePlayStage()
        {
            // Call Assert Function on Page
            index.AssertPlayGameState();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
