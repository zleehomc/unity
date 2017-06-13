using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour {
    private Transform firePosition;
    public GameObject shellPrefab;
    public KeyCode fireKey = KeyCode.Space;
    public float shellSpeed = 10;
    // Use this for initialization
    void Start() {
        firePosition = transform.Find("FirePosition");
    }
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(fireKey)) {
            GameObject go=GameObject.Instantiate(shellPrefab, firePosition.position, firePosition.rotation) ;
            go.GetComponent<Rigidbody>().velocity=go.transform.forward*shellSpeed;
        }
    }
}
