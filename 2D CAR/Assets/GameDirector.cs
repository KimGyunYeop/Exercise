using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    GameObject car, flag, distance;
	// Use this for initialization
	void Start () {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 dis = car.transform.position - flag.transform.position;

        float length = dis.magnitude;
        distance.GetComponent<Text>().text = "남은거리 : " + length.ToString("F2") + "m";
	}
}
