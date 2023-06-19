using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PhysicsController))]
public class ShakeDetector : MonoBehaviour
{
    public float ShakeDetectionTreshold;
    public float MinShakeInterval;
    
    private float sqrShakeDetectionTreshold;    //sqr, da Vergleich mit sqrMagnitude
    private float timeSinceLastShake;
    
    private PhysicsController physicsController;
    
    
    void Start()
    {
        sqrShakeDetectionTreshold = Mathf.Pow(ShakeDetectionTreshold, 2);
        physicsController = GetComponent<PhysicsController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.acceleration.sqrMagnitude >= sqrShakeDetectionTreshold && Time.unscaledTime >= timeSinceLastShake + MinShakeInterval)
        {
            physicsController.ShakeRigidbodies(Input.acceleration);
            timeSinceLastShake = Time.unscaledTime; 
        }
        
    }
}
