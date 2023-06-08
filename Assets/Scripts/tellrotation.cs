using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tellrotation : MonoBehaviour
{
        public void tellRotation()
        {
                foreach (var dice in Spawndice.CreatedDice)
                {
                        Debug.Log("x:" + dice.transform.eulerAngles.x + "  y:" + dice.transform.eulerAngles.y + "  z:" + dice.transform.eulerAngles.z);                  
                }
        }
}
