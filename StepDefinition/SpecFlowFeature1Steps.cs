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
        private string players;
        private string holes;

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
            players = p0.ToString();
        }
        
        [Given(@"I select (.*) for the hole count")]
        public void GivenISelectForTheHoleCount(int p0)
        {
            index.SelectNumberOfHoles(p0);
            holes = p0.ToString();
        }

        [Given(@"I enter (.*) for name (.*)")]
        public void GivenIEnterForName(string p0, int p1)
        {
            index.EnterNames(p0, p1);
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
            index.AssertInitialPlayGameState(players, holes);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
