using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DebugPvEnnemi : MonoBehaviour
{
    private TextMeshProUGUI debugText;

    [SerializeField]
    private EnnemiObjet ennemi;



    // Start is called before the first frame update
    void Start()
    {
        debugText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        debugText.text = ennemi.pointVie.ToString();
    }

    
}
