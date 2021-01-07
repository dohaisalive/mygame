using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toppings : MonoBehaviour
{

    public int occupiedslot = 99;
    public string mousecontrol = "no";

    // Start is called before the first frame update
    void Start()
    {
        occupiedslot = GamePlay.selectedslot;
    }

    // Update is called once per frame
    void Update()
    {
        if (occupiedslot == GamePlay.selectedsandwitch)
        {
            mousecontrol = "yes";
            Vector2 mouseposition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objectposition = Camera.main.ScreenToWorldPoint(mouseposition);
            transform.position = new Vector2(objectposition.x, objectposition.y);
        }
 
         if ((GamePlay.deletefood == "yes") && (mousecontrol == "yes"))
        {
            Destroy(gameObject);
        }

    }
}
