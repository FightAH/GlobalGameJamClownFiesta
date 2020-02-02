using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurePad : MonoBehaviour
{

    public GameObject door;

    public Animator anim;

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
        anim.SetFloat("speed", 1);
        door.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetFloat("speed", 0);
    }
}
