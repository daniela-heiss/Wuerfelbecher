using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using EnhancedTouch = UnityEngine.InputSystem.EnhancedTouch;

public class PlaceFunnel : MonoBehaviour
{
        [SerializeField]
        private GameObject prefab;

        private ARRaycastManager ARRaycastManager;
        private ARPlaneManager ARPlaneManager;
        private List<ARRaycastHit> hits = new List<ARRaycastHit>();

        private void Awake(){
                ARRaycastManager = GetComponent<ARRaycastManager>();
                ARPlaneManager = GetComponent<ARPlaneManager>();
        }

        private void OnEnable(){
                EnhancedTouch.EnhancedTouchSupport.Enable();
                EnhancedTouch.Touch.onFingerDown += FingerDown;
        }

        private void OnDisable(){
                EnhancedTouch.EnhancedTouchSupport.Disable();
                EnhancedTouch.Touch.onFingerDown -= FingerDown;
        }

        private void FingerDown(EnhancedTouch.Finger finger)       {
                if (finger.index != 0) return;

                if (ARRaycastManager.Raycast(finger.currentTouch.screenPosition, hits, TrackableType.PlaneWithinPolygon)){
                        Pose pose = hits[0].pose;
                        GameObject obj = Instantiate(prefab, pose.position, pose.rotation);
                }

        }
}