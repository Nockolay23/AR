using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class program : MonoBehaviour
{
    private Vector2 TouchPosition;
    private ARRaycastManager ARRaycastManagerScript;
    public GameObject[] ObjectOfSpawn = new GameObject[3];
    public Text text;
    string[] txtcheck = new string[] { "Бутылка", "Стакан" };
    int i = 0;


    void Start()
    {

        ARRaycastManagerScript = FindObjectOfType<ARRaycastManager>();
        Touch touch = Input.GetTouch(0);
        TouchPosition = touch.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            List<ARRaycastHit> hits = new List<ARRaycastHit>();
            Touch touch = Input.GetTouch(0);
            TouchPosition = touch.position;
            ARRaycastManagerScript.Raycast(TouchPosition, hits, TrackableType.Planes);
            if (i > 2) i = 0;
            Instantiate(ObjectOfSpawn[i], hits[0].pose.position, new Quaternion(ObjectOfSpawn[i].transform.rotation.x,1f, ObjectOfSpawn[i].transform.rotation.z,1f));
            text.text = txtcheck[i];
            i++;
        }
        
    }
   
}
