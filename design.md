## Pipe and Filter Arch. Diagram of Escape from Ruins of the Underworld :
-Cause and effect relationship:
   * Filters apply local transformations to their input streams and does incremental programming so that game design is output before all input functionality is consumed.
   * * Pipes serve as connectors for each method in the diagram below, transmitting different functionalities to each other  so that the game can work as a whole unit (e.g if a player jumps through a set of pipes, then total score will be incremented by 1).
  * User hits ground, angelDied() is called
  * User makes contact with an upper level or lower level pipe, angelDied() is called
  * User gets hit by an enemy fireball, angelDied() is called
  * Import coded animation to make it look like the angel is actually dead and not standing on the ground stiff as a board in an awkward upright position
  

                                                                                         flow of data
                                                                          ----------------------------------------
                                                                         |                                       |
                                                                         |                                       |
                                                                         |                                       |
                                                                         |          flow of data                 V
                                                                   ## Main      ---------------------->       ## Server  
                                                                   { startGame()                            { CreateAreaforGame
                                                                    RenderDisplay()}
                                                                          |                                 CoordsforAngel (x, y)
                                                                          |
                                                                          |                                 RandomizePlacementOfPipe
                                                                          |
                                                                          |                                  StartGame()*
                                                                          |
                                                                          |                                  death }
                                                                          |  
                                                                          |
                                                                          |     flow of data
                                                                          |------------------------------------------------------------------- |
                                                                          |                                                                    |   method called
                                                                          |                                                                    | ------------|
                                                                          |                                                                                  |
                   subclass                                               |                                                                                  |
       ##Angel <-------------------------------                           |------------------------------------------------------------------                |
    { Import Angel (player)                   |                           |                                                                 |                | 
     DimensionsofAngel                        |                           |                                                                 |                |
    Import Devils' minions(enemy)             |                           |                                                                 |                |
    Velocity                                  |                           |   method call                                                   |                |
    Gravity/Physics (components)}             |                           |                                                                 |                |
                                              |                           |                                                                 |                |
                                              |                           V                                                                 |                |
                                              |--------------------> ##GamePlay()                                                           |                |
                                                                                                                                            |                |
                                                               {CreateAreaforGame                                                           |                |
                                                               CoordsforAngel (x, y)                                                        |                |
                                                              RandomizePlacementOfPipe                                                      |                |
                                                                countdown                                                                   |                |
                                                              NewAngelPos(AngelLocation);                                                   |                |
                                                                                                                                            |                |
                                                                  Death                                                                     |                |
                                                                 totalScore } -------------------------------------------------             |                |
                                                                                                                              |             V                |
                                                                                                                              |-------->##GameDisplay() <----|
                                                                                                                                  
                                                                                                                                        { BackgroundImage
                                                                                                                                     ImportPipes(randomPos)
                                                                                                                                     ImportSprites(spriteLocation)
                                                                                                                                     RenderDisplay() }
         
         
         
         
         
       # Text Explanation for Escape from Ruins Project implementation:
           
           # Angel
           * Added gravity components to the angel so that it has features of moving up and down whenever the user left clicks on the mouse so that the character can dodge                     incoming obstacles
           * Generates speed for the angel to move forward at within a given timespan as well as starting the character at the same position in the grid layout of Unity 2D each               time after the game is restarted by the user
           
           # GamePlay()
           * Responsible for in-game functionalities such as randomizing where the pipes appear within the game scene, keeping track of total score earned by user in a single                 run, and counting down from 3 in each instance where the game is either launched or restarted.
           * Creates area for gameplay which basically sidescrolls forward along with main camera in Unity2D, so that the background image actually moves with respect to the angel avatar, making it look like the angel is moving forward when in reality it just "flaps" up and down; intital starting position for the character is at (0,0,0).
           
           # GameDisplay
           * Responsible for art visualization in the project
           * Basically all this method will do is to display the background image, pipes at randomized location (not responsible for WHERE the pipes are placed in game scene), angel/enemy sprites that are imported into the project, as well as displaying the overall image during gameplay

           #main()
           * functionality in this main method will allow the user to start the game whenever it is launched from a PC-compatible device
           * 
           
           
           # Server
            * This user-friendly type of functionality is only meant to pertain to a single player level, instead of multiplayer, so that only one player is allowed to play a game with one character sprite - dodging enemies and pipes as they try to escape from the ruins of the underworld.
            * Initially calls all method prototypes depicted in the arch. diagram in a specific order (listed above) so that the program can function properly and meet all user expectations of how the game is  supposed to implemented by the developers. *(NO Multiplayer server implemented in this project)*



       # Design/Documentation for Escape from Ruins Scaled-Back Project:
       
       ## I.) Overall Project Goal:
            * The goal of this project will be to create a simple PC verison however where the user clicks the left-mouse button to fly upward instead of tapping anywhere on the screen. The game is a side-scroller where the player controls a angel, attempting to fly between rows of red pipes without coming into contact with them. If the player touches the pipes or gets hit by an enemy fireball, it ends the game. The angel briefly "flies" upward each time the player uses left button on mouse; ; if the left mouse button is not clicked, the angel falls due to gravity and "dies". This game should be entertaining, fun, and performing all correct user functionalities that do not create any fatal errors which would result in the termination of the program.


       ## II.) Risks/Constraints/Assumptions:
             * Technical Constraints :
                 - Costs lots of time but not too many resources; heavy schedule relating to other schoolwork/ exams that I need to spend time doing or
                  studying for; not seeking financial gain- only a school project
                 - Maintenance performance and debugging in order to improve design implementation as well as algorithm efficiency
            * Functional Requirements :
                - User should be able to control how high the angel goes related to how fast or how many repetitions the user clicks the left-mouse
                   button in a certain amount of alotted time
                 - Total of how many pipes the customer has jumped through in order to help the user keep track of their score as soon as the main game
                    application is launched from the embedded UI system
           * Quality Attributes :
                  - Reliablity, usability, security, and strongly efficient performance that contains no error crashes nor glitched artwork frames whenever
                     the game is launched
                   - Response measure must be efficient in a quick time frame that detects faults to repair in the coded software, where the IDE is normally
                     operational and physically infrastructured by notifying any appropriate entities to fix the source of events causing each fault.
                     
         
       ## III.) Primary Objectives of Game Functionality/Design Implementation :
         
                   * Game over message which states that the angel died in some way (either by fireball, touching pipe, or falling to the ground)
                   * Score to keep track of how many pipes the player has jumped through
                   * Possible countdown feature to give the time to get ready to start jumping through those pipes and play the game
                   * The player must navigate through the underworld and jump between pipes in various positions in order to feel good about their own skills in a meaningless                        aspect of life
                   * No main menu feature; the game will automatically start once I open the application.
                  *  Exit button may be potentially available if the user wishes to quit early (although not really necessary) ; restart button functionality required however
                  *  Enemies will randomly spawn and fly much like the angel in front of the player (no they won’t have to avoid pipes like you) and shoot fireballs at the         angel. It is the gamer’s job to avoid getting hit by these as well otherwise they have to start the restart the game again



        
       ## IV.)  Overview of User Requirements and General Project Requirements 
       
                     * 1.) Game Format : Having a game with simple rules and mechanics would be ideal for beginning and intermediate players and allow everyone to enjoy the game, without requiring extensive research to understand rules and strategy.
                     
                     * 2.) Enables designated changes:  In this context, the angel who sholuld have wings should not crash to the ground whenever he does not crash into a pipe   or gets hit by a fireball. Changes should be additionally made if an original idea on a specific feature of the game needs to be modified in order to fit in the overall scope of the project.
                     * 3.) Unique features in custom-made project: Adding enemies who shoot fireballs is a classic example of something that is not in the game of Flappy Bird that the developer should plan to implement into his own game design to make it more unique and not just a "copy" of a game that was once famous and addictive. 

                     * 4.) Refinement of work on each game design functionality: It can be frustrating for people who have played the game "Flappy Bird" before if their avatar flies through a pipe without failing the game or if there is no audio synced to the game's UI system that can help keep the player entertained and not just bored with the potential bitter disappointment that they had wished for.


                     *5.)  Intuitive UI:  A user should be able to click the mouse to decide which level they will "hover" on and whenever the avatar makes contact with a pipe, then they should automatically fall to the ground and lose the game. 
                                          
                                          
                                          


