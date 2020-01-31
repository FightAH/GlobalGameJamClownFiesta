using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    public Animator animLegs;
    public float moveSpeed = 5;
    public CharacterController controller;
    public float jumpForce;
    private Vector3 moveDirection;
    public float gravityScale;

    public int legs = 0;

    public GameObject legModel;

    public GameObject noLegModel;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
            float yStore = moveDirection.y;
            moveDirection = (transform.forward * Input.GetAxis("Vertical") * moveSpeed) + (transform.right * Input.GetAxis("Horizontal") * moveSpeed);
            float v = Input.GetAxis("Vertical");
            float h = Input.GetAxis("Horizontal");
            anim.SetFloat("speed", h);
            anim.SetFloat("speed", v);
            if (legs == 1)
            {
                animLegs.SetFloat("speed", h);
                animLegs.SetFloat("speed", v);
                legModel.SetActive(true);
                noLegModel.SetActive(false);
            }
            moveDirection.y = yStore;
            if (controller.isGrounded && legs == 1)
            {
                moveDirection.y = 0f;
                if (Input.GetButtonDown("Jump"))
                {
                    moveDirection.y = jumpForce;
                }
            }
            moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
            controller.Move(moveDirection * Time.deltaTime);

    }
}

