using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 1.5f;
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey(KeyCode.A))
        {
            Camera.main.transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            Camera.main.transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Camera.main.transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Camera.main.transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
