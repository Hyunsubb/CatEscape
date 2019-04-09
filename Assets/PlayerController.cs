using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {



	void Start () {
		
	}

    public void LButtonDown()
    {
        if (transform.position.x >= -6)
            transform.Translate(-2f, 0, 0);
    }
    public void RButtonDown()
    {
        if (transform.position.x <= 6)
            transform.Translate(2f, 0, 0);
    }

	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -8)
               transform.Translate(-0.2f, 0, 0);

        if(Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 8)
            transform.Translate(0.2f, 0, 0);

        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <= 4)
            transform.Translate(0, 0.2f, 0);

        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >= -4)
            transform.Translate(0, -0.2f, 0);
    }
}
