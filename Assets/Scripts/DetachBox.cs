using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetachBox : MonoBehaviour
{  
   void OnTriggerExit (Collider other){
        //Debug.Log("Dice fell out");
        other.transform.parent = null;
        PhysicsController.ShakingRigidbodies.Remove(other.attachedRigidbody);
        other.GetComponent<DiceCalc>().findUpperVal();
   }

   void OnTriggerEnter(Collider other)
   {
      PhysicsController.ShakingRigidbodies.Add(other.attachedRigidbody);
      //Debug.Log("Dice added to list");
   }
}
