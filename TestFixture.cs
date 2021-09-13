using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Specflowintro
{
    [Binding]
    public class TestFixture
    {
        [BeforeFeature]
        public static void BeforeEachFeature()
        {

            Console.WriteLine("Calling before each feature.");
        }
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario

            Console.WriteLine("Calling before each scenario.");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario

            Console.WriteLine("Calling after each scenario.");
        }
    }
}
