using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class OpenDoorCutscene : MonoBehaviour
{
    private PlayableDirector director;
    public bool isCloseEnough = false;

    // Start is called before the first frame update
    void Start()
    {
        director = GetComponent<PlayableDirector>();
    }

    // Two methods to start your cutscene.
    // Method 1: Enable the component
    /*
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("MainPlayer") && Input.GetKeyDown(KeyCode.E)) 
        {
            director.enabled = true;
        }
    }
    */

    // Method 2: Just call Play() - Preferred
    /*
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("MainPlayer") && Input.GetKeyDown(KeyCode.E))
        {
            director.Play();
        }
    }
    */
}
