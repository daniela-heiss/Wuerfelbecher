using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDiceMenu : MonoBehaviour
{
    public GameObject MenuOrigPos, MenuActivePos, MenuPanel, InvisibleMoveMenuButton;
    public float moveSpeed;
    private float tempMenuPos;
    private bool MoveMenuPanel, MoveMenuPanelBack, MenuButtonInvisibility;

    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.transform.position = MenuOrigPos.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(MoveMenuPanel)
        {
            MenuPanel.transform.position = Vector3.Lerp(MenuPanel.transform.position, MenuActivePos.transform.position, moveSpeed * Time.deltaTime);

            if(MenuPanel.transform.localPosition.x == tempMenuPos)
            {
                MoveMenuPanel = false;
                MenuPanel.transform.position = MenuActivePos.transform.position;
                tempMenuPos = -9999999999999.99f;   //Setting impossible position so if we use the variable later you can instantly see if the value hasn't changed to the expected value
            }
            if(MoveMenuPanel)
            {
                tempMenuPos = MenuPanel.transform.position.x;
            }
        }

        if(MoveMenuPanelBack)
        {
            MenuPanel.transform.position = Vector3.Lerp(MenuPanel.transform.position, MenuOrigPos.transform.position, moveSpeed * Time.deltaTime);

            if(MenuPanel.transform.localPosition.x == tempMenuPos)
            {
                MoveMenuPanelBack = false;
                MenuPanel.transform.position = MenuOrigPos.transform.position;
                tempMenuPos = -9999999999999.99f;
            }
            if(MoveMenuPanelBack)
            {
                tempMenuPos = MenuPanel.transform.position.x;
            }
        }

        if(MenuButtonInvisibility)
        {
            InvisibleMoveMenuButton.SetActive(false);
        } else {
            InvisibleMoveMenuButton.SetActive(true);
        }
    }

    public void movePanel()
    {
        MoveMenuPanelBack = false;
        MoveMenuPanel = true;
        MenuButtonInvisibility = true;
    }

    public void movePanelBack()
    {
        MoveMenuPanel = false;
        MoveMenuPanelBack = true;
        MenuButtonInvisibility = false;
    }
}
