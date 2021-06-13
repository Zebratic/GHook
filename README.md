# GHook
A simple hooking tool using the WinAPI to parent and child processes into eachother

## Installation
Simply download the source code and build it using .NET 4.7.2.
Or download the release from [releases](https://github.com/Zebratic/GHook/releases).

## Usage
You can use this if you need to hook processes into other programs.
As an example;
- Console window -> Notepad
or
- Discord -> Microsoft Paint
etc.

If you only need the library, just download the [GHook.cs](https://github.com/Zebratic/GHook/blob/main/GHook.cs) file, and import it to your project.

## Notice
Hooked processes that are inside the other program dont close when the parent process is closed, but they stay invisible.
Only way to fix this issue is by killing the process in task manager.
