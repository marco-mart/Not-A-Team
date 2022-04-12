# Requirements Specification for *John Smith*

## Introduction

### 1.1 Purpose of Product

John Smith is a 2d platformer that tells the story about a man named John Smith who has found himself trapped in a video game. In this endeavor, he finds himself having to fight off enemies who are trying to keep him in the game world. Brussels Sprouts, the IRS, and paperwork, are a few mentionable enemies that he encounters. This requirements specification will describe what "John Smith" will do and how it will perform. We, here at Not A Team, hope that you find it helpful. 


### 1.2 Scope of Product

In *John Smith*, you will play as John Smith. This includes being able to jump, run, wall jump, and use weapons. These abilities are needed to be able to get through the levels, which include enemies, obstacles, and traps. The player will be able to see their lives, collectables, weapon status, and other information necessary on the screen. 

  
### 1.3 Acronyms, Abbreviations, Definitions 

2d: two dimensions. (Think of just the x-y plane ie. Cartesian plane, or a flat surface) 

Platformer: a game in which you jump platform to platform using a character. 

C#: a programming language. 


## General Description of Product 
  
### 2.1 Context of Product 

We will build the game using the Unity platform. We will use Audacity to record the voice of John Smith. We will use Adobe to create artwork for the game, including sprites and user interfaces. However, Unity will be the glue that puts all these things together.


### 2.2 Domain Model with Description 

Domain Model: [Domain Model](DomainModel.png)

This is our domain model for now. We still need to implement a weapons system, and the code needed for the other enemies.
Our domain model will start with our ideas and then learn and implement the syntax.  Next, we will then put the program together, then start testing our game for any bugs. 

Once our bugs have been fixed and our software is fully operational, we will be finished. 


### 2.3 Product Functions

We have never made a video game before, so it is hard to promise things that we are not sure we can keep. But we do like hypotheticals. 

*John Smith* will have many playable levels. These levels are the jungle, an office building, the desert, and whatever else wacky level we can think of. The main one that we will focus on is the office building. These levels will be full of obstacles, traps, and enemies that John Smith (you) will have to navigate (or slash) through. As John Smith, you will be able to stomp on enenmies, who will be programmed to kill John Smith/hinder him on his journey through the level.


### 2.4 User Characteristics and Expectations 

Our users are anyone who wants to have a laugh or are just plainly interested in what *John Smith* entails.


### 2.5 Assumptions and Dependencies 

Our game is designed only for Windows OS. 


## Functional Requirements 

Functional requirements we will meet are that the player be able to engage in gameplay along with interacting with the game world and its content. 

Players shall also be able to save their progress in the game, this is also a functional requirement that will be met. 

User Stories: [User Stories](userstories.md)  


## System and Non-functional Requirements 

Non-functional requirements for our software will be its reliability, security, usability and especially interoperability and compatibility. 


### 4.1 External Interface Requirements (User,Hardware,Software,Communications) 

The user should have a Microsoft Windows 10 operating system. Most hardware should be able to run our program.
John Smith has a menu interface that the user can use to change the volume settings, and start/pause the game. 


### 4.2 Performance Requirements 

Our product's performance should be pretty good on either a 32-bit or 64-bit Windows machine. There shouldn't be too much of a difference, considering the size of our game. Our product's performance needs will be low pertaining to hardware and operating systems.


### 4.3 Design Constraints 

Our biggest design constraints are that we are using Unity as the game engine, and Windows as our target OS, so we are limited to whatver these platforms provide. (Which is quite a bit.) However, considering our project's purpose/scope, these constraints are pretty much trivial. 

Regarding our architecture choice, the constraints on pur system is that all of the data must be of the same format. (Which again, for our system, is trivial and this constraint has not been a hinderance on creativity or system design at all.)

  
### 4.4 Quality Requirements 

Our quality requirements will be functional suitability, completeness, and appropriateness. Reliability and performance efficiency are also our quality requirements.
