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
- The camera must follow John Smith. 
- Camera should keep John Smith at it's center at all times.


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

### Elaboration:
The user should be able to jump over obstacles and traps, occasionally getting caught in one and dying, so that the game isn't easy, and therefore more entertaining for the user. To do this we will need to create trap/obstacle objects and depending on the trap/obstacle, a script.

### Constraints
none

### Effort Estimation
10 person-hours

### Acceptance Test
- The obstacle/trap should deal some damage/kill John Smith when caught in it.
- John Smith should only be dealt damage/death when inside the trap.


# 5. "As a user, I want a starting menu, so that I can get a nice first impression of the game."

### Elaboration:
The first thing the user should see is a starting menu. The starting menu is very important to the aesthetic that we are trying to achieve with the game. The first impression the game leaves on the user should be memorable. Also, the start menu should have various options such as: start game, sound, options, etc...

### Constraints:
none

### Effort Estimation
3 person-hours

### Acceptance Test
- The start must be visually pleasing, and fit the game well. (i.e. the game is about a white collar man, so make it fit that style.)
- Pressing the start button should start the game and bring the user into the game.


# 6. "As a user, I want a pause menu, so that I can take breaks from playing the game, and changing the audio settings to fit my needs."

### Elaboration:
A user cannot play a game for long periods of time without needing to take some breaks. Also, life is unpredictable, so its more likely that the user will need to pause the game than not. Also, the user should have the option to restart the game, if the user is compelled to do so.

### Constraints:
none

### Effort Estimation
3 person-hours

### Acceptance Test
- The menu should freeze everything on screen.
- The feaures that the menu offers, when toggled should cause the desired effect. (i.e. when sound is turned off/on, or restarting the level.


# 7. "As a user, I want to hear a funny voice come from John Smith when doing some action, so that I can laugh (or be annoyed) when playing the game." (FUTURE WORK)

### Elaboration:
Hopefully the latter. This idea was introduced at the conception of the game. In getting this feature added, the level of entertainment that the game will have for the user will be increased.

### Constraints:
- Do not be cringe
- Do not be annoying

### Effort Estimation
3 person-hours

### Acceptance Test
- The voice/phrases should elcicit some form of laughter during testing. 
- The voice/phrase must come at opportune moments. (ex. When stomping on a brussels sprout)

# 8. "As a user, I want to use weapons to attack enemies to make progress through the level"

### Elaboration:
Weapons would be a secondary way for the player to damage enemies, but from a range, to be able to clear a path to the exit.

### Constraints:
- Would need to make seaparate animations
- Cannot make them too over-powered

### Effort Estimation
3 person-hours

### Acceptance Test
- The weapon must be visually and mechanically cohesive to the rest of the game

# 9. "As a user, I want to be able to restart the level at any given point in case I mess up."

### Elaboration:
With a single press of a button, or perhaps a clickable icon on the pause menu, the level should refresh and restart on command.

### Constraints:
- none

### Effort Estimation
3 person-hours

### Acceptance Test
- The player's status should revert to what it was before the level started.

# 10. "As a user, I want to be able to quit and stop playing when I get frustrated."

### Elaboration:
With a single press of a button, or perhaps a clickable icon on the pause menu, the level should end and you should be taken back to the main menu on command.

### Constraints:
- none

### Effort Estimation
3 person-hours

### Acceptance Test
- The main menu should function normally after the transition
- You should be able to pick up from the beginning of the last level you played.

