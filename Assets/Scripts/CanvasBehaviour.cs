using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasBehaviour : MonoBehaviour
{
    public GameObject GameOver = null;
    public GameObject YouWin = null;
    public GameObject player = null;
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

    public void GameOverEvent()
    {
        GameOver.SetActive(true);
    }

    public void WinEvent()
    {
        YouWin.SetActive(true);
    }

    public void LifesCanvasUpdate(int lifes)
    {
        if (lifes == 3)
        {
            life1.SetActive(true);
            life2.SetActive(true);
            life3.SetActive(true);

        } else if (lifes == 2)
        {
            life1.SetActive(true);
            life2.SetActive(true);
            life3.SetActive(false);
        } else if (lifes == 1)
        {
            life1.SetActive(true);
            life2.SetActive(false);
            life3.SetActive(false);
        } else if (lifes == 0)
        {
            life1.SetActive(false);
            life2.SetActive(false);
            life3.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
