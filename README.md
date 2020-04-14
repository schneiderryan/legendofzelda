# legendofzelda
- built with Monogame

# Controls
- W and up arrow: move player up
- A and left arrow: move player left
- S and down arrow: move player down
- D and right up: move player right
- Z and N: player attacks
- I: Open Inventory
- H: Move Left Thorugh Inventory
- J: Move Right Through Inventory
- Q: quit game
- R: reset game
- 1: throw sword
- 2: throw arrow (after link as found both arrow & bow, and has > 0 rupees)
- 3: throw boomerang (after link has found the boomerang)
- 4: drop bomb
- P: Pause Game

# Functionality
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
- Player can walk through doors
- Rooms loaded using csv files
- Spawning/despawing animations for enemies and projectiles

# Known Bugs
None

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
