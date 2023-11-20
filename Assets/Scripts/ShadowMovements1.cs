using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ShadowMovements : MonoBehaviour

      
{

    #region public

    [SerializeField]
    private float _movespeed = 10f;
    [SerializeField]
    private float _jumpForce = 200f;

    #endregion

    void Awake()
    {
        _rgbd = GetComponent<Rigidbody2D>();
        
    }
    void Start() 
    {
    }
    //Touche assignée pour le déplacement et le Saut 
    void Update()
    {
        _direction.x = Input.GetAxisRaw("Horizontal") * _movespeed;

        if (Input.GetButtonDown("Jump") )
        {
            _isJumping = true;
        }
    }
      
    void FixedUpdate()
    {
        _direction.y = _rgbd.velocity.y;

        if (_isJumping)
        {
            _direction.y = _jumpForce * Time.fixedDeltaTime;

            _isJumping = false;
        }
        _rgbd.velocity = _direction;
    }
    
    #region private
    private Vector2 _direction;
    private Rigidbody2D _rgbd;
    private bool _isJumping = false;
    #endregion

}

    
         

     




       

        


   



    

















