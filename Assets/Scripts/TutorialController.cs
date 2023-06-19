using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    public GameObject TutorialManager;
    void Start()
    {
        TutorialManager.SetActive(false);
    }

    public void startTutorial(){
        TutorialManager.SetActive(true);
        Tutorial.TutorialFinished = false;
    }

    void Update()
    {
        if(Tutorial.TutorialFinished == true){
            TutorialManager.SetActive(false);
        }
    }
}
