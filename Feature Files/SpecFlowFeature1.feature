Feature: SpecFlowFeature1
	Simple calculator for adding two numbers

@SmokeTest
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen 

	Scenario: Table
	#Given I have opned my application
	#Then I should see employee details page
	When I fill all the mandatory details in the form
	| Name    | Age | Phone      | Email                      |
	| Woodrow | 48  | 4783965151 | woodrowdeveloper@gmail.com |
	| Larry	  | 48	| 4783965151 | woodrowdeveloper@gmail.com |
	| John    | 48	| 4783965151 | woodrowdeveloper@gmail.com |
	| Brenda  | 48	| 4783965151 | woodrowdeveloper@gmail.com |
	| Lacie   | 48  | 4783965151 | woodrowdeveloper@gmail.com |
	| Lydia   | 48  | 4783965151 | woodrowdeveloper@gmail.com |
	#And I click the save button
	#Then I should see all the details saved in my application and the DB

	Scenario Outline: Create a new employee with mandatory details for different iteration
	#Given I have opned my application
	#Then I should see employee details page
	When I fill all the mandatory details in the form <Name>, <Age> and <Phone>
	#And I click the save button
	#Then I should see all the details saved in my application and the DB
	Examples: 
	| Name    | Age | Phone      | 
	| Woodrow | 48  | 4783965151 | 
	| Larry	  | 48	| 4783965151 | 
	| John    | 48	| 4783965151 | 
	| Brenda  | 48	| 4783965151 | 
	| Lacie   | 48  | 4783965151 | 
	| Lydia   | 48  | 4783965151 | 

	Scenario: Check if I could get the dtails enterd via table from Extended Steps
	When I fill all the mandatory details in the form
	| Name    | Age | Phone      | Email                      |
	| Woodrow | 48  | 4783965151 | woodrowdeveloper@gmail.com |
	Then I should get the same value from Extended steps