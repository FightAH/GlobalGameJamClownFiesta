using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressureCheck : MonoBehaviour
{
    public Renderer pad1;
    public Renderer pad2;
    public Renderer pad3;
    public Renderer pad4;
    public Renderer pad5;
    public Renderer pad6;

    public GameObject pressurePadBad;
    public GameObject pressurePadGood;
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
            if (pressureDeath.triggerRed == 0)
            {
                pad1.material.color = Color.grey;
                pad2.material.color = Color.grey;
                pad3.material.color = Color.grey;
                pad4.material.color = Color.grey;
                pad5.material.color = Color.grey;
                pad6.material.color = Color.grey;
                pressureDeath.triggerRed = 0;
                pressureGood.triggerGreen = 0;
            }
        }
        if (collideded.material.color == Color.green)
        {
            if (pressureGood.triggerGreen == 0)
            {
                pad1.material.color = Color.grey;
                pad2.material.color = Color.grey;
                pad3.material.color = Color.grey;
                pad4.material.color = Color.grey;
                pad5.material.color = Color.grey;
                pad6.material.color = Color.grey;
                pressureDeath.triggerRed = 0;
                pressureGood.triggerGreen = 0;
            }
        }


    }
}
