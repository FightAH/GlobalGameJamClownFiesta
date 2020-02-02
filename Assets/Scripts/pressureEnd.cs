using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressureEnd : MonoBehaviour
{
    public GameObject pressurePadBad;
    public GameObject pressurePadGood;
    public GameObject door;
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

        pressureDeath pressureDeath = pressurePadBad.GetComponent<pressureDeath>();
        pressureGood pressureGood = pressurePadGood.GetComponent<pressureGood>();
        Renderer collideded = this.GetComponent<Renderer>();
        if (collideded.material.color == Color.red)
        {
            if (pressureDeath.triggerRed == 1)
            {
                door.SetActive(false);
            }
        }

        if (collideded.material.color == Color.green)
        {
            if (pressureGood.triggerGreen == 1)
            {
                door.SetActive(false);
            }

        }
    }
}
