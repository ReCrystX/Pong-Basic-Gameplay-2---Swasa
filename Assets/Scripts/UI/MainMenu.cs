using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("Game");
        Debug.Log("Created by ReCrystX");
    }

    public void GetCredits(){
        SceneManager.LoadScene("Credits");
    }
}