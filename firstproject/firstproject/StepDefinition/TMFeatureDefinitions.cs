using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace firstproject.StepDefinition
{
    [Binding]
    public  class TMFeatureDefinitions
    {
        [Given(@"I logged up turnup portal successfully")]
        public void GivenILoggedUpTurnupPortalSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I navigate time and material page")]
        public void WhenINavigateTimeAndMaterialPage()
        {
            throw new PendingStepException();
        }
        [When(@"I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            throw new PendingStepException();
        }
        [Then(@"The record created sucessfully")]
        public void ThenTheRecordCreatedSucessfully()
        {
            throw new PendingStepException();
        }


    }
}
