using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ROS2;


public class Ros2Publish : MonoBehaviour {
  private Ros2Start ros2Talker;
  private IPublisher<std_msgs.msg.Header> action_pub;
  int n;

  void Update() {
    if (ros2Talker == null) {
      ros2Talker = GetComponent<Ros2Start>();
    }
  }

  public void OnButtonConnectPress() {
    n++;
    Debug.Log("Neurotag Connect activated " + n + " times.");
    if(ros2Talker != null && ros2Talker.action_pub != null) {
      std_msgs.msg.Header msg = new std_msgs.msg.Header();
      msg.Frame_id = "CON_/STA";
      ros2Talker.action_pub.Publish(msg);
    }
  }

  public void OnButtonStartAPPress() {
    n++;
    Debug.Log("Neurotag StartAP activated " + n + " times.");
    if(ros2Talker != null && ros2Talker.action_pub != null) {
      std_msgs.msg.Header msg = new std_msgs.msg.Header();
      msg.Frame_id = "CON_/SAP";
      ros2Talker.action_pub.Publish(msg);
    }
  }

  public void OnButtonDisconnectPress() {
    n++;
    Debug.Log("Neurotag Disconnect activated " + n + " times.");
    if(ros2Talker != null && ros2Talker.action_pub != null) {
      std_msgs.msg.Header msg = new std_msgs.msg.Header();
      msg.Frame_id = "CON_/DIS";
      ros2Talker.action_pub.Publish(msg);
    }
  }

  public void OnButtonForwardPress() {
    n++;
    Debug.Log("Neurotag activated " + n + " times.");
    if(ros2Talker != null && ros2Talker.action_pub != null) {
      std_msgs.msg.Header msg = new std_msgs.msg.Header();  
      msg.Frame_id = "ACT_/A1";
      ros2Talker.action_pub.Publish(msg);
    }
  }

  public void OnButtonForwardRightPress() {
    n++;
    Debug.Log("Neurotag activated " + n + " times.");
    if(ros2Talker != null && ros2Talker.action_pub != null) {
      std_msgs.msg.Header msg = new std_msgs.msg.Header();
      msg.Frame_id = "ACT_/A2";
      ros2Talker.action_pub.Publish(msg);
    }
  }

  public void OnButtonRightPress() {
    n++;
    Debug.Log("Neurotag activated " + n + " times.");
    if(ros2Talker != null && ros2Talker.action_pub != null) {
      std_msgs.msg.Header msg = new std_msgs.msg.Header();
      msg.Frame_id = "ACT_/A3";
      ros2Talker.action_pub.Publish(msg);
    }
  }

  public void OnButtonBackwardRightPress() {
    n++;
    Debug.Log("Neurotag activated " + n + " times.");
    if(ros2Talker != null && ros2Talker.action_pub != null) {
      std_msgs.msg.Header msg = new std_msgs.msg.Header();
      msg.Frame_id = "ACT_/A4";
      ros2Talker.action_pub.Publish(msg);
    }
  }

  public void OnButtonBackwardPress() {
    n++;
    Debug.Log("Neurotag activated " + n + " times.");
    if(ros2Talker != null && ros2Talker.action_pub != null) {
      std_msgs.msg.Header msg = new std_msgs.msg.Header();
      msg.Frame_id = "ACT_/A5";
      ros2Talker.action_pub.Publish(msg);
    }
  }

  public void OnButtonBackwardLeftPress() {
    n++;
    Debug.Log("Neurotag activated " + n + " times.");
    if(ros2Talker != null && ros2Talker.action_pub != null) {
      std_msgs.msg.Header msg = new std_msgs.msg.Header();
      msg.Frame_id = "ACT_/A6";
      ros2Talker.action_pub.Publish(msg);
    }
  }

  public void OnButtonLeftPress() {
    n++;
    Debug.Log("Neurotag activated " + n + " times.");
    if(ros2Talker != null && ros2Talker.action_pub != null) {
      std_msgs.msg.Header msg = new std_msgs.msg.Header();
      msg.Frame_id = "ACT_/A7";
      ros2Talker.action_pub.Publish(msg);
    }
  }

  public void OnButtonForwardLeftPress() {
    n++;
    Debug.Log("Neurotag activated " + n + " times.");
    if(ros2Talker != null && ros2Talker.action_pub != null) {
      std_msgs.msg.Header msg = new std_msgs.msg.Header();
      msg.Frame_id = "ACT_/A8";
      ros2Talker.action_pub.Publish(msg);
    }
  }
}
