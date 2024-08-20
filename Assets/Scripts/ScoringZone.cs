using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour {

    public EventTrigger.TriggerEvent scoreTrigger;

    void OnCollisionEnter2D(Collision2D collision) {
        if (!collision.gameObject.TryGetComponent<Ball>(out var ball)) return;

        BaseEventData eventData = new BaseEventData(EventSystem.current);
        scoreTrigger.Invoke(eventData);
    }

}
