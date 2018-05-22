# Complete Unity Developer - Section 11 - Ahoy Matey

This is the [Complete Unity Developer](http://gdev.tv/cudgithub) - one of the most successful e-learning courses on the internet! Completely re-worked from scratch with brand-new projects and our latest teaching techniques. You will benefit from the fact we have already taught over 360,336 students game development, many shipping commercial games as a result.

You're welcome to download, fork or do whatever else legal with all the files! The real value is in our huge, high-quality online tutorials that accompany this repo. You can check out the course here: [Complete Unity Developer](http://gdev.tv/cudgithub)

## In This Section
### Section 11 Notes ###

+ Congratulations on your progress.
+ Point-and-click 3D isometric ship battle.
+ Multiplayer, you can use just one PC.
+ Using UNet throughout, minimising prefabs.
+ Section notes are attached.

### Section 11 Game Design Document (GDD) ###

+ Create a simple GDD live.
+ Write a paragraph explaining the game concept.
+ List the major game rules.
+ Define the asset requirements.
+ Think about how we may monetise this game.

### Testing Network Games Locally ###

+ An overview of the development process.
+ Unity Editor against local build.
+ Testing between two different machines on LAN.
+ Version control is an option (Git, SVN, etc).
+ Optional: set-up Dropbox sync between 2 PCs.

### Deploying Our Game Locally ###

+ How to deploy the same version to 2 machines.
+ Version control is an option (Git, SVN, etc).
+ You could use a shared folder.
+ Set-up Dropbox sync between 2 PCs.
+ Care to use one as master (also the host).

### Introducing Network Manager ###

+ The concept of a stack of APIs.
+ An overview of Unity’s network stack.
+ Finding out where to start with networking.
+ Get our game running with networking enabled

### Replacing Network Manager HUD ###

+ Why we want to replace the default HUD.
+ What the default HUD does for us.
+ Create our own “Start Host” button.
+ Where to find the API documentation.
+ Wiring the button to script and testing.

### About The Override Keyword ###

+ A recap of inheritance.
+ What the **override** keyword does.
+ Why we need to use it here.
+ Explaining **public override void OnStartHost()**
+ Test the result.

### Logging Client Start Requests ###

+ About localhost\* vs. an IPv4 address.
+ Finding out your machine’s IP address.
+ Temporarily using the HUD again to connect.
+ Connecting to a local build via localhost.

\* [localhost - Wikipedia, the free encyclopedia](https://en.wikipedia.org/wiki/Localhost)

### Using NetworkTransform ###

+ What NetworkTransform does for us.
+ About NetworkIdentity and why it’s needed.
+ Make movements travel over the network.
+ Test this over the LAN, and with local build.
+ Optionally: test this to a mobile too.

### Networked Player Movement ###

+ Understanding players in multiplayer games.
+ Getting players working on clients.
+ Filter input with **NetworkBehaviour.isLocalPlayer**

### Multiple Players With Local Authority ###

+ Adding a Network Transform to our player.
+ Re-introducing Local Player Authority.
+ Testing 3-way player movement.

### MultiPlayer Cameras ###

+ Add a camera as a child of Player.
+ What is causing our camera issue.
+ One simple way of solving it.
+ Care with disabling camera object vs. component.
+ Don’t use deprecated NetworkView component

### Network Recap & What’s Next ###

+ Talk through Unity’s Network System Concepts\*
+ Ask “What’s not fun about this game”.
+ Challenge you to make a basic game.
+ Please thank @MarcoValeKaz for the ship.

\* [Unity Manual - Network Systems Concepts](https://docs.unity3d.com/Manual/UNetConcepts.html)

### DOWNLOAD Section 11 Unity Project ###



### Section 11 Wrap-Up ###

+ About the course taper structure.
+ You have everything you need.
+ Keep testing, keep asking, keep learning.
+ I’m committed to maintaining this course.
+ That includes adding to this section if needed.
