using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class move : MonoBehaviour {

    public Camera myCam;
    //public float dist = 0;
    public FirstPersonController fps;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var dist = Vector3.Distance(Camera.main.transform.position, transform.position);
        transform.position = new Vector3(transform.position.x,dist,transform.position.z);

    }
}
