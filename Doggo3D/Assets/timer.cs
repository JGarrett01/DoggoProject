using UnityEngine;
using System.Collections;
using Fungus;

public class timer : MonoBehaviour {

    public float time = 30;
    public float starttimer = 2;
    public scr_GameController gameController;


	// Use this for initialization
	void Start () {



        




	}
	
	// Update is called once per frame
	void Update () {
        time = time - Time.deltaTime;
        starttimer = starttimer -= Time.deltaTime;

        if (time <= 0)
        {

            Fungus.Flowchart.BroadcastFungusMessage("FetchCall");
            time = 30;


        }

        


    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "TennisBall" && starttimer <= 0)
        {
            Fungus.Flowchart.BroadcastFungusMessage("Fetched");
            time = 30;

        }

    }
}
