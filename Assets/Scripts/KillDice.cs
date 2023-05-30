using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillDice : MonoBehaviour
{
    public void Kill()
    {
        foreach(var dice in Spawndice.CreatedDice)
        {   
            Destroy(dice);
        }   
    }
}
