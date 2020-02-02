using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressureDeath : MonoBehaviour
{
    public Animator anim;

    public Renderer pad1;
    public Renderer pad2;
    public Renderer pad3;
    public Renderer pad4;
    public Renderer pad5;
    public Renderer pad6;

    public int triggerRed = 0;
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
        pressureGood pressureGood = pressurePadGood.GetComponent<pressureGood>();
        pressureGood.triggerGreen = 0;
        triggerRed = 1;
        anim.SetFloat("speed", 1);
        pad1.material.color = Color.red;
        pad2.material.color = Color.green;
        pad3.material.color = Color.green;
        pad4.material.color = Color.red;
        pad5.material.color = Color.red;
        pad6.material.color = Color.green;

    }
}
