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

2. A couple things that Godot setsup by default that will need to be changed:
  - Change dotnet version 8.0 -> dotnet version 9.0 in .csproj
  - When building the project it will probably go to .godot/mono/temp/bin/Debug but there are a couple other places it goes to as well. But it can be changed with the OutputPath tag in .csproj (in this project it is changed to .builds)

4. For STS2 to load a mod it a requires:
  - A file called "mod_manifest.json" this tells the game some basic information about the mod
  - A static class with the ModInitializer attribute and a specified method which the game then calls to load the mod

