﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class scr_OwnerController : MonoBehaviour {

	public float thrust;
	public Rigidbody rb;
	public List<GameObject> spheres;
	public GameObject ballLaunch;
	public float ballTimer = 3f;
    public GameObject ownerRot;



	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		FindAllSpheres ();
		Debug.Log(spheres.Count);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
        thrust = Random.Range(1500, 4000);

        if (other.gameObject.tag == "TennisBall") 
		{
			ownerRot.transform.Rotate (new Vector3(ownerRot.transform.rotation.x, Random.Range (-40, 40), ownerRot.transform.rotation.z));
			rb = other.GetComponent<Rigidbody> ();
			other.gameObject.transform.position = ballLaunch.transform.position;

           
            rb.AddForce(transform.forward * thrust);


		}
	}
		


	void FindAllSpheres () {
		GameObject[] sphoreos = UnityEngine.Object.FindObjectsOfType<GameObject>() ;
		for(var i = 0; i < sphoreos.Length; ++i)
		{
			if(sphoreos[i].name == "Sphere")
			{
				spheres.Add (sphoreos [i]);
			}
		}
	}
}
