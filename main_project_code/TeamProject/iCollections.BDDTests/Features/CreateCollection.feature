﻿Feature: CreateCollection
	Creating A Collection 

	* As a user of this site with an account that is currently using the site, the user should not receive any cookie error messages from the web console available in their web browser. 
	* As a user of this site that is in the process of creating a collection, a tempdata cookie will appear, and then disposed of when the user continues using the site.
	* As a user of this site that is creating a collection, I want instructions for the accepted input for titles and descriptions, with clear error messages if I use an unaccepted character. 

Going through the process from logging in,  to publishing a newly made iCollection. 


Background:

	Given the following photos exist
	  | Id | Name           | Data               | UserId  | PhotoGuid  |
	  | 40 |  Photo Fish 1  | new byte[] {1,2,3} | 8       | new Guid() |
	  | 41 |  Photo Fish 2  | new byte[] {1,2,3} | 8       | new Guid() |
	  | 45 |  Photo Shoes 1 | new byte[] {1,2,3} | 3       | new Guid() |
	  | 48 |  Photo Dogs 1  | new byte[] {1,2,3} | 64      | new Guid() |
	  | 50 |  Photo Fish 3  | new byte[] {1,2,3} | 8       | new Guid() |
	  | 51 |  Photo Fish 4  | new byte[] {1,2,3} | 8       | new Guid() |
	  | 52 |  Photo Shoes 2 | new byte[] {1,2,3} | 3       | new Guid() |
	  | 53 |  Photo Dogs 2  | new byte[] {1,2,3} | 64      | new Guid() |
	  | 54 |  Photo Fish 5  | new byte[] {1,2,3} | 8       | new Guid() |
	  | 55 |  Photo Fish 6  | new byte[] {1,2,3} | 8       | new Guid() |
	  | 65 |  Photo Shoes 3 | new byte[] {1,2,3} | 3       | new Guid() |
	  | 66 |  Photo Dogs 3  | new byte[] {1,2,3} | 64      | new Guid() |
	  | 62 |  Photo Fish 7  | new byte[] {1,2,3} | 8       | new Guid() |
	  | 87 |  Photo Fish 8  | new byte[] {1,2,3} | 8       | new Guid() |
	  | 88 |  Photo Shoes 4 | new byte[] {1,2,3} | 3       | new Guid() |
	  | 89 |  Photo Dogs 4  | new byte[] {1,2,3} | 64      | new Guid() |
	  | 90 |  Photo Fish 9  | new byte[] {1,2,3} | 8       | new Guid() |
	  | 91 |  Photo Fish 10 | new byte[] {1,2,3} | 8       | new Guid() |
	  | 92 |  Photo Shoes 5 | new byte[] {1,2,3} | 3       | new Guid() |
	  | 93 |  Photo Dogs 5  | new byte[] {1,2,3} | 64      | new Guid() |
	
	And the following photos do not exist
	  | Id | Name              | Data               | UserId  | PhotoGuid  |
	  | 0  | First Photo Bad   | new byte[] {1,2,3} | 4       | new Guid() |
	  | -1 | Second Photo Bad  | new byte[] {1,2,3} | 8       | new Guid() |
	  | 16 | Third Photo Bad   | new byte[] {1,2,3} | 0       | new Guid() |
	  | 45 | Fourth Photo Bad  | 9001               | 64      | new Guid() |



Scenario Outline: Clicking on The Create Collection button in the nav bar will direct to the environment selection page.
	Given I am a logged in user with first name '<FirstName>'
	When I Click Create new Collection
	Then I am redirected to the '<Page>' page
	  And I can see the two differnt environment options for me to select 
	Examples:
	| FirstName | Page                 |
	| Talia     | EnvironmentSelection |
	| Zayden    | EnvironmentSelection |
	| Hareem    | EnvironmentSelection |
	| Krzysztof | EnvironmentSelection |


Scenario Outline: Non-user cannot click on The Create Collection button in the nav bar will direct to the environment selection page.
	Given I am a logged in user with first name '<FirstName>'
	When I Click Create new Collection
	Then I can see a 404 error message
	Examples:
	| FirstName |
	| Andre     |
	| Joanna    |
	| People    |
