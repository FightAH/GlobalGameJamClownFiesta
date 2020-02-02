using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goo : MonoBehaviour
{

    public AudioSource audioS;

    public AudioClip audioC;

    public int gooJump = 0;
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
        gooJump = 1;
        GameObject player = GameObject.Find("Player");
        PlayerController playerController = player.GetComponent<PlayerController>();
        playerController.moveSpeed = 5;
        if (!audioS.isPlaying)
        {
            audioS.clip = audioC;
            audioS.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        gooJump = 0;
        GameObject player = GameObject.Find("Player");
        PlayerController playerController = player.GetComponent<PlayerController>();
        playerController.moveSpeed = 12;
        if(playerController.legs == 1)
        {
            playerController.moveSpeed = 15;
        }

    }
}
