using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ros2SubscriberHandler : MonoBehaviour
{
  public static Ros2SubscriberHandler Instance { get; private set; }

  public Ros2Start ros2Subscriber;
  public bool CameraEnabled { get; set; }
  public string CameraIP { get; set; }
  public bool ESP32Enabled { get; set; }

  private void Awake() {
    if (Instance != null) {
      Destroy(gameObject);
      return;
    }
    Instance = this;
    DontDestroyOnLoad(gameObject);
  }

  void Start() {
    CameraEnabled = true;
    CameraIP = "192.168.4.4";
    ESP32Enabled = true;
  }

  // Manage the event of receiving a message
  void OnEnable() {
    if (ros2Subscriber == null) {
      ros2Subscriber = GetComponent<Ros2Start>();
      if (ros2Subscriber != null) {
        ros2Subscriber.OnMessageReceived += ProcessReceivedMessage;
      }
    } else {
      ros2Subscriber.OnMessageReceived += ProcessReceivedMessage;
    }
  }

  void ProcessReceivedMessage(std_msgs.msg.Int32 msg) {
    CameraEnabled = true;
    CameraIP = "192.168.4.4";
  }
}
