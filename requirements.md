# Requirements Specification for [Escape from Ruins of the UnderWorld "Flappy Bird-like" PC game]
## 1. Introduction
## 1.1 Purpose of Product
We aim to create a flappy bird like game using C# and Unity. Our game will include different card types with a few different mechanics. 
Users will have access to an angel avatar that "flaps" up depending on how many times the user clicks left mouse-button during a constricted time interval. 


## 1.2 Scope of Product
*Product includes : 
-Sound effects that play when the angel dies by hitting the ground, colliding with pipes, and/or getting damaged by an enemy attack.
-Imported angel and enemy sprites, as well as randomization of column placement for a bit of a challenge while user plays the game
-Keeps track of high score in all of the player's runs
-Play and Exit buttons

-Concede/Quit button (prompt user for confirmation before leaving the match)

*Product does not include:
- Multiplayer server (all enemies will attack the player by being controlled through an AI system)
-In game purchases or application created for monetization purposes under agreement of the Unity 2D and Visual Studio implied licenses that shall be only used for unprofitable community projects abiding by copyright disclaimers under federal law.

## 1.3 Acronyms, Abbreviations, Definitions
-Unity 2D : Development platform that can be utilized to create any sort of game or project with enhanced visual features
-Visual Studio: Programming IDE that is synced with Unity 2D that is a basic editor used by developers to create code that meets user requirements and expectations for the project's key components.
-C# Scripts: 
- colliders: boxed areas that will allow the angel to hit the ground without falling through the game area or whenever the player hits a pipe, then the game over message is displayed and thus the game finishes
- rigidbody component: allows for physics/gravity components implemented in the UI interface

## 1.4 References
URL link for project specifications : https://dylrlas.github.io/finalProject/
Requirements Specfication for project template posted on Canvas

## 2. General Description of Product

## 2.1 Context of Product
We will use C# scripts via Visual Studio IDE that is in sync with the Unity 2D platforming engine in order to create the context of the obstacle-dodging, fun, and addictive game that is based purely off of the Flappy Bird game concept, but is planned to not be an exact copy of it.

## 2.2 Domain Model with Description

Person :    -------------------------------------------------------->     Game Mode :
|            +player                                      + background          name
|
(Attributes):
username : String
score : int
 : int
|
|   -----------------------------------   <<Rule>>: If a player does not click the left mouse button, then they are not playing the game.
|
finalScore: int
type 
UItext
(Domain class)



## 2.3 Product Functions (general)
*Sound effects when user collides with a game object and the angeldied() method is called
*Angel and enemy sprites (enemies will come out of the pipes and shoot fireballs kind of like Super Mario's "fireball plants"
*Single-player mode meant to be played without a multiplayer server
*Players begin the game at mid level
*A player will lose when they hit ground, collide with a pipe, or get damaged by an enemy attack. restart is called and performed after user clicks play again to continue

## 2.4 User Characteristics and Expectations
*New users should be able to start the game and understand the rules and mechanics of the game with ease, without needing to ask for clarification from the development team.
*After holding a small tournament with 8 people, a brief survey will be administered to gauge the players’ feelings on the card game and their experiences should show at least 50% of players had positive feelings about the tournament.
*Single player mode should be enabled in this case; no multiplayer functionality will be implemented
*The creation of at least two 25-card decks which utilize different strategies and will be made available to new players.
*Users can play cards from their hand by dragging and dropping onto their playing field. They should be unable to interact with any cards under the enemy’s control, whether in their hand or on the field, and be unable to move cards from their own field once played.
*A card should be magnified if a user hovers their mouse over it for some duration of time. This enlarged version should appear in a consistent location, and disappear when the user begins to drag the card or moves their mouse away from it.
*Life totals for both players will be accurately displayed throughout the duration of the game.
*The program will be able to facilitate card interactions of an entire game, using card data (manna cost, attack/health, any other effects) without requiring user input outside of normal user decisions.


## 2.5 Constraints
1.) Sprites have to be at the right starting positions or else the game becomes either condensed and jumbled all around or no sprites show up on the background "gaming area" 
2.) User should not be able to tap another key in order to flap (has to be left-click)
3.) User cannot "glitch" through an object and move on to keep "flapping away"; they have to collide with the object and fall to the ground


## 2.6 Assumptions and Dependencies
Our system depends on source code from each C# script that is implemented into the Unity IDE. A brief list of assumptions includes the following for our project:
-Scope
-Scheduling
-Resources
-Time Management
-Expectations
-Technologies
-User testing functionality

## 3. Functional Requirements
Userstories page link for CelestialOctopi Project Page : https://dylrlas.github.io/finalProject/userstories

## 4. System and Non-functional Requirements

