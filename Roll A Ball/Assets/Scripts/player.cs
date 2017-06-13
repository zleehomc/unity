using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {
	private Rigidbody rd;
    public int force = 5;
    private int score = 0;
    public Text text;
    public GameObject winText;


	// Use this for initialization
	void Start () {
        rd = GetComponent<Rigidbody>();
        text.text = "0";
    }
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rd.AddForce(new Vector3(h,0,v) * force);
    }
   /* void OnCollisionEnter(Collision collision){
        //collision.collider//获取碰撞到的游戏物体身上的 Collider组件
        // string name = collision.collider.name;
        //print(name);
        if (collision.collider.tag == "PickUp"){
            Destroy(collision.collider.gameObject);
        }

    }*/
    void OnTriggerEnter(Collider collider){
        if (collider.tag == "PickUp"){
            score++;
            text.text = score.ToString();       
            Destroy(collider.gameObject);
            if(score == 7){
                winText.SetActive(true);
            }
        }


    }
}

