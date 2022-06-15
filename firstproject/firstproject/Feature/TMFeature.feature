Feature: TMFeature

A short summary of the feature
As a turnup portal launch
I will create edit and delete in time and material page
I can manage employee deatils such as create new employee edit and delete employee details sucessfully


Scenario: Create time and material deatils with valid details
	Given I logged up turnup portal successfully
	When I navigate time and material page
	And I create a new time and material record
	Then The record created sucessfully
