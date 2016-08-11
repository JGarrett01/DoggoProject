using UnityEngine;
using System.Collections;
using Fungus;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scr_GameController : MonoBehaviour {

    public scr_Maple mapleScript;
    public scr_Jax jaxScript;
    public scr_Kiki kikiScript;
    public scr_Princess princessScript;
    public scr_Zeus zeusScript;
    public scr_Bear bearScript;

    public bool allDone = false;
    public float endTimer = 5.0f;

    public GUITexture FadeToBlack;

    public Light light1;

    public Light light2;

   

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (mapleScript.hasGreeted == true && jaxScript.hasCompleted == true && kikiScript.hasCompleted == true && princessScript.hasCompleted == true && zeusScript.hasGreeted == true && bearScript.hasGreeted == true)
        {

            allDone = true;


        }


        if(allDone == true)
        {


            Fungus.Flowchart.BroadcastFungusMessage("endGame");
            endTimer -= Time.deltaTime;

            FadeToBlack.color = Color.Lerp(Color.clear, Color.black, 4);

            if (endTimer <= 0)
            {

                //endGame here

                SceneManager.LoadScene("CreditScene");



            }
                

        }

        

    }
}
