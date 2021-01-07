using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sandwich : MonoBehaviour
{
    public int occupiedslot = 0;
    public string mousecontrol = "no";

    // Start is called before the first frame update
    void Start()
    {
        occupiedslot = GamePlay.selectedslot;
    }

    // Update is called once per frame
    void Update()
    {
        if (mousecontrol == "yes")
        {
            Vector2 mouseposition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objectposition = Camera.main.ScreenToWorldPoint(mouseposition);
            transform.position = objectposition;
        }

        if ((GamePlay.deletefood == "yes") && (mousecontrol == "yes"))
        {
            Destroy(gameObject);
        }
       
    }

    void OnMouseDown()
    {
        mousecontrol = "yes";
        GamePlay.selectedsandwitch = occupiedslot;
    }
}
