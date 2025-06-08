# Cube Dash

**Built with:** Unity Engine & C#

## Intro

So, Cube Dash is basically a super simple game I whipped up using Unity and C#. It's all about quick reactions and smooth moves. You get to control this little cube, and your main goal is to zoom to the finish line while dodging some basic obstacles along the way. Easy peasy, right?

## How It Plays

### 1. Moving Around
You're in charge of the main cube. The controls are pretty straightforward, letting your cube slide:
* **Left:** To get out of the way or tweak your position.
* **Right:** Same deal, just the other direction.

Your cube's gonna keep cruising forward on its own, at a steady pace, heading straight for that finish line.

### 2. The Goal
Your main mission? Just hit that finish line at the end of the track. Being quick and precise is key to nailing each level.

### 3. Simple Obstacles
Watch out! Along the track, you'll run into all sorts of obstacles, some just sitting there, others moving around. They're designed to test how fast you can react and decide whether to swerve left or right. If you bump into anything, it's game over, buddy!

## Techy Stuff (Unity & C#)

### Unity Engine
* **Level Design:** I used Unity to build out the whole level environment – putting down the track, dropping in obstacles, marking the start, and drawing that finish line.
* **Physics:** Unity's built-in physics engine handles all the collision detection, so when your cube hits an obstacle, it knows.
* **Graphics:** Unity also takes care of rendering all the 3D bits and bobs, making everything look decent with simple visual effects.

### C# Scripting
* **Player Movement Logic:** The C# code is where the magic happens for your cube's horizontal moves, reading your left/right button presses.
* **Speed Management:** The scripts also control how fast your cube automatically rolls forward and the overall pace of the game.
* **Collision Detection:** This C# code handles the *moment* your cube crashes into an obstacle, triggering that "Game Over" screen.
* **Win Condition:** And finally, the script checks if your cube actually crosses the finish line, signaling a win!
