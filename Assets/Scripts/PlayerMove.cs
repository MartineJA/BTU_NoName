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


    [SerializeField]
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        rGB = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Fire3"))
        {
            Debug.Log("Hit");
            animator.SetBool("Hit", true);
        }
       

    }


    private void FixedUpdate()
    {
        rGB.MovePosition(rGB.position + direction * speed * Time.fixedDeltaTime) ;
    }




}
