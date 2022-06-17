Feature: TMFeature

A short summary of the feature
As a turnup portal launch
I will create edit and delete in time and material page
I can manage employee deatils such as create new employee edit and delete employee details sucessfully

@Create
Scenario:1 Create time and material records with valid details
	Given I logged up turnup portal successfully
	When I navigate time and material page
	When I create a new time and material record
	Then The record created sucessfully
	@Edit
Scenario Outline:2 Edit the time and material records with valid credentials
   
   Given  I logged up turnup portal successfully
    When  I navigate time and material page
    When I update '<Description>', '<Code>','<Price>' on an existing time and material record
 Then The record should have updated '<Description>','<Code>',<price>'
 Examples: 
 | Description | Code    | Price  |
 | Laptop      | HP12    | $11.00 |
 | phone       | Samsung | $12.00 |
 
 @Delete
 Scenario Outline:3 Delete the existing time and material records successfully
 Given I logged up turnup portal successfully
 When I navigate time and material page
 When I Deleted the Existing records using '<code>'
 Then The record deleted Successfully
