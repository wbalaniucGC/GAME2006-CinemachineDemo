using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;

    private Rigidbody2D rBody;
    private bool isRight = true;

    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");

        rBody.velocity = new Vector2(horiz * speed, rBody.velocity.y);
    }
}
