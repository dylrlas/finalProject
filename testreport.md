
# Escape from Ruins final Project Test Report:

## 1.) Component Testing:

   * Game logic controller : the user functions that I had tested which were programmed in the visual Studio C# scripts include updating the position after user clicks the left-mouse button down, implementing game over message after the angel dies by falling to the ground, keeping track of how many pipes the user jumps through without colliding with another object, and controlling randomization of pipes that spawn in different locations. 

   * List of primary components that are tested in the game: 
      
      ### a.) Game Rules :
       * This is the core submodule of the game logic controller which interfaces with all of the other submodules, instructing them what to do based on the game rules. The rules are implemented by the updated position of bird from the keyboard, and the current position of the rows of pipes. Appropriate audio is chosen corresponding to the rules (game over message at the time player dies during gameplay).
       
       
       ### b.) Sprite generator:
             * Column orientation: This	 submodule	keeps	updating	 the	X	coordinates	of	 the	pillars	 that	has	already appeared	on	the	screen	(by	decrementing	them	in	every	cycle),	as	well	as	the	length	of	the upcoming	pillar	 that	is	going	 to	appear	 from	 the	right	side	of	 the	screen	 (which	is	actually the	number	of	"partial"	pillars	that	stack).	The	length	of	the	pillar	should	be	random,	as	long as	the	distance	between	the	pillars	is	constant.	Once	the	sprite	moves	out	of	the	screen	(in this	case,	x	coordinate	of	any	one	of	the	pillars	becomes	zero),	we	reset	the	coordinate	so that	it	can	reappear	from	the	right	side	of	the	screen.


            * Angel avatar: Our angel protagonist acts like the bird in flappy bird where flaps and falls will be affect by the gravity. When we implement the object motion formula in our code, time calculation is an issue that we use a counter counting instead of using system clock. We put the delay in our loop and try asuitable count number being our time unit. In addition, we add a status variable to indicate if the angel status is rising or falling. It cooperates with our jumping and falling function with iteration loop supporting continuous jumping without multi-thread.


        ### c.) totalScore: 
         * Every time the bird passes one of the pillars, the "Game Rules" submodule sends a signal, which will make the score increment by 1. Since the sprite for displaying the score is separated into a UI text field, we need to extract them from the score before sending them to the Unity 2D game scene.





## 2.) System Testing:
      * a.) This	 module	 generates	 the	 VGA	 signals	 needed	 by	 the	 VGA	interface	and	also	hcount	and	vcount	values that	are	used	in	Sprite game	controller C# script which controls all in-game functionalities.


      * b.) Based on the control signal received from the software, thesprite controller decides which sprites should be displayed and where they should be. Then sprite controller gets the data from the sprite ROMs and sends the RGB values of each pixel to the VGA interface. The inputs tested for the sprite controller are the following: 
      * Functionality for input in sprite controller:
      * Angel position
      *  Column position
      *  Game start funtionality
      *  Game over message
      *  totalScore in a single run


    * c.) System layers that are tested:
       * Background layer has lowest priority
       * Pipe layer comes next in priority level
       * Score layer comes after pipe layer in priority layer
       * Angel avatar is the topmost layer within priority queue

       * Another problem about VGA is that the data should be updated at the vertical blanking time when the screen scanning reach to the area out of the screen. Other wise, if the data is changed during the scanning of the visible area of screen, the screen may be a little distorted. To avoidthe distortion, we only update the value of data when the vertical scanning is beyond the active region.





## 3.) Acceptance Testing:
