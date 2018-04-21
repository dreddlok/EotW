using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Survivor : MonoBehaviour {

	public float speed = 3;
    public int health = 5;
    public int strength = 4;
    public string pawnName = "Survivor";
    public Vector3 targetPosition;

    public bool selected;

    public Sprite normalSprite;
    public Sprite selectedSprite;

	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = -5;
            if (selected)
            {
                GetComponent<SpriteRenderer>().sprite = selectedSprite;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = normalSprite;
            }
        }

        if (selected)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }

    private void OnMouseDown()
    {
        selected = !selected;
    }
}
