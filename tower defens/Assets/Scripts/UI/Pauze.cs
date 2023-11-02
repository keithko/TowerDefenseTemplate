using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pauze : MonoBehaviour
{
    public GameObject PauzMenu;
    private bool ispaused = false;
    void Start()
    {
        PauzMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (ispaused)
            {
                ResumeGame();
                Debug.Log("resume");
            }
            else
            {
                PauseGame();
                Debug.Log("ISpauze");
            }
        }
    }
     void PauseGame()
    { 
        PauzMenu.SetActive(true);
        Time.timeScale = 0f;
        ispaused= true;
        Debug.Log("pause");
    }

     void ResumeGame()
    {
        PauzMenu.SetActive(false);
        Time.timeScale = 1f;
        ispaused = false;
        Debug.Log("resume");
    }
}
