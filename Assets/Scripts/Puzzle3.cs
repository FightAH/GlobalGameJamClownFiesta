using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle3 : MonoBehaviour
{
    public int blue = 0;
    public int blue2 = 0;

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
        GameObject red = GameObject.Find("Red");
        Puzzle1 puzzle1 = red.GetComponent<Puzzle1>();
        GameObject green = GameObject.Find("Green");
        Puzzle2 puzzle2 = green.GetComponent<Puzzle2>();
       
        if (triggered == 1)
        {
            if (puzzle1.red == 1 && puzzle2.green == 1 && blue == 1)
            {
                blue2 = 1;
            }
            else
            {
                puzzle1.red = 0;
                puzzle2.green = 0;
                puzzle1.red2 = 0;
                blue = 0;
                blue2 = 0;
                triggered = 1;
                puzzle1.triggered = 0;
            }
        }
        if (triggered == 0)
        {
            if (puzzle1.red == 1)
            {
                blue = 1;
                triggered = 1;
            }
            else
            {
                puzzle1.red = 0;
                puzzle2.green = 0;
                puzzle1.red2 = 0;
                blue = 0;
                blue2 = 0;
                triggered = 1;
                puzzle1.triggered = 0;
            }
        }
    }
}
