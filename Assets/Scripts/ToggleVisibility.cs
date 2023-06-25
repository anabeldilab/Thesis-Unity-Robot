using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ToggleVisibility : MonoBehaviour
{
    public Button button1;
    public Button button2;

    void Start()
    {
        AddEventTrigger(button1, ToggleButtons);
        AddEventTrigger(button2, ToggleButtons);

        button1.gameObject.SetActive(true);
        button2.gameObject.SetActive(false);
    }

    void ToggleButtons(BaseEventData eventData)
    {
        button1.gameObject.SetActive(!button1.gameObject.activeSelf);
        button2.gameObject.SetActive(!button2.gameObject.activeSelf);
    }

    void AddEventTrigger(Button button, UnityAction<BaseEventData> action)
    {
        EventTrigger trigger = button.GetComponent<EventTrigger>() ?? button.gameObject.AddComponent<EventTrigger>();

        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener(action);

        trigger.triggers.Add(entry);
    }
}
