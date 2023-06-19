using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LidSpawn : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Lid;
    void Start()
    {
        Lid.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {   
            //Debug.Log("Touch");
            Lid.SetActive(true);
        } else {
           // Debug.Log("No Touch");
            Lid.SetActive(false);
        }
        
    }
}
