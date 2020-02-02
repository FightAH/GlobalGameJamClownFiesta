using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animLegs;
    public Animator animationArm;
    public float moveSpeed = 12;
    public CharacterController controller;
    public float jumpForce;
    private Vector3 moveDirection;
    public float gravityScale;

    public int legs = 0;

    public int arm = 0;

    public int armM = 0;

    public GameObject legModel;

    public GameObject noLegModel;

    public GameObject armModel;

    public GameObject armMagnet;

    int teleporting = 0;

    public Animator animator;

    public AudioSource audioSource;

    public AudioClip jump;

    public AudioClip armClip;

    public AudioClip fall;

    public AudioClip moving;

    public AudioClip braking;

    public GameObject gooPool;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
      
    }

    // Update is called once per frame
    void Update()
    {
        goo gooTest = gooPool.GetComponent<goo>();
        if (teleporting == 0)
        {
            if (Input.GetKey(KeyCode.W))
            {
                animator.SetFloat("forward", 1);
                animator.SetFloat("speed", 0);
                animator.SetFloat("right", 0);
                animator.SetFloat("left", 0);
            }
            else
            {
                animator.SetFloat("forward", 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                animator.SetFloat("speed", 1);
                animator.SetFloat("right", 0);
                animator.SetFloat("left", 0);
                animator.SetFloat("forward", 0);
            }
            else
            {
                animator.SetFloat("speed", 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                animator.SetFloat("right", 1);
                animator.SetFloat("forward", 0);
                animator.SetFloat("left", 0);
                animator.SetFloat("speed", 0);
            }
            else
            {
                animator.SetFloat("right", 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                animator.SetFloat("left", 1);
                animator.SetFloat("speed", 0);
                animator.SetFloat("forward", 0);
                animator.SetFloat("right", 0);
            }
            else
            {
                animator.SetFloat("left", 0);
            }

            if (Input.GetKeyDown(KeyCode.W) && controller.velocity.x == 0 && legs == 0)
            {
                if(!audioSource.isPlaying)
                {
                    audioSource.clip = moving;
                    audioSource.Play();
                }
                   
            }
            if(Input.GetKeyDown(KeyCode.S) && !Input.GetKeyDown(KeyCode.W) && controller.velocity.x > 0 && legs == 0)
            {
                if (!audioSource.isPlaying)
                {
                    audioSource.clip = braking;
                    audioSource.Play();
                }
            }
           

            if (legs == 1)
            {
                float v = Input.GetAxis("Vertical");
                animLegs.SetFloat("speed", v);
                legModel.SetActive(true);
                noLegModel.SetActive(false);
            }
            float yStore = moveDirection.y;
            moveDirection = (transform.forward * Input.GetAxis("Vertical") * moveSpeed) + (transform.right * Input.GetAxis("Horizontal") * moveSpeed);

            moveDirection.y = yStore;
            if (controller.isGrounded)
            {
                moveDirection.y = 0f;
            }
            if (controller.isGrounded && legs == 1 && gooTest.gooJump == 0)
            {
                moveDirection.y = 0f;
                if (Input.GetButtonDown("Jump"))
                {
                    if (!audioSource.isPlaying)
                    {
                        audioSource.clip = jump;
                        audioSource.Play();
                        moveDirection.y = jumpForce;
                    }
                }
            }
           
            moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
            controller.Move(moveDirection * Time.deltaTime);
            if(arm == 1)
            {
                armModel.SetActive(true);
                if(Input.GetKey(KeyCode.Q))
                {
                    animationArm.SetFloat("moveArm", 1);
                    if (Input.GetKeyDown(KeyCode.Q))
                    {
                        if (!audioSource.isPlaying)
                        {

                            audioSource.clip = armClip;
                            audioSource.Play();
                        }
                    }
                }
                else
                {
                    animationArm.SetFloat("moveArm", 0);
                }
            }

            if(armM == 1)
            {
                armMagnet.SetActive(true);
            }

            if(controller.transform.position.y > 3 && !controller.isGrounded)
            {
                if (!audioSource.isPlaying)
                {

                    audioSource.clip = fall;
                    audioSource.Play();
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Teleport")
        {
            teleporting = 1;
            this.transform.position = new Vector3(-25.2f, 0.5f, 27f);
            Debug.Log("Teleport");
            
        }
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
        teleporting = 0;
    }


}

