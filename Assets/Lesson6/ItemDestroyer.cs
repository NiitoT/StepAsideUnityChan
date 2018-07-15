using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour {

    private GameObject unitychan;

	// Use this for initialization
	void Start () {
        unitychan = GameObject.Find("unitychan");

	}
	
	// Update is called once per frame
	void Update () {
        if (unitychan.transform.position.z > this.gameObject.transform.position.z + 10) {

            Destroy(this.gameObject);

        }

	}
}
