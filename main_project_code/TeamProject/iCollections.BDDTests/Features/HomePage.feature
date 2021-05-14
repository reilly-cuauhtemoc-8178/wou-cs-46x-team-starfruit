﻿Feature: HomePage
	This is going to test the route functions, that take in a collection id, and return a list of rending photos
	That will be passed through the dom.


Background:

	
	Given the following collections exist
	  | Id | Name                       | Visibility | UserId | Route               |
	  | 10 | First Collection Fish      | 1          | 8      | Ocean_environment   |
	  | 13 | Second Collection Dogs     | 1          | 64     | gallery_environment |
	  | 16 | Third Collection Shoes     | 1          | 3      | Ocean_environment   |
	  | 45 | Forth Collection Puzzels   | 1          | 3      | gallery_environment |
	
	
	And the following collections do not exist
	  | Id | Name                       | Visibility | UserId | Route               |
	  | 0  | Bad Collection 1           | 1          | 8      | Ocean_environment   |
	  | 11 | Worse Collection 2         | 1          | 0      | gallery_environment |
	  | 15 | HORRIBLE Collection 3      | 1          | 3      | IMLOST!             |
	  | $0 | DICKSDICKSDIC Collection 4 | 9001       | 666    | WTFisHAPPENING!!!1! |

	
	Given the following photos exist
	  | Id | Name                | Data               | UserId  | PhotoGuid  |
	  | 40 | First Photo Fish    | new byte[] {1,2,3} | 8       | new Guid() |
	  | 41 | Second Photo Fish   | new byte[] {1,2,3} | 8       | new Guid() |
	  | 45 | Third Photo Shoes   | new byte[] {1,2,3} | 3       | new Guid() |
	  | 48 | Fourth Photo Dogs   | new byte[] {1,2,3} | 64      | new Guid() |
	
	
	And the following photos do not exist
	  | Id | Name              | Data               | UserId  | PhotoGuid  |
	  | 0  | First Photo Bad   | new byte[] {1,2,3} | 4       | new Guid() |
	  | -1 | Second Photo Bad  | new byte[] {1,2,3} | 8       | new Guid() |
	  | 16 | Third Photo Bad   | new byte[] {1,2,3} | 0       | new Guid() |
	  | 45 | Fourth Photo Bad  | 9001               | 64      | new Guid() |

	
	Given the following collectionPhotos exist
	  | Id | CollectId | PhotoId  | PhotoRank | Title              | Description   |
	  | 80 | 10        | 40       | 2         | Second Photo Fish  | Description1  |
	  | 81 | 10        | 41       | 1         | First Photo Fish   | Description2  |
	  | 82 | 13        | 45       | 1         | Third Photo Shoes  | Description3  |
	  | 83 | 16        | 48       | 1         | Fourth Photo Dogs  | Description4  |
	
	
	And the following collectionPhotos do not exist
	  | Id | CollectId | PhotoId  | PhotoRank | Title              | Description   |
	  | 80 | 10        | 40       | 2         | Second Photo Fish  | Description1  |
	  | 81 | 10        | 41       | 1         | First Photo Fish   | Description2  |
	  | 82 | 13        | 45       | 1         | Third Photo Shoes  | Description3  |
	  | 83 | 16        | 48       | 1         | Fourth Photo Dogs  | Description4  |


@ignore
Scenario Outline: Clicking on the Preview Button for the Ocean Environment on the HomePage will redirect to the sample ocean environment page.
	Given I am on the Home Page
	When I Click Preview Ocean Environment
	Then I am redirected to the '<Page>' page
	  And I can see the ocean environment preview with its title 
	Examples:
     | Page              |
     | Ocean_environment |
     | Ocean_environment |
     | Ocean_environment |
     | Ocean_environment |


@ignore
Scenario Outline: Clicking on the Preview Button for the Gallery Environment on the HomePage will redirect to the sample gallery environment page.
	Given I am on the Home Page
	When I Click Preview Gallery Environment
	Then I am redirected to the '<Page>' page
	  And I can see the gallery environment preview with its title 
	Examples:
     | Page                |
     | gallery_environment |
     | gallery_environment |
     | gallery_environment |
     | gallery_environment |

