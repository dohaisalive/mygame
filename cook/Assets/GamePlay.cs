using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    // Start is called before the first frame update

    public static string cuttingboard1 = "empty";
    public static string cuttingboard2 = "empty";
    public static string cuttingboard3 = "empty";

    public static string grill1 = "empty";
    public static string grill2 = "empty"; 
    public static string grill3 = "empty";

    public static int selectedsandwitch = 0;
    public static int selectedslot = 0;

    public KeyCode givefood;
    public static string deletefood = "no";
    public static string currentmeat;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(givefood))
        {
            deletefood = "yes";
        }
    }
}
