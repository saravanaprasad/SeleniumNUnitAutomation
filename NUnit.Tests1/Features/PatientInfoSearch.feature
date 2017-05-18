Feature: PatientInfoSearch


@mytag
Scenario: SearchInfo
	Given I have logged into my Patient Account using my credentials 
	| Username                       | Password  | url                  |
	| saravana.prasad@emishealth.com | Emistest1 | https://patient.info |
	And I search for the item 17 - 29 years (young adult)
	When I press add
	Then the result should be 120 on the screen
