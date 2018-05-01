using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour {

    public float MoveSpeed;

    private Rigidbody2D _rigid;

	// Use this for initialization
	void Start () {

        _rigid = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("space"))
        {
            _rigid.AddForce(Vector2.left * MoveSpeed, ForceMode2D.Impulse);
        }
    }
}
