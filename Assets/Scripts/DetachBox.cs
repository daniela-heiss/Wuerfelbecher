using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetachBox : MonoBehaviour
{
   void OnTriggerExit (Collider other){
        Debug.Log("Dice fell out");
        other.transform.parent = null;
   }
}
