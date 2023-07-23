using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ROS2;
using System.Collections.Concurrent;

public class Ros2Start : MonoBehaviour {
  public static Ros2Start Instance { get; private set; }

  private ROS2UnityComponent ros2Unity;
  private ROS2Node ros2Node;
  public IPublisher<std_msgs.msg.Int32> action_pub;
  private ISubscription<std_msgs.msg.Int32> esp32_sub;

  public delegate void MessageReceivedHandler(std_msgs.msg.Int32 msg);
  public event MessageReceivedHandler OnMessageReceived;

  // Thread-safe queue for incoming messages
  public ConcurrentQueue<std_msgs.msg.Int32> messageQueue = new ConcurrentQueue<std_msgs.msg.Int32>();

  // Start is called before the first frame update
  void Start() {
    if (Instance != null) {
      Destroy(gameObject);
      return;
    }
    Instance = this;
    DontDestroyOnLoad(gameObject);

    Debug.Log("Starting ROS2 node");

    ros2Unity = GetComponent<ROS2UnityComponent>();
    if (ros2Unity.Ok()) {
      ros2Node = ros2Unity.CreateNode("ROS2UnityPublisherSubscriberNode");
      Debug.Log("Starting ROS2 node 2");
    } else {
      Debug.Log("Ros2Unity was not created OK");
    }

    if (ros2Unity.Ok()) {
      action_pub = ros2Node.CreatePublisher<std_msgs.msg.Int32>("action"); 
      esp32_sub = ros2Node.CreateSubscription<std_msgs.msg.Int32>("freertos_Int32_log", 
        msg => {
          Debug.Log("Unity listener heard: [" + msg.Data + "]");
          messageQueue.Enqueue(msg);
        });
      std_msgs.msg.Int32 msg = new std_msgs.msg.Int32();
      msg.Data = 0;
      Debug.Log(msg.Data);
      action_pub.Publish(msg);
    } else {
      Debug.Log("ROS2UnityComponent was not created OK");
    }
  }


  void Update() {
    while (messageQueue.TryDequeue(out std_msgs.msg.Int32 msg)) {
        OnMessageReceived?.Invoke(msg);
    }
  }
}
