using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.SceneManagement;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject carPrefab;
    public GameObject[] levels; //this is an arry for the levels
    public levelManager[] levelsProp;


    public static int currentLevel; // holds the current level index

    public static GameManager instance;
    

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        foreach(GameObject go in levels)
        {
            go.gameObject.SetActive(false);
        }
        levels[currentLevel].gameObject.SetActive(true);
        Instantiate( carPrefab ,levelsProp[currentLevel].spawnpoint.position,levelsProp[currentLevel].spawnpoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void nextlevel()
    {
        SceneManager.LoadScene(1);
    }
}
[Serializable]
public class levelManager
{

    public Transform spawnpoint;
    
}