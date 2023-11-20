using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Ennemi : MonoBehaviour
{
    [SerializeField]
    private EnnemiObjet ennemi;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ennemi.pointVie -= 1;
            ennemi.scoreJoueur++;
            



            if (ennemi.pointVie == 0) 
            {
                Destroy(gameObject);
            }
        }
    }
}
