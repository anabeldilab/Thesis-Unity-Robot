# Bachelor's Degree Thesis: Control of Mobile Robotic Devices using BCI - Unity Mobile Robot Part

## Introduction

This repository is part of my Bachelor's Degree Thesis project, titled "Control of Mobile Robotic Devices using BCI". The aim of this project is to control a mobile robotic device through a Brain-Computer Interface (BCI). The project is split into two main parts: the ROS nodes and a Unity application. This repository focuses on the Unity application, an essential component for the user interface of the BCI control.

The Unity application serves as the primary interface for the user, enabling them to control a mobile robotic device through BCI. The choice of Unity was influenced by its compatibility with the NextMind device, a BCI sensor. Notably, the NextMind device currently supports development only through Unity, making it the ideal choice for this project.

## Time Invested

The creation, development, and refinement of this project required substantial time and effort. I spent several months perfecting the application, accounting for different potential user interactions, and ensuring robust control of the mobile robotic device. I am proud of the time and effort I invested in this project and am excited to share my work.

## Implementation

This Unity application is designed to work in tandem with ROS (Robot Operating System) nodes running on a separate system, in order to control the mobile robotic device. It uses the Micro-ROS-Agent, an adapted version of ROS 2 for microcontrollers, to enable communication between the Unity application and the ROS nodes.

## Unity Application
The Unity application I developed for this part presents eight neurotags to the user. Each neurotag corresponds to a specific command that will be sent to a mobile robot. The application uses the ROS2-For-Unity library to ensure effective communication between the Unity application and the ROS nodes controlling the mobile robot.

## Version
This project uses Unity version 2022.3.3f1.

## Prerequisites
To run this project, you will need:
- Unity 2022.3.3f1
- NextMind SDK installed and set up in Unity
- ROS2-For-Unity library installed in Unity

## Installation
Detailed instructions on how to install and setup the project will be added soon.

## Usage
First, it is necessary to take into account that you have to go to the Scenes folder of the project and open the main scene, in this case, "SampleScene".

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
