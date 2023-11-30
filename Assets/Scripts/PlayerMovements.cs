using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{


    #region public
    public Transform _graphics;

    [SerializeField]
    AnimationCurve _jumpCurve;

    [SerializeField]
    float _jumpHeight = 3f;

    public float _speed = 1.5f;
    public Vector2 _direction;
    public Animator _animator; 
    #endregion

    void Awake()
    {
        _rgbd = GetComponent<Rigidbody2D>();

        _graphics = transform.Find("Character 1");
    }
    void Start() 
    {
    }
    //Touche assign�e pour le d�placement et le Saut 
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
      
    //Op�rateurs Pour Le Saut
    void FixedUpdate()
    {
        
        Debug.Log(_direction.magnitude);

        _animator.SetFloat("Walkspeed", _direction.magnitude);

                
        _rgbd.MovePosition(_rgbd.position + _direction * _movespeed * Time.fixedDeltaTime);            
         
    }
  

    #region private
    private Rigidbody2D _rgbd;
    private float _movespeed = 5f;
    float _jumpTimer;
    #endregion
  
    
}
   
    
    

    






      

        
    









       

    
           
        

      


    
         

     




       

        


   



    

















