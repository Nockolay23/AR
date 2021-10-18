using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class NewBehaviourScript : MonoBehaviour
{

    private Vector2 TouchPosition;
    private ARRaycastManager ARRaycastManagerScript;
    public GameObject ObjectOfSpawn;
    void Start()
    {
        ARRaycastManagerScript = FindObjectOfType<ARRaycastManager>();
        Touch touch = Input.GetTouch(0);
        TouchPosition = touch.position;
    }

    // Update is called once per frame
    void Update()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        Touch touch = Input.GetTouch(0);
        TouchPosition = touch.position;
        ARRaycastManagerScript.Raycast(TouchPosition, hits, TrackableType.Planes);
    }
}
