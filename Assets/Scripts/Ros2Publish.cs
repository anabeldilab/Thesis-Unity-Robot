using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ROS2;


public class Ros2Publish : MonoBehaviour {
  private Ros2Start ros2Talker;
  private IPublisher<std_msgs.msg.Int32> action_pub;
  int n;

  void Update() {
    if (ros2Talker == null) {
      ros2Talker = GetComponent<Ros2Start>();
    }
  }

  public void OnButtonCancelPress() {
    n++;
    Debug.Log("Neurotag Cancel activated " + n + " times.");
    if(ros2Talker != null && ros2Talker.action_pub != null) {
      std_msgs.msg.Int32 msg = new std_msgs.msg.Int32();
      msg.Data = 0;
      ros2Talker.action_pub.Publish(msg);
    }
  }

  public void OnButtonForwardPress() {
    n++;
    Debug.Log("Neurotag activated " + n + " times.");
    if(ros2Talker != null && ros2Talker.action_pub != null) {
      std_msgs.msg.Int32 msg = new std_msgs.msg.Int32();  
      msg.Data = 8;
      ros2Talker.action_pub.Publish(msg);
    }
  }

  public void OnButtonRightPress() {
    n++;
    Debug.Log("Neurotag activated " + n + " times.");
    if(ros2Talker != null && ros2Talker.action_pub != null) {
      std_msgs.msg.Int32 msg = new std_msgs.msg.Int32();
      msg.Data = 9;
      ros2Talker.action_pub.Publish(msg);
    }
  }

  public void OnButtonBackwardPress() {
    n++;
    Debug.Log("Neurotag activated " + n + " times.");
    if(ros2Talker != null && ros2Talker.action_pub != null) {
      std_msgs.msg.Int32 msg = new std_msgs.msg.Int32();
      msg.Data = 2;
      ros2Talker.action_pub.Publish(msg);
    }
  }

  public void OnButtonLeftPress() {
    n++;
    Debug.Log("Neurotag activated " + n + " times.");
    if(ros2Talker != null && ros2Talker.action_pub != null) {
      std_msgs.msg.Int32 msg = new std_msgs.msg.Int32();
      msg.Data = 7;
      ros2Talker.action_pub.Publish(msg);
    }
  }

  public void OnButtonTotalLeftPress() {
    n++;
    Debug.Log("Neurotag activated " + n + " times.");
    if(ros2Talker != null && ros2Talker.action_pub != null) {
      std_msgs.msg.Int32 msg = new std_msgs.msg.Int32();
      msg.Data = 4;
      ros2Talker.action_pub.Publish(msg);
    }
  }

  public void OnButtonTotalRightPress() {
    n++;
    Debug.Log("Neurotag activated " + n + " times.");
    if(ros2Talker != null && ros2Talker.action_pub != null) {
      std_msgs.msg.Int32 msg = new std_msgs.msg.Int32();
      msg.Data = 6;
      ros2Talker.action_pub.Publish(msg);
    }
  }
}
