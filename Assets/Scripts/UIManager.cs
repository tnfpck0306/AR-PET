using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject mainmenuUI; // Mainmenu UI

    public void ClickButton()
    {
        mainmenuUI.SetActive(false);
    }
}
