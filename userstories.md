# 1. *As a user, I want to be able to see and move around as John Smith, so that I can play the game as John Smith.*

### Elaboration: 
The user should have the ability to move around as John Smith in the game. Unity has a default pill-shaped (or you can choose a shape of your own) object that we can use until we get the animation/sprite for John Smith up and running. We can then use C# to write a script for the object that will take keyboard input that will control the pill's movements. 

### Constraints: 
none

### Effort Estimation:
10 person-hours

### Acceptance Test: 
- Be able to move left and right as John Smith
- Be able to jump as John Smith
- Sprites/Animations are in sync with what is happening (ie. turns left when switching running direction from right and vice-versa, jump action is synced with jump animation, etc...).


# 2. *As a user, I want the camera to follow John Smith, so that I can further explore the level.*

### Elaboration:
The user, playing as John Smith, should be able to see John Smith on screen at all times. Unity has various pre-made camera components that we can choose from to make this happen.

### Constraints:
none

### Effort Estimation:
1 person-hour

## Acceptance Test:
- As you move around as John Smith on the screen, the camera must follow John Smith, and keep him centered at all times.


# 3. *As a user, I want to be able to fight enemies as John Smith, so that I make progress through the level.*

### Elaboration:
The user should be able to fight and kill enemies in the level so that the game has objectives and is not boring to the player. We will need do the same process we did in the creation for John Smith, but this time for various enemies. The enemies will have their own scripts and animations so we will need to get those synced up as well. 

### Constraints:
none

### Effort Estimation:
10 person-hours

### Acceptance Test:
- The enemies should attack/follow John Smith.
- The enemies actions (moving left/right etc...) should be synced up with their animation/sprite.


# 4. *As a user, I want to be able to jump over obstacles and traps, so that I make progress through the level.*

