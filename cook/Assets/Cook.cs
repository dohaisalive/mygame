using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cook : MonoBehaviour
{
    public float cookingtime = 0;
    public int occupiedslot = 100;
    public string mousecontrol = "no";
    public string topping;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (occupiedslot == GamePlay.selectedsandwitch)
        {
            //move the meat
            mousecontrol = "yes";
            Vector2 mouseposition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objectposition = Camera.main.ScreenToWorldPoint(mouseposition);
            transform.position = new Vector2(objectposition.x, objectposition.y );

            if (gameObject.name == "onemeat(Clone)")
            {
                GamePlay.currentmeat = "hamburger";
            }
        }



        if ((GamePlay.deletefood == "yes") && (mousecontrol == "yes"))
        {
            Destroy(gameObject);
        }

       
        
        cookingtime = cookingtime + Time.deltaTime;
        if ((cookingtime > 5 && cookingtime < 10) && (transform.position.x > 6))
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 0);
        }

        if ((cookingtime >= 10) && (transform.position.x > 6))
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
        }

        
    }

    private void OnMouseDown()
    {
        if (transform.position.x == 7.39f)
        {
            GamePlay.grill1 = "empty";
            occupiedslot = 1;
        }

        else if (transform.position.x == 6.42f)
        {
            GamePlay.grill2 = "empty";
            occupiedslot = 2;
        }

        else if (transform.position.x >= 7.13f)
        {
            GamePlay.grill3 = "empty";
            occupiedslot = 3;
        }




        if ((GamePlay.cuttingboard1 == "justbun") && (topping != "placed"))
        {
            GetComponent<Transform>().position = new Vector2(-0.257f, -1.77f);
            GamePlay.cuttingboard1 = "fullbun";
            occupiedslot = 1;
            topping = "placed";
        }

        else if ((GamePlay.cuttingboard2) == "justbun" && (topping != "placed"))
        {
            GetComponent<Transform>().position = new Vector2(1.38f, -1.77f);
            GamePlay.cuttingboard2 = "fullbun";
            occupiedslot = 2;
            topping = "placed";
        }

        else if ((GamePlay.cuttingboard3 == "justbun") && (topping != "placed"))
        {
            GetComponent<Transform>().position = new Vector2(3.02f, -1.79f);
            GamePlay.cuttingboard3 = "fullbun";
            occupiedslot = 3;
            topping = "placed";
        }


     
    }
}
