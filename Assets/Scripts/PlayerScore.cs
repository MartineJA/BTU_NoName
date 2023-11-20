using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{

    
    public int vieTotal = 3;
    public int vieNb = 3;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("tu as été touché" + vieNb);

            vieNb -= 1;
            // modifier la transparence du joueur quand il est touché
            if (vieNb == 0 && vieTotal > 0)
            {
                vieNb = 3;
                vieTotal -= 1;
            }


            if (vieTotal == 0)
            {
                Debug.Log("tu es mort" + vieTotal);
                // modifier la couleur du joueur quand il est mort
            }

        }

    }

}
