using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class parkingScript : MonoBehaviour
{
    public pannelController controller1; //variable storing refrence of pannelcontroller
    bool gameEnded; //to hold flag 
   // public static parkingScript instance;
    
   
    void Start()
    {
        //finding pannelcontroller through script
        controller1 = GameObject.Find("PannelController").GetComponent<pannelController>();
       //deactivating parking pannel in start of game
        controller1.parkingPannel.SetActive(false);

    }

    //slider must decrease its value gradually but iff car is colliding with end point
    //using onCollision stay method gives facility to detect collision continuously 
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "car")
        {
            //gradually increasing value of slider
            controller1.LoadingImage.fillAmount+=Time.deltaTime;
            //if slider's fill amount is filled now what 
            if(controller1.LoadingImage.fillAmount==1 && !gameEnded)
            {
                //loadimage must be dectivated 
                controller1.LoadingImage.enabled=false;
                //gamewin pannel show 
                controller1.gameWinpannel.SetActive(true);
                //flag the gameEnded variable true
                gameEnded= true;
                //now change the level once clicked on next level 
                GameManager.currentLevel += 1;
                
                
            }
        }
       
    }
    //what if we collide then move away ,To overcome this situation we used following
    private void OnCollisionExit(Collision collision)
    {
        //onCollisionExit facilitates when car leaves it collision position 
        if (collision.gameObject.tag == "car")
        {
            //slider amount must come back to 0 so when again collision happens it start with 0
            controller1.LoadingImage.fillAmount = 0;
        }
    }
}


