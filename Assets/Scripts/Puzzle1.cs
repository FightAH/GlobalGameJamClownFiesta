using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{
    public int red = 0;
    public int red2 = 0;
    public int triggered = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject blue = GameObject.Find("Blue");
        Puzzle3 puzzle3 = blue.GetComponent<Puzzle3>();
        GameObject green = GameObject.Find("Green");
        Puzzle2 puzzle2 = green.GetComponent<Puzzle2>();
        if (triggered == 1)
        {
            if (red == 1 && puzzle3.blue == 1 && puzzle2.green == 1 && puzzle3.blue2 == 1)
            {
                red2 = 1;
            }
            else
            {
                puzzle2.green = 0;
                red = 0;
                puzzle3.blue = 0;
                puzzle3.blue2 = 0;
                red2 = 0;
                triggered = 0;
                puzzle3.triggered = 0;
            }
        }
        if (triggered == 0)
        {
            if (puzzle2.green == 0 && puzzle3.blue == 0)
            {
                red = 1;
                triggered = 1;
            }
            else
            {
                puzzle2.green = 0;
                red = 0;
                puzzle3.blue = 0;
                puzzle3.blue2 = 0;
                red2 = 0;
                triggered = 0;
                puzzle3.triggered = 0;
            }
        }
        
       

    }
}
