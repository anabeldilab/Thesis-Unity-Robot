using UnityEngine;
using UnityEngine.Networking;
using TMPro;
using System.Collections;

public class ResponseRestApiCamera : MonoBehaviour {

  public CameraInfo cameraInfo;
  public TMPro.TextMeshProUGUI responseText;

  void Start() {
    StartCoroutine(GetRequest(cameraInfo.GetUrlApiRest()));
  }

  IEnumerator GetRequest(string uri) {
    using (UnityWebRequest webRequest = UnityWebRequest.Get(uri)) {
      // Request and wait for the desired page.
      yield return webRequest.SendWebRequest();

      string[] pages = uri.Split('/');
      int page = pages.Length - 1;

      switch (webRequest.result) {
        case UnityWebRequest.Result.ConnectionError:
        case UnityWebRequest.Result.DataProcessingError:
          responseText.text = pages[page] + ": Error: " + webRequest.error;
          break;
        case UnityWebRequest.Result.ProtocolError:
          responseText.text = pages[page] + ": HTTP Error: " + webRequest.error;
          break;
        case UnityWebRequest.Result.Success:
          responseText.text = pages[page] + ":\nReceived: " + webRequest.downloadHandler.text;
          break;
      }
    }
  }
}

