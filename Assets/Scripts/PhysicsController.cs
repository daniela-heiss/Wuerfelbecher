using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsController : MonoBehaviour
{
    public float ShakeForceMultiplier;
    //public Rigidbody[] ShakingRigidbodies;

    public static List <Rigidbody> ShakingRigidbodies = new List<Rigidbody>();

    public void ShakeRigidbodies (Vector3 deviceAcceleration)
    {
        foreach(var rigidbody in ShakingRigidbodies)
        {
            Debug.Log("Hello");
            rigidbody.AddForce(deviceAcceleration * ShakeForceMultiplier, ForceMode.Impulse);
        }    
    
    }
}
