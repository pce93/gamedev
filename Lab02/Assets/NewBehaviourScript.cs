using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    private Vector3 target;
    public float speed = 50.0f;
   
	// Use this for initialization
	void Start () {
        target = transform.position;

    }

    // Update is called once per frame
    void Update() {
        var MousePos = Input.mousePosition;

        /*Vector3 velocity = new Vector3();
        var MousePos = Input.mousePosition;
        var destination = Camera.main.ScreenToWorldPoint(MousePos);
        var path = destination;*/

        if (Input.GetMouseButtonDown(0))
        {
            MousePos = Input.mousePosition;
            target = Camera.main.ScreenToWorldPoint(MousePos);
            target.z = 0;

            /*destination = Camera.main.ScreenToWorldPoint(MousePos);
            destination.z = 0;
            target = destination;
            Vector3 v = new Vector2(transform.position.x, transform.position.y);
            Vector3 vn = new Vector2();
            path = destination - v;
            vn.x = path.x / path.magnitude;
            vn.y = path.y / path.magnitude;
            velocity = vn;*/
            

        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);


    }
}


