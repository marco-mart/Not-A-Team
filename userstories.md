
Functional Requirements: User Stories

You will capture the functional requirements of your system in user stories, a popular agile method for documenting and writing down system functionality. Each user story must have a number and title and then have its main story statement in the form of:

As a role I/we want to capability so that goal.

It also must have an elaboration and constraint description, and it must have an effort estimation using person-hours. The story ID number must be a dotted hierarchical number indicating which larger stories are its parents (if any). It also must have an acceptance test description, which should be a short description of how you will validate that this story was successfully implemented.

NOTE: these are user stories, not developer stories! You (as a developer) are not a user!

An example (for some business team management app):
3.6: Export to CSV

As a manager, I want to export my team's timesheet data to a CSV file so that I can use it in a spreadsheet or write a script to do my own processing.

Elaboration: Users should have the ability to use their data for purposes outside our system, and so we need to support a data export capability; since the CSV (comma-separated-values) file format is fairly common, we will use it as our export format.

Constraints: none

Effort Estimation: 2 person-hours

Acceptance Test: Perform export operation in user interface on demo data and import the resulting CSV file into OpenOffice Calc and Microsoft Excel. Show that both apps import the CSV properly. Perform export on a set of demo data, on data containing 1 element, and on an empty data set.

[end example]

The number of the above story, 3.6, indicating it is user story 6 within top-level story 3. What is story 3? Perhaps it's is:
3: Integrate with other tools

As a manager, I want to integrate this system with other tools I use so that my overall workflow is seamless.

[rest of story parts would be here]

As you can see, higher level user stories can be very abstract and not much help in figuring out your system, but they can then be broken down into pieces that finally tell you what you need to do!

