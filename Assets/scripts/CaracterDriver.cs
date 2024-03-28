using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaracterDriver : MonoBehaviour
{
    Animator animator;
    float velocityX = 0f;
    float velocityZ = 0f;

    float accelaration = 0.25f;
    float decelaration = 0.05f;


    float maxWalking = 0.5f;
    float maxRunning = 2f;

    float maxVelocity = 0f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        //get inputs
        bool forwardPressed = Input.GetKey(KeyCode.W);
        bool runPressed = Input.GetKey(KeyCode.LeftShift);
        bool rightPressed = Input.GetKey(KeyCode.D);
        bool leftPressed = Input.GetKey(KeyCode.A);



        maxVelocity = runPressed ? maxRunning : maxWalking ;


        // 
        if (forwardPressed && velocityZ <maxVelocity)
        {
            velocityZ += Time.deltaTime * accelaration;
        }
        if (rightPressed && velocityX<maxVelocity)
        {
            velocityX += Time.deltaTime * accelaration;
        }

        animator.SetFloat("VelocityZ", velocityZ);
        animator.SetFloat("VelocityX", velocityX);
    }
}
