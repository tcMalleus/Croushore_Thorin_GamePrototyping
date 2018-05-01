using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounceScript : MonoBehaviour {

    public float BounceForce;
    public Animator Anim;

    private Rigidbody2D _rigid;


    // Use this for initialization
    void Start () {

        _rigid = GetComponent<Rigidbody2D>();

        _rigid.AddForce(Vector2.up * BounceForce, ForceMode2D.Impulse);

	}

    // Update is called once per frame
    void Update() {

        if (Input.GetKey("space"))
        {
            Anim.SetTrigger("AccelerateTrigger");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BounceTop")
        {
            _rigid.velocity = Vector2.zero;
            _rigid.AddForce(Vector2.down * BounceForce, ForceMode2D.Impulse);
        }

        if (collision.gameObject.tag == "BounceBottom")
        {
            _rigid.velocity = Vector2.zero;
            _rigid.AddForce(Vector2.up * BounceForce, ForceMode2D.Impulse);
        }

        if (collision.gameObject.tag == "Kill")
        {
            Destroy(gameObject);
        }
    }

}
