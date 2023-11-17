using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rGB;
    private Vector2 direction;

    [SerializeField]
    private float speed = 5f;

    public int score = 3;


    // Start is called before the first frame update
    void Start()
    {
       rGB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }


    private void FixedUpdate()
    {
        rGB.MovePosition(rGB.position + direction * speed * Time.fixedDeltaTime) ;
    }




}
