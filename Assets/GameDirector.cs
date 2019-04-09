using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    public AudioSource music;
    public AudioSource bark;
    GameObject hpGage;

	void Start () {
        this.hpGage = GameObject.Find("hpGage");
        music.loop = true;
        music.Play();
	}
	
	public void DecreaseHp () {
        this.hpGage.GetComponent<Image>().fillAmount -= 0.1f;
	}
}
