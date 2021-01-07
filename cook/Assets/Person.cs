using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    // Start is called before the first frame update

    public string order = "hamburger";

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        if ((GamePlay.deletefood == "yes") && (GamePlay.currentmeat == order)){

            Destroy(gameObject);
            GamePlay.deletefood = "no"; 
        }
    }
}
