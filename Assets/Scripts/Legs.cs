using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legs : MonoBehaviour
{

    public GameObject legsModel;
    
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
        PlayerController.legs = 1;
        legsModel.SetActive(false);
        PlayerController.moveSpeed = 10;
    }
}
