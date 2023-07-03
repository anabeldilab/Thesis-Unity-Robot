using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorCounter : MonoBehaviour {
  public static ErrorCounter Instance { get; private set; }

  private int errorCount = 0;
  public TMPro.TextMeshProUGUI errorNumText;

  void Awake() {
    if (Instance != null) {
      Destroy(gameObject);
      return;
    }
    Instance = this;
    DontDestroyOnLoad(gameObject);
  }

  void Update() {
    if (Input.GetKeyDown(KeyCode.M)) {
      AddError();
    }
    if (Input.GetKeyDown(KeyCode.N)) {
      SubError();
    }
    errorNumText.text = errorCount.ToString();
  }

  public void AddError() {
    errorCount++;
  }

  public void SubError() {
    if (errorCount > 0) {
      errorCount--;
    }
  }
}