### 4.1 External Interface Requirements (User,Hardware,Software,Communications)
Our project implements a Unity UI interface, which is a UI toolkit for developing user interfaces for games and applications. 
It is a GameObject-based UI system that uses gravity/physics Components and the Game View to arrange, position, and style user interfaces.
Developers cannot use Unity UI to create or change user interfaces in the Unity Editor. 
Our programming IDE involves Visual Studio and creating C# scripts to perform certain in-game functionalities. In-game functionalities for the project include, but are not limited to:
* AngelControls mechanics
* GameController mechanics
* Scrolling angel gameObject that moves to right along with main camera (player will only be in charge of moving avatar up and down, not left to right)
* Repeating background that is compatible with the Scrolling angel gameObject in the Unity2D UI interface
* Column implementation that will spawn these types of sprites at random positions throughout the game area

### 4.1 External Interface Requirements using item numbers
NF.4.1.X. User interface : mainly includes elements such as specific competence, criteria action, and response time. Users should be able to flap up and rapidly accelerate down in order to dodge obstacles such as incoming pipes at alternating levels and enemy fireballs. 
NF.4.1.XI. Software Interface : The system requires a configured PC of either Linux or Windows so that the card game can be run properly on the central processing machine. 
The system must be compatible with running code from Visual Studio utilizing the C# programming language and importing the base code into the UI interface of Unity 2D.
NF.4.1.XII.  Communication Interface :  Data transferred from the server shall be enabled to be played offline, and in this case, multiplayer server does not matter. Access to play this game is free for everyone which is against enemy bots that shoot fireballs out of some pipes at random points throughout gameplay.

### 4.2 Performance Requirements
NF.4.2.X. Code Functionality:  specific competence, criteria action, and response time. For instance, checking how efficient the runtime is running the code for the code structure implemented into our card game project.
NF.4.2.XI. Integrity : availablity of developers (just me for this individual project) to work on components of the project as well as maintenance performance, and other requirements to fulfill such as code maintentance and thorough user testing.
NF.4.2.XII. Reliability/Availability of procedures : Correct and update code functionality that will adhere to all user requirements provided in the problem statement and userstories links on the individual mini-scaled project website.

### 4.3 Design Constraints
 NF.4.3.X. Game Mechanics should be relatively balanced with each other– that is to say, no mechanic or sprite that is imported should stand out from the others that stands out too much or is bigger/smaller in size compared to the others. This will require extensive playtesting.
 NF.4.3.XI. User cannot "glitch" through an object and move on to keep "flapping away"; they have to collide with the object and fall to the ground
 NF.4.3.XII. Sprites have to be at the right starting positions or else the game becomes either condensed OR jumbled all around that displays no sprites that show up on the background "gaming area". 
 

### 4.4 Quality Requirements
 NF.4.4.I. Having a game with simple rules and mechanics would be ideal for beginning and intermediate players and allow everyone to enjoy the game, without requiring extensive research to understand rules and strategy.
 NF.4.4.II. Many "flappy bird copies" are basically implementing the same game mechanics, both in difficulty and financially. I aim to create a game which is freely accessed and which is more unique and not just a "plain ripoff" by adding enemies and different wacky sound effects when a player fails at the game.
 NF.4.4.III. In this context, a flappy game project goal would implement all original flappy bird game mechanics, such as a total score display and colliders that show when the player hits the ground. When users test moving with angel avatar, there should be no functionality issues which shows the game over message at beginning of game when player has not died yet (for example) or sound effects that play at random times during gameplay rather than only when the player hits an obstacle, as originally intended.
 NF.4.4.IV. Single player mode enabled only; no multiplayer functionality in this instance of flappy bird due to time constraints
 NF.4.5.IV. As a user, I want an interface that doesn’t take a long time to learn, so that I can learn how to play the game more quickly.
 NF.4.6.VI. Developers should create , leading to anger and frustration testing out the basic game mechanics.


### 4.5 Other User Requirements
 NF.4.5.X. A user should be able to play the game by left-clicking the mouse button to maneuver between obstacles and falling down to ground after angelDied() method is called.
 NF.4.5.XI. Sound effects should give the game a sort of "audio feature" to the project, so it isn't so boring, uninteresting, and stale when it comes to terms on user requirements of testing out the game demo for the first time that relies on efficient code and proficient design layout.
 NF.4.5.XII. As a player, I want the game to keep track of game data and statistics so that the user is free to focus on playing the game.
 NF.4.5.XIII. The game should pay attention to both players’ total Scores displayed on the screen out of the ranged area where the game is played and counts the number of pipes jumped through, incrementing total Score by 1 for each set of pipes jumped through, and using that information to help print a game over message at the correct time after a user has "died" while trying to escape from the ruins of the underworld.

 

## 5. Appendices
Include external documents that describe domain or constraints or any necessary information. Use URL links if possible.

-Architecture of card game project : https://dylrlas.github.io/finalProject/architecture (page will be updated as part of project requirements)
-Design document URL link : https://dylrlas.github.io/finalProject/design(page will be updated as part of project requirements)