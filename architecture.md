**Description **: Data flow Pattern (Chosen layout for architecture)

## Architecture is used when input data to be transformed into output data through a series of computational manipulative components.
**Pipes are used to transmit data from one component to the next.

**Each filter will work independently and is designed to take data input of a certain form and produces data output to the next filter of a specified form. The filters don’t require any knowledge of the working of neighboring filters.
**
The PC machine and the compatible server will independently run the game with the same start time and tap data sent back and forth through the server. For example, for the server once the game begins, the gravity starts and the angel will start falling, once the server receives a click from a player the server updates its instance of the game. This continues until die() is called when the player hits the ground, takes a hit from an enemy, or hits a pipe as they are "escaping".

## Reusability
## Re - used the familiar look of the UI in Unity 2D for the version of the game; this excludes a main menu but includes imported music to make the game more unique as well as in-game play. Actual physics of the game such as the angel hovering, and angel impact with the tube



## Arch. Diagram of Escape from Ruins of the Underworld**

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
    { Import Angel 9player)                   |                           |                                                                  |                | 
     DimensionsofAngel                        |                           |                                                                  |                |
    Importdevils(enemy)                       |                           |                                                                  |                |
    Velocity                                  |                           |   method call                                                    |                |
    Gravity/Physics (components)}             |                           |                                                                  |                |
                                              |                           |                                                                  |                |
                                              |                           V                                                                  |                |
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
                                                                                                                                     ImportSprites(spriteLocations)
  
                                                                                                                                           RenderDisplay() }
                                                                 
                                                                 
                                                                                                                                                  






          
