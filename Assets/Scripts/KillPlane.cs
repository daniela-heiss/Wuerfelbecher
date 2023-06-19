using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlane : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < Spawndice.CreatedDice.Count; i++){
            if (Spawndice.CreatedDice[i] == other.gameObject){
                Destroy(Spawndice.CreatedDice[i]);
                Spawndice.CreatedDice.RemoveAt(i);
            }
        } 
    }
}
