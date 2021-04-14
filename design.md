## Pipe and Filter Arch. Diagram of Escape from Ruins of the Underworld :

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

            # 
                                          
                                          
                                          


