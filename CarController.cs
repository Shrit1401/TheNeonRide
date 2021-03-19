 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class CarController : MonoBehaviour
{
    //Player Movement
    public GameObject deathEffect;
    private bool move = false;
    private Rigidbody2D rb;
    public float speed = 20f;
    private bool isGrounded = false;
    public float rotationSpeed = 7f;


    //Dead Screen
    public GameObject DeadScreen;

    private void Start()
    {
        DeadScreen.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
        {
            move = true;

            FindObjectOfType<AudioManager>().Play("Drive");
        }

        if (Input.GetButtonUp("Fire1") || Input.GetButtonUp("Jump"))
        {
            move = false;
            FindObjectOfType<AudioManager>().Stop("Drive");
        }
    }

    private void FixedUpdate()
    {
        if(move == true)
        {
            if (isGrounded)
            {
                rb.AddForce(transform.right * speed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
            }

            else
            {
                rb.AddTorque(rotationSpeed * rotationSpeed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
            }
        }

    }

    private void OnCollisionEnter2D()
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D()
    {
        isGrounded = false;
    }

    public void Dead()
    {
        FindObjectOfType<AudioManager>().Play("Death");
        Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(this.gameObject);
        DeadScreen.SetActive(true);
    }
}
