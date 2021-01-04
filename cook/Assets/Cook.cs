using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cook : MonoBehaviour
{
    public float cookingtime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cookingtime = cookingtime + Time.deltaTime;
        
        if (cookingtime > 5 && cookingtime < 10)
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 0);
        }

        if (cookingtime >= 10)
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
        }
    }
}
