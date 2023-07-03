# Bachelor's Degree Thesis: Control of Mobile Robotic Devices using BCI - Unity Mobile Robot Part

## About
This repository contains the Unity part of the Bachelor's Degree Thesis project, focusing on controlling a mobile robotic device using Brain-Computer Interface (BCI). The project consists of two key components: ROS nodes and a Unity application. This repository specifically focuses on the Unity application.

The Unity application serves as the user interface for the BCI control. Unity was chosen for this part of the project due to its compatibility with the NextMind device, which only supports development through Unity. 

## Unity Application
The Unity application I developed for this part presents eight neurotags to the user. Each neurotag corresponds to a specific command that will be sent to a mobile robot. The application uses the ROS2-For-Unity library to ensure effective communication between the Unity application and the ROS nodes controlling the mobile robot.

## Version
This project uses Unity version 2020.3.14f1.

## Prerequisites
To run this project, you will need:
- Unity 2020.3.14f1
- NextMind SDK installed and set up in Unity
- ROS2-For-Unity library installed in Unity

## Installation
Detailed instructions on how to install and setup the project will be added soon.

## Usage
To successfully use this application, it is crucial to correctly position the NextMind device on your head, as it will serve as the primary user interface. Correct positioning is fundamental for ensuring the system's precise operation.

The calibration process for the NextMind device is straightforward and can be directly accessed from the Unity-based application's menu that I have developed. Be sure to follow the provided instructions closely to effectively calibrate your NextMind device.

Once the NextMind device is calibrated, you can proceed to the device control section of the application. Within this section, you'll find eight neurotags displayed, each corresponding to one of the eight available directions in which the mobile robot can move: forward, backward, left, right, forward-left, forward-right, backward-left, and backward-right.

When you focus your attention on one of these neurotags using the NextMind device, a command will be transmitted from the Unity application to the mobile robot through the ROS nodes. This command will prompt the robot to perform the associated movement.

## Future Works
Plans for expanding and improving the project will be added soon.

## Authors and Acknowledgment
This project is authored by Anabel Díaz Labrador. I'd like to express my deep gratitude to several important individuals in my life who have provided me with invaluable support during the development of this thesis.

First and foremost, I owe a great deal to my boyfriend. As my life and academic partner, he has been there every step of the way throughout this journey, providing unwavering support, patience, and understanding. His contributions have been invaluable to the completion of this project.

Next, my sincere thanks go to my parents for their continuous encouragement and belief in me.

I am also grateful to my academic tutor, Nacho, for his guidance and expertise that greatly contributed to my project.

Finally, a big thanks to all of my friends who have put up with me throughout this process.

## License
This project is licensed under the GNU General Public License Version 3, dated 29 June 2007. For more information, please see the LICENSE file in this repository or visit https://www.gnu.org/licenses/gpl-3.0.html.
