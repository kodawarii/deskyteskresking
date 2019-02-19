using System;
using TechTalk.SpecFlow;

namespace deskyteskresking.StepDefinition
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I am on the ReskyDeskTesking Web Application")]
        public void GivenIAmOnTheReskyDeskTeskingWebApplication()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select (.*) for the amount of players")]
        public void GivenISelectForTheAmountOfPlayers(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select (.*) for the hole count")]
        public void GivenISelectForTheHoleCount(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I enter (.*)")]
        public void GivenIEnter(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I also enter (.*)")]
        public void GivenIAlsoEnter(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press start game")]
        public void WhenIPressStartGame()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be on the PlayStage")]
        public void ThenIShouldBeOnThePlayStage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
