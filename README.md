# SJSU_Fall2020_SourceCode_Group22
This is the source code for the VR MATe Laboratory project. This will not contain the full build of project, but the source code added onto the project and how to setup the project. To build and run the project is listed below. A tutorial of how to setup the scripts with project are provided with great details in the source code.

# Build and Run
1. Download and install Unity, https://store.unity.com/download.
2. Download and install Steam and SteamVR.
  2.1 Download and install Steam.
  2.2 Open Steam and go to Library at the top left of the screen.
  2.3 In the left menu, find a drop down menu with Games. Click and select tools.
  2.4 Download and install SteamVR.
3. Setup HTC Vive or SteamVR compatible devices.
4. Run SteamVR and make sure that the Headset and two cameras light up inside of the application.
5. Run and open Unity.
6. Download the application from the following repository, *Has not been added.*
7. Create a new workspace and reference the folder, CVRLabSJSU.
8. Find the directory menu at the bottom left of the screen and find a folder named Scene.
9. Double click on one of the following scene: "Release Main.unity" or "Development Main.unity."
10. Click the play button at the top middle of the application. The program should now run.

Link to source code: https://github.com/ChuefengVang/SJSU_Fall2020_SourceCode_Group22.git.

# Script Setup
A tutorial of how to setup the scripts with project are provided with great details in the source code.
Please refer to each file. Some files may not have any setup information. Those do not need to be setup.
All TODO comments can be ignore.

# Full Project Build

Link to Project Build: https://github.com/ChuefengVang/CVRLAB_Fall2020_Group22_Project

# Code Structure
The code structured used for the entirety of the project was based on Polymorphism and Mutex. The use of polymorphism is to allow each object to inherit properties from others and/or access such properties. Mutex was heavily used to allow access to the object's properties inside of the classes. This gives flexibility for objects to access or change such property when needed. It also provides security in which outside users cannot change the property within. 
