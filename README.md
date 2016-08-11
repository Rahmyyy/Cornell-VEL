# Cornell Virtual Embodiment Lab
Using Unity and C#, the following repository contains Unity and C# scripts that allow for accurate tracking and recording of the HTC Vive's head mounting device as well as the left and right controllers, outputted into a CSV file. Also, the user is able to see full arm movements due to a rigged and textured arm mesh from Maya and inverse kinematics that guess approximately where the elbow and shoulder's location and rotation will be based off of the hand's location and rotation. There is also a GUI that allows users to customize which controllers can control which parts of the body: for example, the left controller could control the right foot's movements with 20% gain. 

##Tracking [Scenes: kyle_scene and currscene]
The tracking section uses Unity and C# scripts to create three CSV files that record the date-time stamps [to the millisecond for accuracy], position, and rotation of the HTC Vive headset as well as the left and right controllers. If the time is the same for recorded output, it will be displayed in the CSV file in the order head, left controller, right controller (the body part is also notated at the end of each recorded line).

###General 
The outputted information is determined by an absolute coordinate system, with the origin indicated by the ball at the center of the screen. 
The information is recorded immediately when the play button is pressed or when the build is executed. <br />
When the space button is pressed, the output stops being recorded to the CSV file. When it is pressed again, recording continues. <br /> 
To delete recorded output, press either the l, h, or r key [left controller, head, right controller respectively]. <br />
Once the application is quit, a series of new lines and a line of asterisk delimeters will be entered to separate run-through data. 

####Left and Right Controllers
If only one controller is being used, the RightController.csv file will contain the tracking information for that moving controller. When both controllers are active, the one that is leftmost in space is recorded as left. 

###Events
Events are recorded by pressing down the 'E' key. This records down the timestamp and event name, as well as the location and rotation for that particular event, making it easy to debug tracking movements. 

###Testing
1. Left hand: 
           Up and down 5x <br />
           Side to side 5x [right then left] <br />
           Back and forth 5x <br />
           Pitch 5x <br />
           Yaw 5x <br />
           Roll 5x <br />
2. Right hand: 
            Up and down 5x <br />
            Side to side 5x <br />
            Back and forth 5x <br />
            Pitch 5x <br />
            Yaw 5x <br />
            Roll 5x <br />
3. Head: 
      Down and up 5x <br />
      Side to side 5x <br />
      Back up, go forward 5x <br />
      Pitch 5x <br />
      Yaw 5x <br />
      Roll 5x 

##Character [Scenes: twoworkinghands and feetinversekinematics]
The given character [secretary] is an imported model from Unity's free assets. The head and bodily motions of the headset and controllers are accurately reflected in the first person movements of the character. A mirror is set up in the scene in order to better debug movements. 

###Character Progress
The arms have been separated from the rest of the character mesh. The rigging within each of the arms allow for proper wrist movement. Also added on are controllers that are held within each hand. As of now, all wrist, elbow, and shoulder movement is accurately tracked with the exception of some wrist deformation when twisting the arms along the x-axis. The feet currently move alongside the head mounting device and rotate appropriately. Next to be implemented is adding two extra Vive controllers to the ankle area which will allow for an even more accurate array of tracked movement. 

###Character Scripting
The character's movements all correspond to a script, SteamVR_IK, that uses inverse kinematics to change the position and rotation for all of the arm and head body parts in accordance to the movements of the head mounting device and controllers. It allows for wrist turning and twisting as well as for elbow and shoulder movements. The character's feet move in accordance with the Foot Movement script which allows for the feet to mostly follow the movements of the head mounting device [with some positioning and rotational constraints]. 

###Character Functionality
Due to the PickupParent script, the user can currently pick up spheres and other GameObjects from the floor by pressing down the Trigger button. They can then proceed to throw the objects with accurate velocity by flinging their arms and releasing the Trigger button. In order to reset the GameObjects to their original positions, the user can press the Touchpad button.

##GUI System [Scenes: twoworkinghands and feetinversekinematics]
The GUI appears on only the computer screen. It allows researchers to input an ID number that will save the saved file including all tracking information under a CSV file of that name. Alongside this, researchers can add in the input and output controllers from a dropdown menu [Inputs: Left and right controller; Outputs: Left Hand, Right Hand, Left Foot, Right Foot] as well as the percentage of gain that appears when the participant moves. This allows researchers to very easily and intuitively manipulate what the participant perceives as their own movements in Virtual Reality. The percentage of gain is the amount of movement shown on screen for the amount of movement the participant actually does. 

##Avatar Substitution
The module is currently being updated to allow for an easy switch between avatars from the Unity Asset store. This involves using a 'ghost' Inverse Kinematics arm which controls the movements of the arms of the avatars that the user can see. Because there is a ghost arm present, the proper parenting that will allow for controller control of arm movements can be implemented. 

##Target Test Game [Scene: targettest]
The target task uses the working arms with inverse kinematics as well as the detached feet. There is a vertical plane upon which bubbles randomly spawn and the player can, upon contact with the bubbles, pop them. To be implemented is a GUI system that will allow the user to adjust the dimensions of the plane and balloons, the duration for which bubbles are visible, and the number of balloons that spawn. 


###To Be Implemented
* Recording data in columns
* Kill fixed update --> judder change?
* Preferences screen where you can customize the username [for the file], the event name, saving to an existing file, etc 
* Remove toggling of keypresses for now
* Run in beta?
* Create a dialogue box that allows you to choose the user and will allow you to either create a new file or use an existing one
* Create a new file every single time a button is pressed
* Have a more visual way of viewing the data
* Customizable keypresses 
* High fidelity - networked second life VR spinoff
* Create customizable avatars and characters in VR
* Scaling the human avatar with that shown on the screen --> Script according to the headset distance from floor
* Perfecting hand movements by preventing unnatural hand movements 
* Model the surrounding room 
* Gain
* Balloon popping target practice game
* Dart practice game
* Team building activity where two people hold controllers and the average of their movements is what is shown on the screen
* Pit Demo


###Helpful Links
*Rigging a skeleton in Maya: https://www.youtube.com/watch?v=gUPbbhnUXhY
Hope? https://www.youtube.com/watch?v=bls91XlQHSY, https://www.youtube.com/watch?v=KYY7qo0z5h8, https://www.youtube.com/watch?v=A12gtS4oOgo
*Was able to remove the upper arm rotation with the help of this link (http://serrarens.nl/passervr/inverse-kinematics-for-arms-in-unity-freeindie/) 




