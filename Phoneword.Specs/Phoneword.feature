Feature: Getting translated alphanumeric phone numbers
	In order to call phone numbers which have letters in them
	As a smartphohne user
	I want the alphanumeric phone number to be translated

Scenario: Translate alphanumeric phone number
	Given I have entered "1-855-XAMARIN" into Phoneword
	When I press Translate
	Then the result should be "1-855-9262746"
