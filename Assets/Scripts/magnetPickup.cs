using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnetPickup : MonoBehaviour
{
    public GameObject armModel;

    public AudioSource audioS;

    public AudioClip audioC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        GameObject controller = GameObject.Find("Player");
        PlayerController PlayerController = controller.GetComponent<PlayerController>();
        PlayerController.armM = 1;
        armModel.SetActive(false);
        if (!audioS.isPlaying)
        {
            audioS.clip = audioC;
            audioS.Play();
        }
    }
}
