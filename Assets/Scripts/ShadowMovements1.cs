using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class ShadowMovements : MonoBehaviour

      
{

    #region public
    public Transform _graphics;

    [SerializeField]
    AnimationCurve _jumpCurve;

    [SerializeField]
    float _jumpHeight = 3f;


    public float _speed = 0.5f;
    public Vector2 _direction;
    
    #endregion




    void Awake()
    {
        _rgbd = GetComponent<Rigidbody2D>();

        _graphics = transform.Find("Shadow");

    }
    void Start() 
    {
    }
    //Touche assignée pour le déplacement et le Saut 
    void Update()
    {
        _direction.x = Input.GetAxisRaw("Horizontal") * _speed;

        _direction.y = Input.GetAxisRaw("Vertical") * _speed;


        if (_jumpTimer < 1f)
        {
            _jumpTimer += Time.deltaTime;

            float y = _jumpCurve.Evaluate(_jumpTimer);

            _graphics.localPosition = new Vector3(transform.localPosition.x, y * _jumpHeight, transform.localPosition.z);

        }

        else

        {
            _jumpTimer = 0f;

        }

    }
    void FixedUpdate()
    {
        
        _rgbd.MovePosition(_rgbd.position + _direction * _movespeed * Time.fixedDeltaTime);

        

    }
      
        
    #region private
    private Rigidbody2D _rgbd;
    private float _movespeed = 1f;
    float _jumpTimer;
    #endregion

    
    

}











    


    
         

     




       

        


   



    

















