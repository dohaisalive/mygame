using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bin : MonoBehaviour
{

    [SerializeField] public Transform bottombun;
    [SerializeField] public Transform topbun;
    [SerializeField] public Transform hotdog;
    [SerializeField] public Transform burger;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (gameObject.name == "bun")
        {
            if (GamePlay.cuttingboard1 == "empty")
            {
                Instantiate(bottombun, new Vector2(-1.27f, -2.28f), bottombun.rotation);
                Instantiate(topbun, new Vector2(-1.324f, -2.175f), topbun.rotation);
                GamePlay.cuttingboard1 = "full";
            }

            else if (GamePlay.cuttingboard2 == "empty")
            {
                Instantiate(bottombun, new Vector2(0.34f, -2.28f), bottombun.rotation);
                Instantiate(topbun, new Vector2(0.28f, -2.14f), topbun.rotation);
                GamePlay.cuttingboard2 = "full";
            }

            else if (GamePlay.cuttingboard3 == "empty")
            {
                Instantiate(bottombun, new Vector2(1.98f, -2.27f), bottombun.rotation);
                Instantiate(topbun, new Vector2(1.90f, -2.09f), topbun.rotation);
                GamePlay.cuttingboard3 = "full";
            }

        }

      
    }
}
