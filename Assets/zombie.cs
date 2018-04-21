using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class zombie : MonoBehaviour {

    public float moveTime;
    public float minMoveTime;
    public float maxMoveTime;
    public float waitTime;
    public float minWaitTime;
    public float maxWaitTime;
    public Vector3 moveDirection;
    // Use this for initialization

	void Start () {
        moveTime = Random.Range(minMoveTime, maxMoveTime);
        moveDirection = Random.insideUnitCircle;
	}
	
	// Update is called once per frame
	void Update () {
		if (moveTime > 0 )
        {
            transform.position += moveDirection * Time.deltaTime;
            moveTime -= Time.deltaTime * 1;
        }
        else 
        {
            if (waitTime <= 0)
            {
                moveTime = Random.Range(minMoveTime, maxMoveTime);
                moveDirection = Random.insideUnitCircle;
                waitTime = Random.Range(minWaitTime, maxWaitTime);
            }
            else
            {
                waitTime -= Time.deltaTime * 1;
            }
        }
	}
}
