using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour {

    public GameObject ArrowPrefab;
    float delta = 0;
    float span = 1.0f;

	void Start () {
		
	}

    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(ArrowPrefab) as GameObject;
            // arrowPrefab을 바탕으로 인스턴스 생성

            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}