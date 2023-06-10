using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class buttoncontroller : MonoBehaviour
{
    //main menu script that enables the gameplay 
    [SerializeField] private string newlevel = "Level1";
   public void startGame()
    {
        SceneManager.LoadScene(newlevel);
    }

}
