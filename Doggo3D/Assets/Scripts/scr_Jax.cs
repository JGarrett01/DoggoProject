﻿using UnityEngine;
using System.Collections;
using Fungus;

public class scr_Jax : MonoBehaviour {

	public scr_PlayerController playerController;
	public bool hasBall = false;
	public GameObject inMouth;
    public bool hasCompleted = false;
    public float timer = 2.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
		
		inMouth = playerController.currPickup; 
		

        if (inMouth.tag == "TennisBall" && playerController.currPickup != null)
        {

            hasBall = true;

        }

        if(hasCompleted == true)
        {

            timer -= Time.deltaTime;


        }

       

    }

	void Interactions()
	{

        hasCompleted = true;

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && hasBall == false && hasCompleted == false) 
		{
			Fungus.Flowchart.BroadcastFungusMessage ("JaxHello");
		}




		if (other.gameObject.tag == "Player" && hasBall == true && hasCompleted == false) 
		{
			Fungus.Flowchart.BroadcastFungusMessage ("Jax");
            Interactions();
           
		}



        if (other.gameObject.tag == "Player" && hasCompleted == true && timer <= 0)
        {
            Fungus.Flowchart.BroadcastFungusMessage("Jax3");
        }

    }
}
