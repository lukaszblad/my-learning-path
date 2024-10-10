# ASTRONAUT

## DESCRIPTION
"Astronaut" is a 2d pixel-art game, developed using the LOVE framework of the Lua programming language.

## GAMEPLAY
The gameplay consists of flying through an asteroid field, to collect raw plutonium, needed as fuel for the spacecraft, which has run dry.
The main challenge of the game is to avoid the asteroids with a control system that simulates the absence of gravity.
In addition to asteroids, the absence of oxygen can also end the game. Both oxygen and health can be restored by collecting powerups.
Game progress is visible in the green bar at the top, which indicates how much plutonium has been collected. There are two more bars, one for health (divided into segments) and one to indicate oxygen level

## CONTROLS
To advance in the menus it is only necessary to press space
To exit the game completely, press the escape key
In game it will be necessary to use the arrows to control the direction in which the astronaut will move

## DEVELOPMENT
### OOP
To maintain order and make the code more easily editable, each element is created through a class.
Since movement on the x-axis is only possible in one direction, objects that have negative coordinates are immediately removed, to avoid an overflow <br>

### State Machine
Furthermore, the game is divided into different states (objects themselves), managed through a state machine, which calls the necessary state through a table that contains all the states and functions that initialize them.
The states are the title state, intro state, game state, game over state and outro state. the change of state is handled in the update functions. <br>

### Movement
Movement in the game is based on the background scrolling on both axes.
A looping point is set, which creates the illusion of boundless movement. <br>

Obstacles and powerups have random directions and movement speeds and when the player presses a button, they move according to the background.

### Collisions
Collisions are calculated at each frame, for each existing object. It is checked if the astronaut is present inside the hitbox of the object.
The collisions for meteorites and power ups are very similar, the only difference is the 2px tolerance for meteorites, in order to not make the game too frustrating for the player.

### Assets
The meteorites are randomly generated starting from a table containing about ten sprites.
Each meteorite spawns also above and below the visible screen so as not to create empty areas when the player moves up or down. <br>

Powerups are generated similarly but more sporadically than meteorites. Also hitting them will not cause damage but will give benefits to the player. <br>

## GRAPHICS and SOUNDS
The graphics try to be minimalistic, almost totally in black and white. Only the power ups are colored, to create a little variety and to make it easier for the player to identify them. <br>

Along with the graphics, the soundtrack is also minimalistic, to create a sense of dispersion and immense space.
Only spatial white noise is heard in the background. There are also sounds to make the damage and power up collection more impactful.

## PREVIEW
A little demonstration can be seen on [YouTube](https://youtu.be/d_vTHIkpNtg)
