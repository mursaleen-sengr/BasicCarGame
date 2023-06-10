using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class collision : MonoBehaviour
{
    //pannel controller is the script that holds all the pannels.
    public pannelController controller;
   



    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log("start running");
       // controller = GetComponent<pannelController>();
       // controller=GetComponent<pannelController>();
       //finding pannel controller by script instead of drag&drop
     controller=GameObject.Find("PannelController").GetComponent<pannelController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {

          //if there is collision on car and tag is gameover than show the following pannel
          
        if (collision.gameObject.tag == "GameOver")
            controller.gameOverPannel.SetActive(true);


    }
  public  void tryagain()
    {
        SceneManager.LoadScene(1);
    }
}
