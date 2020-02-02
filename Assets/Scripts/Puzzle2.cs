using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2 : MonoBehaviour
{
    public int green = 0;
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
        GameObject blue = GameObject.Find("Blue");
        Puzzle3 puzzle3 = blue.GetComponent<Puzzle3>();
        if (puzzle1.red == 1 && puzzle3.blue == 1)
        {
            green = 1;
        }
        else
        {
            green = 0;
            puzzle1.red = 0;
            puzzle3.blue = 0;
            puzzle3.blue2 = 0;
            puzzle1.red = 0;
            puzzle1.triggered = 0;
            puzzle3.triggered = 0;
        }
    }
}
