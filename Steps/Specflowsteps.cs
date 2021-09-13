using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlow.Assist.Dynamic;

namespace Specflowintro.Steps
{
    [Binding]
    class Specflowsteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numbers)
        {
            Console.WriteLine(numbers); 
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Pressed Add Button");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            if(result == 120)//Grab the objec which has the value 120 in the UI of your real application
                Console.WriteLine("The test passed.");
            else
            {
                Console.WriteLine("The test failed.");
                throw new Exception("The value is different than the expected value of 120.");
            }
                
        }
        [When(@"I fill all the mandatory details in the form")]
        public void WhenIFillAllTheMandatoryDetailsInTheForm(Table table)
        {
            //var details = table.CreateSet<EmployeeDetails>();

            //foreach(EmployeeDetails emp in details)

            //{

            //    Console.WriteLine("The details of employee " +emp.Name);
            //    Console.WriteLine("*******************************");
            //    Console.WriteLine(emp.Name);
            //    Console.WriteLine(emp.Age);
            //    Console.WriteLine(emp.Email);
            //    Console.WriteLine(emp.Phone);

            //}

            //Work with Dynamic Assist
            var details = table.CreateDynamicSet();

            foreach (var emp in details)
            {
                Console.WriteLine("The details of employee " + emp.Name);
                Console.WriteLine("*******************************");
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.Email);
                Console.WriteLine(emp.Phone);
            }

        }

        [When(@"I fill all the mandatory details in the form (.*), (.*) and (.*)")]
        public void WhenIFillAllTheMandatoryDetailsInTheFormWoodrowAnd(string name, int age, Int64 Phone)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Phone: " + Phone);

        }

        

    }
}
