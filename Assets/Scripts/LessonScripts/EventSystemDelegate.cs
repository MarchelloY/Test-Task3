using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(EventTrigger))]
public class EventSystemDelegate : MonoBehaviour
{
    [SerializeField] private EventTrigger eventTrigger;

    public void Reset()
    {
        eventTrigger = GetComponent<EventTrigger>();
    }

    public void Start()
    {
        var entry = new EventTrigger.Entry
        {
            eventID = EventTriggerType.PointerDown
        };
        entry.callback.AddListener(data => OnPointerDownDelegate((PointerEventData) data));
        eventTrigger.triggers.Add(entry);
    }

    public void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject()) Debug.Log("kek");
    }

    private void OnPointerDownDelegate(PointerEventData data)
    {
        transform.localScale = Vector3.one * 1.2f;
    }
}