using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipLeft : MonoBehaviour
{
    public GameObject door;

    public Animator anim;
    public int triggered = 0;
    public AudioSource audioS;

    public AudioClip switchClip;
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
        GameObject trigger = GameObject.Find("Right");
        flipRight rightflip = trigger.GetComponent<flipRight>();
        {
            if (rightflip.triggered == 0)
            {
                anim.SetFloat("left", 1);
                door.SetActive(false);
                Debug.Log("left");
                rightflip.triggered = 1;
                if (!audioS.isPlaying)
                {
                    audioS.clip = switchClip;
                    audioS.Play();
                }
            }
        }
    }
}

