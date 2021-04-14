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
      ## Angel <-------------------------------                           |------------------------------------------------------------------                |
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
         
         
         ## Text Explanation for Rscape from Ruins project implementation
           
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



       ## 
                                          
                                          
                                          


