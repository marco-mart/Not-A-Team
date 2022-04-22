# Component Testing
Component Testing was made very easy using Git. The way we had the project set up (having a repo that every team member could access and have a complete individual copy of the system) meant that while a new feature was being developed, if that feature did not pass the acceptance test, (mentioned later), that feature would not be implemented in the system. (For example, when implementing a new feature, such as John Smith's movement when the user presses the left/right arrow keys, we would add the feature to the system (on a seperate branch that wasn't main) and if the feature did not interact with the system as it was intended to, the feature would not be added to the system (which was made very simple using Git and braching), and it would not be accepted as complete. 

# System Testing
Testing with Unity is very straighforward/simple. Unity has a play button that will start/run the game as a whole. This makes testing the system very easy. When a new feature is added, (to a previously assumed errorless system) and errors/unwanted behaviors arise, it is easy to see that something is wrong or is not behaving as you'd want it to be because you can visually see the error happening in front of your eyes. Again, using the example of John Smith's movement based on the wasd/array keys, if the tester is pressing the left key and John Smith is not moving left on screen, then we know that the feature is not complete. The choice to test our system in this way was the right one because we are directly testing the most current version of the product that the users will be interacting with.

# Acceptance Testing
We judged the completeness of a feature based on the acceptance test that was created beforehand in the user story that the feature was based on. (Continuing with the  example of John Smith's movement based on the left/right and wasd keys) In this example an acceptance test for this feature would consist of more or less the following: "John walks left when the left/a key is pressed and he moves right when the right/d key is pressed", etc... etc...) The user stories made it very easy to test new features because the acceptance test was made beforehand and this way we couldn't cheat and say that a new feature was done/complete if it did not do what the feature was intended to do beforehand/what it was envisioned to be.


User Stories
------------
1. As a user, I want to be able to see and move around as John Smith, so that I can play the game as John Smith. 

Complete

2. As a user, I want the camera to follow John Smith, so that I can further explore the level.

Complete

3. As a user, I want to be able to fight enemies as John Smith, so that I make progress through the level.

Incomplete

4. As a user, I want to be able to jump over obstacles and traps, so that I make progress through the level.

Incomplete

5. As a user, I want a starting menu, so that I can get a nice first impression of the game.

Complete

6. As a user, I want a pause menu, so that I can take breaks from playing the game.

Complete

7. As a user, I want to hear a funny voice come from John Smith when doing some action, so that I can laugh (or be annoyed) when playing the game.

Incomplete

8. As a user, I want to use weapons to attack enemies to make progress through the level.

Incomplete

9. As a user, I want to be able to restart the level at any given point in case I mess up.

Complete

10. As a user, I want to be able to quit and stop playing when I get frustrated.

Complete
