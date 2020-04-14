# legendofzelda
- built with Monogame

# Controls
- W and up arrow: move player up
- A and left arrow: move player left
- S and down arrow: move player down
- D and right up: move player right
- Z and N: player attacks
- Q: quit game
- R: reset game
- 1: throw sword
- 2: throw arrow
- 3: throw boomerang
- 4: throw bomb
- Left Click: Iterate forward through rooms
- Right Click: Iterate backwards through rooms
- P: Pause Game

# Functionality
- Room switching when going through doors and with mouse
- Player can die which resets game
- Player can win upon picking up triforce
- Start menu and credits
- Player moves around and fires projectiles
- Player picks up items
- Player collides with enemies and takes damage from enemies
- Enemies take damage when link attacks and fires projectiles
- Enemies die and despawn
- Enemies and player collide with walls and blocks
- Player can move moveable blocks
- Player can walk through doors (doesn't change room though)
- Rooms loaded using csv files
- Spawning/despawing animations for enemies and projectiles implemented

# Known Bugs
FIXED - When trying to move link in two directions at once, he stops animating
FIXED - When link attacks with another weapon there aren't different sprites
FIXED - Some enemy/npc functionality isn't fully implemented yet (Wallmasters, old man, merchant)
FIXED - Some items are not fully implemented yet (rings, candle, clock, compass)
FIXED - When the attack key is held, link attacks repeatedly
FIXED - Bomb does not work correctly
FIXED - Aqumentus' fireballs are not directed at link

# Code Analyzer Suppressions (17 warnings found sprint 3)(9 warning found sprint 4)
- CA1812	RedLink is an internal class that is apparently never instantiated. If so, remove the code from the assembly. 
            If this class is intended to contain only static members, make it static (Shared in Visual Basic).

            Suppressed because we expect to instantiate red link later on in the project.

- CA1062	In externally visible methods validate that the parameters are non-null before using it.

            Suppressed beacuse it's reasonable to assume it will not be null in this case.

- CA1307    Specify StringComparison

            Supressed becasue the scope of the project will never extend to other countries.

- CA1305    Specify IFormatProvider for int.Parse

            Supressed becasue our expected users are english-speaking, so their locale settings should
            all be the same or very similar.

We fixed the remaining warnings.

# Authors
Will Bartlett | Taylor Benjamin | Adam O'Reilly | Ryan Schneider | Emily Smith | Isaac Smith
