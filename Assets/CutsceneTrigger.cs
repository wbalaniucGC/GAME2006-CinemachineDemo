using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneTrigger : MonoBehaviour
{
    public PlayableDirector timeline;

    public void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Player") && Input.GetKey(KeyCode.E))
        {
            timeline.enabled = true;
        }
    }
}
