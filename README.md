Class Diagram



&nbsp;   class ICommand {

&nbsp;       +Execute()

&nbsp;   }



&nbsp;   class SpawnBlockCommand {

&nbsp;       +Execute()

&nbsp;   }



&nbsp;   class SpawnSphereCommand {

&nbsp;       +Execute()

&nbsp;   }



&nbsp;   class CommandInvoker {

&nbsp;       +SpawnBlock()

&nbsp;       +SpawnSphere()

&nbsp;   }



&nbsp;   ICommand - SpawnBlockCommand

&nbsp;   ICommand - SpawnSphereCommand

&nbsp;   CommandInvoker -> ICommand





Plugin



&nbsp;   A\[modifier.txt] - B\[ModifierLoader.cs]

&nbsp;   B - C\[SpawnBlockCommand/SpawnSphereCommand]

&nbsp;   C - D\[Object Spawn Height in Scene]



This Unity scene demonstrates the Command Design Pattern in a simple Mario Maker-style way. Two UI buttons execute commands to spawn blocks or spheres. A text file modifies the spawn height without changing code.



How it Works

CommandInvoker triggers SpawnBlockCommand or SpawnSphereCommand.

Commands spawn objects in the scene.

modifier.txt changes the spawn height when playing.



Controls

Click the UI buttons to spawn objects.



I used the command pattern by having each button call a command to spawn a cube or sphere. This kept my code separated so that the UI doesn’t directly create objects.



For the modifier part, I used a plain text file to change the spawn height instead of using a DLL or plugin because it’s faster and easier to show.



A problem was making sure my commands actually ran from the UI button and figuring our how to work the plugin.



Next time i’d also like to experiment with using a DLL or a more complex plugin once I understand them better.



