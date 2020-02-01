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

    int teleporting = 0;

    float moving = 0f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (teleporting == 0)
        {
            if(controller.velocity.magnitude > 0)
            {
                moving = 1;
            }
            else
            {
                moving = 0;
            }
            anim.SetFloat("speed", moving);
            if (legs == 1)
            {
                animLegs.SetFloat("speed", moving);
                legModel.SetActive(true);
                noLegModel.SetActive(false);
            }
            float yStore = moveDirection.y;
            moveDirection = (transform.forward * Input.GetAxis("Vertical") * moveSpeed) + (transform.right * Input.GetAxis("Horizontal") * moveSpeed);

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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Teleport")
        {
            teleporting = 1;
            this.transform.position = new Vector3(-25.2f, 0.5f, 27f);
            Debug.Log("Teleport");
            StartCoroutine(ExampleCoroutine());
        }

    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
        teleporting = 0;
    }
}

