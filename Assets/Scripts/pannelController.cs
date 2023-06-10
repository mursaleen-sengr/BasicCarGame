using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class pannelController : MonoBehaviour
{
    public GameObject gameWinpannel; // variable holding gamewin pannel

    public GameObject gameOverPannel;// variable holding gameover pannel 

    public GameObject parkingPannel;//variable holding parking pannel

    public Image LoadingImage;//variable holding the sliderImage




    // Start is called before the first frame update
    void Start()
    {
        //when the game starts we want our pannels to be deactivate and activate when needed 
        gameWinpannel.SetActive(false);
        gameOverPannel.SetActive(false);
        parkingPannel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
