# Quake Remake Keybinder

The Quake 1 remake/remaster doesn't support straightforward weapon rebinding from in-game. However, it can be done by using an autoexec file, much like other game made on idtech 3-ish and Source games. The issue with this is that there are a lot of people who missed the old days of arena FPS and aren't used to this workflow. This program automates the process.

The Quake Remake Keybinder does the following:

- Collects the users desired keybinds (currently no support for numpad keys or keys like shift, tab, etc.)
- Creates the directory where the Quake 1 remake/remaster will look for the config file if it doesn't exist
- Creates the autoexec config file (`autoexec.cfg`) and writes the binds to the file. This process translates weapon names to their corresponding `impulse` commands
- Shows the user where the config file will live after the process is done

## Dependencies

This app was built using .NET 5, so you'll need the .NET 5 Desktop Runtime to run it.

The .NET 5 Desktop Runtime can be downloaded from Microsoft here: https://dotnet.microsoft.com/download/dotnet/thank-you/runtime-desktop-5.0.9-windows-x64-installer