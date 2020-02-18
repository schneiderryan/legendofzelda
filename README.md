# legendofzelda
- built with Monogame

# Controls
- W and up arrow: move player up
- A and left arrow: move player left
- S and down arrow: move player down
- P and right up: move player right
- U: swap between items
- I: swap between items in other direction
- O: swap between enemies
- P: swap between enemies in other direction
- Q: quit game
- R: reset game to initial state
- E: damage link
- 1: throw sword
- 2: throw arrow
- 3: throw boomerang

# Functionality
- Right now the player can be moved around, attack, and throw projectiles.  Enemies move around and those that shoot projectiles
  do so.  Items can be swapped between.  There is no collision detection.

# Known Bugs
- When trying to move link in two directions at once, he stops animating
- Goriya only throws boomerangs upwards for now
- when link attacks up or left his sprite jumps and attacks continuality
- when link attacks with another weapon there isn't different sprites 


# Code Analyzer Suppressions (80 warnings found)
- CA1812	RedLink is an internal class that is apparently never instantiated. If so, remove the code from the assembly. 
  If this class is intended to contain only static members, make it static (Shared in Visual Basic).

            Suppressed because we expect to intantiate red link later on in the project.

- CA1062	In externally visible methods validate that the parameters are non-null before using it.

            Suppressed beacuse it's reasonable to assume it will not be null in this case.

- CA1307    Specify StringComparison

            Supressed becasue the scope of the project will never extend to other countries.
We fixed the remaining warnings.

# Authors
- Will Bartlett
- Taylor Benjamin
- Adam O'Reilly
- Ryan Schneider
- Emily Smith
- Isaac Smith

### Spritesheet sources
- Items: https://www.spriters-resource.com/resources/sheets/52/54720.png
- More items: https://www.spriters-resource.com/resources/sheets/8/8366.png
- Link Sprites: http://www.zeldagalaxy.com/wp-content/img/sprites/nes/loz/link.png
