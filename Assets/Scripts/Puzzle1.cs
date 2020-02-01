using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{
    public int red = 0;
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
        if (puzzle2.green == 1 || puzzle3.blue == 1)
        {
            red = 0;
        }
        else
        {
            red = 1;
        }

    }
}
