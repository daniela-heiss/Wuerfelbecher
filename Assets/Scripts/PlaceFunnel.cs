using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using EnhancedTouch = UnityEngine.InputSystem.EnhancedTouch;

public class PlaceFunnel : MonoBehaviour
{
        public GameObject moveobj;
        public bool disabler = false;
        private ARRaycastManager ARRaycastManager;
        private ARPlaneManager ARPlaneManager;
        private List<ARRaycastHit> hits = new List<ARRaycastHit>();

        public void Click(){
                if (disabler == true){
                        disabler = false;
                } else if (disabler == false){
                        disabler = true;
                }
        }

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
                if (disabler == false){
                if (ARRaycastManager.Raycast(finger.currentTouch.screenPosition, hits, TrackableType.PlaneWithinPolygon)){
                        Pose pose = hits[0].pose;
                        moveobj.transform.position = new Vector3(pose.position.x, pose.position.y, pose.position.z);
                }
                }
        }
}