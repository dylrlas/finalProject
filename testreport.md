
# Escape from Ruins final Project Test Report:

## 1.) Component Testing:

   * Game logic controller : the user functions that I had tested which were programmed in the visual Studio C# scripts include updating the position after user clicks the left-mouse button down, implementing game over message after the angel dies by falling to the ground, keeping track of how many pipes the user jumps through without colliding with another object, and controlling randomization of pipes that spawn in different locations. 

   * List of primary components that are tested in the game: 
      
      ### a.) Game Rules :
       * This is the core submodule of the game logic controller which interfaces with all of the other submodules, instructing them what to do based on the game rules. The rules are implemented by the updated position of bird from the keyboard, and the current position of the rows of pipes. Appropriate audio is chosen corresponding to the rules (game over message at the time player dies during gameplay).
       
       
       ### b.) Sprite generator:
       *  Column orientation: This	 submodule	keeps	updating	 the	X	coordinates	of	 the	pillars	 that	has	already appeared	on	the	screen	(by	decrementing	them	in	every	cycle),	as	well	as	the	length	of	the upcoming	pillar	 that	is	going	 to	appear	 from	 the	right	side	of	 the	screen	 (which	is	actually the	number	of	"partial"	pillars	that	stack).	The	length	of	the	pillar	should	be	random,	as	long as	the	distance	between	the	pillars	is	constant.	Once	the	sprite	moves	out	of	the	screen	(in this	case,	x	coordinate	of	any	one	of	the	pillars	becomes	zero),	we	reset	the	coordinate	so that	it	can	reappear	from	the	right	side	of	the	screen.


        * Angel avatar: Our angel protagonist acts like the bird in flappy bird where flaps and falls will be affect by the gravity. When we implement the object motion formula in our code, time calculation is an issue that we use a counter counting instead of using system clock. I put the delay in our loop and try asuitable count number being our time unit. In addition, I added a status variable to indicate if the angel status is rising or falling. It cooperates with the jumping and falling function with iteration loop supporting continuous jumping without multi-thread.


        ### c.) totalScore: 
       * Every time the bird passes one of the pillars, the "Game Rules" submodule sends a signal, which will make the score increment by 1. Since the sprite for displaying the score is separated into a UI text field, we need to extract them from the score before sending them to the Unity 2D game scene.





## 2.) System Testing:
 * a.) This	 module	 generates	 the	 box collider	 signals	 needed	 by	 the	 Unity interface	and	also consecutive	score value that	is	used	in	Sprite game	controller C# script that controls the total of how many pipes user has jumped through.

   
 * b.) Based on the control signal received from the software, thesprite controller decides which sprites should be displayed and where they should be. Then sprite controller gets the data from the imported sprite .PNG images and sends the RGB values of each pixel to the Unity interface, shades of each sprite are subject to be modified using the coloring editor within the . The inputs tested for the sprite controller are the following: 
      * Functionality for input in sprite controller:
      * Angel position
      *  Column position
      *  Game start functionality
      *  Game over message
      *  totalScore in a single player run


* c.) System layers that are tested:
    * Background layer has lowest priority
    * Pipe layer comes next in priority level
     * Score layer comes after pipe layer in priority layer
     * Angel avatar is the topmost layer within priority queue

     * Another problem about Unity 2D is that the data should be updated at the vertical blanking time when the screen scanning reach to the area out of the screen. Other wise, if the data is changed during the scanning of the visible area of screen, the screen may be a little distorted. To avoid the distortion, the value of data is only updated when the vertical scanning is beyond the active region.





## 3.) Acceptance Testing:
   ### Users are able to denote that the following key functions/elements of the game project indeed work properly by utilization of thorough testing cases:
      
  ## User Story 1 Game Format :
  * Sprite	 controller	 and	 Unity 2D  program	 framework	 completed.	 Game	 picture	includes	background	and	angel	complete scene.

   ## User Story 2 Designated Changes Applying to Modifed Scope of Project:
   * Continue manual user-friendly	sprite	control	in	hardware. Complete	 game design	 and simple program	 for	 game	 logic	 including	 bird	 movement,	column	generation	and	boundary	condition.

   ## User Story 3: Unique Details/Features of Software Application: 
   * Added enemies to make game objective more challenging for the player rather than boring to play as well as more unique from a user perspective. No audio added because of time constraints and also intended to be created so that this PC platform game is not interpreted as a copy of the original flappy bird game. 

   ## User Story 4: Refinement of work on each scripted functionality
   * Side scrolling background works without error, where the player thinks they are moving the angel but angel only ahs functionality of moving up and down. The wallpaper background is moving through a C# script at a very moderate but slow pace. 

   ## User Story 5: Intuitive UI
   * Gravity components work where the user avatar hits ground level and does not suddenly disappear by falling through the "scene floor" nor flapping all the way up to where the angel is not visible to the player's eye anymore.

   ## User Story 5: Intuitive UI
   * No libraries necessary for testing this project through Unity2D C# program scripts, except using UnityEngine.UI and using Collections predecessors located in the headers of each script implemented into project.

  
  # User Stories listed by title pertaining to EscapeFromRuins project: 
   ### 1.) Game Format (completely implemented)
   ### 2.) Enables designated changes and communication of these changes to the modified scope of project (partially implemented)
   ### 3.) Unique details (partially implemented)
   ### 4.) Refinement of work on each functionality (partially implemented only on specific functionalities)
   ### 5.) Intuitive UI (completely implemented)
