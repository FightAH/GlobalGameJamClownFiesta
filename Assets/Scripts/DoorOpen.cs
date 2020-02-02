using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject door;

    public AudioSource audioS;

    public AudioClip doorOpen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject red = GameObject.Find("Red");
        Puzzle1 puzzle1 = red.GetComponent<Puzzle1>();
        GameObject green = GameObject.Find("Green");
        Puzzle2 puzzle2 = green.GetComponent<Puzzle2>();
        GameObject blue = GameObject.Find("Blue");
        Puzzle3 puzzle3 = blue.GetComponent<Puzzle3>();
        if (puzzle1.red == 1 && puzzle3.blue == 1 && puzzle2.green == 1 && puzzle3.blue2 == 1 && puzzle1.red2 == 1)
        {
            door.SetActive(false);
            if (!audioS.isPlaying)
            {
                audioS.clip = doorOpen;
                audioS.Play();
            }
        }
    }
}
