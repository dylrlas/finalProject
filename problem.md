## Problem Statement ##

### Summary ###
I will attempt to develop a game much like Flappy Bird, which is originally on
Android/iOS platform, into Unity using coded databases from C# scripts. This will be a PC verison however where the user clicks the left-mouse button to fly upward instead of tapping anywhere on the screen.
The game is a side-scroller where the player controls a angel, attempting to
fly between rows of red pipes without coming into contact with them. If
the player touches the pipes or gets hit by an enemy fireball, it ends
the game. The angel briefly "flies" upward each time the player uses left button on mouse;
; if the left mouse button is not clicked, the angel falls due to gravity and "dies".


### Game Rules and Mechanics ###
* The player must navigate through the underworld and jump between pipes in various positions in order to feel good about their own skill
* It is not known if I will implement a certain functionality that ends the game when the player reaches a certain amount of pipes and has not been hit once or if it will run until they take damage.
* No main menu feature; the game will automatically start once I open the application.
* Exit button may be potentially availbe if the user wishes to quit early (although not really necessary)
* Enemies will randomly spawn and fly much like the angel in front of the player (no they won't have to avoid pipes like you) and shoot fireballs at the angel. It is the gamer's job to avoid getting hit by these as well otherwise they have to start the game over




### Game Features ###
* Game over message which states that the angel died in some way
* Score to keep track of how many pipes the angel has jumped through
* Possible countdown feature to give the time to get ready to start jumping through those pipes and play the game


### Image moving ###
* Image moving is the most important function
needed to implement. Besides the background horizontal moving, the
vertical jumping combining clicking with the mouse is the second  most important challenge, as well as designing/importing artwork to make the game more visually appealing to the user.



### Milestone Goals ###
* a) Set up the architecture of the game including both hardware and
software and specify the modules for different functionalities;
* b) Develop basic modules for different functionalities;
* c) Integrate all the modules




