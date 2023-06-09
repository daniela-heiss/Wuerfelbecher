using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Tutorial : MonoBehaviour
{
    public GameObject[] popUps;
    private int popUpIndex;
    public GameObject MenuMovement;
    public GameObject DiceBagButton;
    public GameObject RevertButton;
    public GameObject KillButton;
    
    public GameObject Sum;
    public GameObject SumBG;
    public GameObject TutorialBG;
    public GameObject TutorialButton;
    public static bool TutorialFinished;

    void OnEnable()
    {
        popUpIndex = 0;
        TutorialBG.SetActive(true);
        MenuMovement.SetActive(false);
        DiceBagButton.SetActive(false);
        RevertButton.SetActive(false);
        KillButton.SetActive(false);
        Sum.SetActive(false);
        SumBG.SetActive(false);
        TutorialButton.SetActive(false);

        GameObject.Find("XR Origin").GetComponent<ARPlaneManager>().enabled = false;
        foreach(var plane in GameObject.Find("XR Origin").GetComponent<ARPlaneManager>().trackables)
        {
            plane.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        for (int i = 0; i < popUps.Length; i++) {
            if (i == popUpIndex){
                popUps[i].SetActive(true);
            } else {
                popUps[i].SetActive(false);
            }
        }

        if(Input.touchCount > 0)
        {   
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began){
                switch(popUpIndex){
                    case 0:
                        DiceBagButton.SetActive(true);
                        MenuMovement.SetActive(true);
                        popUpIndex++;
                        break;
                    case 1:
                        RevertButton.SetActive(true);
                        popUpIndex++;
                        break;
                    case 2:
                        KillButton.SetActive(true);
                        popUpIndex++;
                        break;
                    case 3:
                        popUpIndex++;
                        break;
                    case 4: 
                        popUpIndex++;
                        break;
                    case 5:
                        popUpIndex++;
                        break;
                    case 6:
                        Sum.SetActive(true);
                        SumBG.SetActive(true);
                        popUpIndex++;
                        break;
                    case 7:
                        TutorialBG.SetActive(false);
                        TutorialButton.SetActive(true);
                        GameObject.Find("XR Origin").GetComponent<ARPlaneManager>().enabled = true;
                        popUpIndex++;
                        TutorialFinished = true;
                        break;
        }
            }
        }
    }
}
