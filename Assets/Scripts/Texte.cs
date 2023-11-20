using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Texte : MonoBehaviour
{
    private TextMeshProUGUI texte;


    [SerializeField]
    private Objet cassetteCollectée;


    private void Awake()
    {
        texte = GetComponent<TextMeshProUGUI>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        texte.text = cassetteCollectée.value.ToString();
    }


    

}
