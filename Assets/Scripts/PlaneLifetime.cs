/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class PlaneLifetime : MonoBehaviour
{
    private ARPlaneManager planeManager;

    private void Awake(){
        planeManager = GetComponent<ARPlaneManager>();
    }

    void planeLifetimeExtension(){
        List<ARPlane> planeList = new List<ARPlane>();

        foreach (ARPlane plane in planeManager.trackables)
        {
            planeList.Add(plane);

            // Access plane properties or perform actions
            Debug.Log("Plane ID: " + plane.trackableId);
            Debug.Log("Plane Extents: " + plane.extents);

            // Modify plane properties as needed
            planeManager.maximumValidPlaneArea = 0.5f;
        }
    }
}*/
