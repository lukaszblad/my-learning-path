# Timber50
In this retro-style arcade game, you play as a lumberjack, chopping down trees while avoiding branches. The game captures the addictive and simple gameplay of the original Timberman, featuring pixel art graphics and responsive controls. Tap left or right to chop, but be quick and precise to achieve high scores without getting hit by branches.

## Distinctiveness and Complexity
- Custom Graphics: Designed and created all game graphics from scratch, including characters, background, trees, and UI elements, ensuring a unique and cohesive visual identity.

- Advanced Collision Detection: Developed a robust system to detect collisions between the lumberjack and branches, enhancing the gameplay challenge.

- Built a comprehensive high scores system from the ground up, allowing players to save and track their best performances over multiple gameplay sessions.

## Development
A fundamental aspect of the game’s architecture was the use of a basic state machine. This design pattern was crucial for managing the game's various states efficiently, including the title screen, main menu, gameplay, game over screen, and high scores display. Each state was encapsulated in its own module, which allowed for clean, modular code that is easy to maintain and expand.

- TitleState: This initial state handles the game's introduction, displaying titles with smooth fade-in and fade-out effects. It sets the tone for the game and transitions seamlessly into the MenuState.

- MenuState: Implements a user interface that allows players to choose between starting the game, viewing high scores, or exiting. It features interactive elements and visual feedback to enhance the user experience.

- PlayState: Manages the core gameplay mechanics where the player chops the tree while avoiding branches. It includes dynamic updates for character movement, custom collision detection, and score tracking.

- GameOverState: Activated when the player fails to avoid a branch. This state displays the final score and provides options to restart the game or return to the main menu. It features a user interface designed to deliver a clear and immediate response to the player's performance.

- ScoresState: Allows players to visualize the highest saved scores. It displays a leaderboard with the top scores, ensuring that the data is presented in an accessible and engaging manner.

## Features to implement
- Varied Environments: Create multiple unique backgrounds and settings for the game, such as a forest, desert, snow-covered landscape, and urban park. Each scenario will have its own visual style and elements to enhance the diversity and replayability of the game.

- Character Selection: Design and introduce a range of playable characters, each with distinct appearances and animations. Players can choose their favorite character before starting the game.

- Purchasable Items: Develop a shop where players can spend their in-game currency on new characters, skins, power-ups, and cosmetic items. Ensure a variety of items to keep players engaged.

- Local Multiplayer: Implement a local multiplayer mode where two players can compete on the same device, taking turns to achieve the highest score.

## Gameplay
[![Timber50 Gameplay YouTube](https://img.youtube.com/vi/uK2yEr9cpQg/0.jpg)](https://www.youtube.com/watch?v=uK2yEr9cpQg) <br>
Youtube

## Credits
### Fonts
Jaro font: https://fontesk.com/jaro-font/ <br>
Fipps font: https://www.dafont.com/fipps.font <br>
Karma suture: https://www.1001freefonts.com/karma-suture.font <br>

### MusicŁ
Circus jingle loop by SergeyShred -- https://freesound.org/s/741150/ -- License: Attribution 4.0
