# MobileTouch: Moving an object with touch - Mobile game with Unity

This repository provides code (in C#) to move an object using touch on mobile devices. It is meant to be used with Unity3D, to develop a mobile game.  

## For who?

If you're just starting to develop a mobile game with Unity and you need the players to be able to move objects with their fingers, this repository is for you!

## How it works

It uses raycasts to determine where the user touched the screen. If there's a hit on an object, the object will follow the finger for as long as it touches the screen.  
**/!\\** Note that this code will work only if there's one finger touching the screen. You're welcome to provide additional code to change the behavior if there are several fingers on the screen.


## How to use

First of all, clone or download the repository. You can then either test the code using the simple test scene provided or copy the script into your own project.

#### Test it
* Open the test scene (Assets > testScene)
* Build the project and put it on your device <br/>
    **Note:** the build settings are currently set for Android, if you're on iOS, you'll need to change them
* **OR** download Unity Remote and test it using the app

#### Use it in your own project
* Open the MoveObject script (Assets > MoveObject.cs)
* Copy everything
* In your own project, create a new script called MoveObject.cs
* Edit the new script, delete everything and replace it with what you've copied
* Attach the script to an empty gameObject or to your main Camera


