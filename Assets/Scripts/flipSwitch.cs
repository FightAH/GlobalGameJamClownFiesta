using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipSwitch : MonoBehaviour
{
    public GameObject door;

    public Animator anim;

    public AudioSource audioS;

    public AudioClip switchClip;

    int switchPlayed = 0;
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
        anim.SetFloat("flip", 1);
        door.SetActive(false);
        if (!audioS.isPlaying && switchPlayed == 0)
        {
            audioS.clip = switchClip;
            audioS.Play();
            switchPlayed = 1;
        }
    }
}
