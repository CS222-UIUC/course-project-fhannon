# Crush Your Computer

## Brought to you by FHANNON

Bhuvana Betini, Collin McCormick, Shannon Ji, Talia Sriram

### INTRODUCTION

Have you ever been so stressed that you just wanted to crack your computer screen? Well, with Crush Your Computer, you can! We designed Crush Your Computer to be an overlaying-desktop application that allows a user to interact with their desktop in a semi-destructive manner.

Our game is inspired by The Destroy Your Desktop Application, an early 2000 Windows application, as seen on the slide. We sought to make a newer, sleeker version of the application that would work on MacOS devices. The

### TECHNICAL ARCHITECTURE

With the heavily visual aspect of this project, we decided to work in Unity, which would allow us to freely combine visual elements and implement their functionality through C# scripts.

In the Unity project, we put together a scene that connected together the Assets which included the Background, the Tools, the effects, and the scripts for all of those. The game art for the tools, effects were made using a combination of Blender and Photoshop. The backend of the project consists of the scripts controlling functionality for the Tools, Effects, and switching between the tools. All the Backend is done in C# using Unity libraries. The user’s actions are directly connected to the scripts since we use Unity’s Mouse and Keyboard libraries to get information about the mouse location, mouse clicks, and keyboard clicks.
There are 2 main parent components: Tools and Effects. The Tool GameObject serves as an abstract class for the various tools that users switch between. The Tool GameObject uses Mouse location and Click data to interact with its environment and reflect the user's input. When a User moves the mouse, the Tool GameObject moves along with the user’s cursor. When a user clicks the mouse, the Tool GameObject calls its Use() method which is overwritten within the child components and performs an animation. The Hammer GameObject builds upon the functionality of the Tool GameObject by creating an instance of the Crack Effect on click at the location of the cursor. The Paintbrush also builds upon the functionality of the Tool GameObject in a similar way by creating an instance of the Splatter Effect at the location of the cursor. Finally, the Wand GameObject removes all instances of all Effects from the scene on-click.

### Reproducible Installation Instructions

    1. Download the repository course-project-fhannon
        a. Download as a zip and then decompress the package.
    2. Open the app titled "CrushYourComputer"
    3. tart cracking!

### Group Members and Their Roles

Bhuvana worked on the general App Heirarchy, creating the Wand GameObject, the Hammer GameObject, and writing the template code used to instantiate the effects.

Collin worked on creating the art for all the components, utilizing the Mouse library to get Mouse location and click information, and implementing a base for the Tool GameObject script. He also helped with finding a solution to our version control issues and getting Unity and GitHub to work together.

Shannon worked on switching between the various Tools using keyboard keys. After we created all three of these GameObjects, we had to find a way to switch easily between them.

Talia worked on developing the Paintbrush GameObject and its interactions with the Splatter Prefab. Effect is the abstract parent class of the Splatter and Crack prefabs, which are game objects. These prefabs are instantiated on mouse-click.
