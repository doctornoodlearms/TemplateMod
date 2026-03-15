# Slay The Spire 2 Template Mod

## Loading Mods
1. Find the games directory from Steam, it will have the games Executable file, a .pck file, and a folder labeled "data_sts2_[something-based-on-OS]"

2. Add a new folder called "mods", and a folder within it with the name of the mod (in this mods case TemplateMod). Then add the mods .pck and .dll files

4. Then when once a mod is setup for the first time the game does a couple things:
  - It will load a seperate save file, so dont panic about any loast progress (you can go back by just renaming the mods folder)
  - If its the first time the game has loaded as modded it will ask if you intended to load the mods, confirming will close the game
  - After restarting the bottom right will say how many mods are loaded and there will be a new setting to show you all the mods installed

## Building Mods
1. STS2 is using a modified version of Godot 4.5.1 C# and uses dotnet version 9.0 so those will be needed to build a mod

2. A couple things that Godot sets up by default that will need to be changed:
  - Change dotnet version 8.0 -> dotnet version 9.0 in .csproj
  - When building the project it will probably go to .godot/mono/temp/bin/Debug but there are a couple other places it goes to as well. But it can be changed with the OutputPath tag in .csproj (in this project it is changed to .builds)
  - The project will need a reference to the sts2.dll. I find it easiest to add the binary to the project directly and add a reference in the .csproj (this project just references .dll files in the .lib folder)
  - Also recommended to have a program to decompile the sts2 binary
  - And a program to decompile the games pck as a reference to how assets are setup in game

3. For STS2 to load a mod it a requires:
  - A file called "mod_manifest.json" this tells the game some basic information about the mod
  - A static class with the ModInitializer attribute and a specified method which the game then calls to load the mod (with this project it is TemplateMod.cs)
  - A mod_image.png isnt neccessary for the mod to load
  - I believe that is all thats required for the mod to load, but it wont do anything

## Debuging
1. The game can be started from steam with Godot release command line arguments
2. So we can run the game with --remote-debug tcp://127.0.0.1:6007 to have it connect to a Godot editor which will then print the games console
  - tcp:// is the protocol to use and wont be changed
  - 127.0.0.1 just refers to your computer and also doesnt need to be changed
  - 6007 is the default port that Godot uses for remote debugging, but this can change when the editor loads if that port is unavailable, if it uses a different port it will say so in the console
  - Also make sure that Keep Debug Server Open is enabled under Debug in the editor (not in the Editor Settings, it is a toggle under Debug)

## Folder Structure
1. Half the time Im convinced the game is gaslighting me but this is what is working for me currently (this will change as I figure out more systems)
  - Everything needs to be in the pck except the scripts, everything listed below is included in the Godot pck export

### Images
This folder is just part of the root folder in Godot and contains any images for the mod content, cards, relics, powers, etc

### Mod Folder 
This is referring to the folder named the same as the mod (TemplateMod in this case)

### Localization
This has the language files to tell the game what text to load based on the players language. This should be in the Mod Folder

### Mod Image
The image to load for the mod list (I believe that it must be a png and will not work otherwise)

## Custom Relic
This will explain the assets needed to load a custom relic into the game. The code to do so is explained in TemplateMod.cs

1. The atlas images should be a single massive image with every sprite of that type
  - STS2 has an atlas for relics which is the combination of every relics sprite all next to eachother
2. The .tpsheet is a custom file that describes the individual sprites for the relics
  - This is a custom file not recognized by Godot so it will not appear in the editor
  - It is still included in the pck so make sure to add .tpsheet as an exception to the export settings
3. Then under relic_atlas.sprites are the atlas textures for each sprite which i assume is what's actually loaded in game
  - The size of these can be anything but STS2 uses 85 x 85 
4. The sprites under the relics folder aren't neccessary for the sprite to load but are used for the aniamtions when a sprite is loaded and its effects 
  - The size of these can be anything by STS2 uses 256 x 256
  - Also STS2 has this folder a subfolder for images but I think it works under images/atlases so Ive got no idea

