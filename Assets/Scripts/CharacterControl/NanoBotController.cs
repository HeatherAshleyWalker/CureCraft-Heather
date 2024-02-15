using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NanoBotController : MonoBehaviour
{

    private Rigidbody rbody;
    private Animator anim;
    public float speed = 5f;
    public float rotSpeed = 3f;
    private Vector3 dir = Vector3.zero;

    private Boolean isInShootingMode = false;
    private Boolean isShooting = false;

    private float velx = 0f;
    private float vely = 0f;

    private void Start()
    {
        rbody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");
        dir.Normalize();

        anim.SetFloat("velx", dir.x);
        anim.SetFloat("vely", dir.z);

    }

    private void FixedUpdate()
    {
        if (dir != Vector3.zero)
        {
            // checking the sign to turn character in ahead to create more natural dir transition
            if (Mathf.Sign(transform.forward.x) != Mathf.Sign(dir.x) || Mathf.Sign(transform.forward.z) != Mathf.Sign(dir.z))
            {
                transform.Rotate(0, 1, 0);
            }
            transform.forward = Vector3.Lerp(transform.forward, dir, rotSpeed * Time.deltaTime); // let the player to head to the input direction
        }

        rbody.MovePosition(this.gameObject.transform.position + dir * speed * Time.deltaTime);

        if (Input.GetKeyUp(KeyCode.E))
        {
            if (isInShootingMode == false)
            {
                isInShootingMode = true;
            }
            else
            {
                isInShootingMode = false;
            }
            anim.SetBool("isInShootingMode", isInShootingMode);
        }

        if (Input.GetKeyUp(KeyCode.R) && isInShootingMode)
        {
            if (isShooting == false)
            {
                isShooting = true;
            }
            else
            {
                isShooting = false;
                isInShootingMode = false;
                anim.SetBool("isInShootingMode", isInShootingMode);
            }
            anim.SetBool("isShooting", isShooting);
        }
    }
}
