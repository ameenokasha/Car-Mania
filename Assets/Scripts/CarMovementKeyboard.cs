using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementKeyboard : MonoBehaviour
{
    public Rigidbody rb;
    public Transform car;
    public float speed = 0;


    Vector3 rotationRight = new Vector3(0, 60, 0);

    Vector3 rotationLeft = new Vector3(0, -60, 0);

    Vector3 forward = new Vector3(0, 0, 1);

    Vector3 backward = new Vector3(0, 0, -1);

    public bool isCarMoving = false;

    public float angle = 0.0f;

    public float acceleration = 0.00f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    public void AddForceAtAngle(float force, float angle)
    {
        float xcomponent = Mathf.Cos(angle * Mathf.PI / 180) * force;
        float ycomponent = Mathf.Sin(angle * Mathf.PI / 180) * force;

        rb.AddForce(ycomponent, 0, xcomponent);
    }


    void FixedUpdate()
    {


        // if (Input.GetKey("w"))
        // {
        //     if (speed <= 300)
        //         speed++;
        // }
        // if (Input.GetKey("s"))
        // {
        //     if (speed >= -10)
        //         speed--;
        // }

        // if (Input.GetKey("d"))
        // {
        //     if (angle < 90)
        //     {
        //         angle++;
        //     }
        // }

        // if (Input.GetKey("a"))
        // {
        //     if (angle > -90)
        //     {
        //         angle--;
        //     }
        // }
        // if (Input.GetKey("space"))
        // {
        //     if (speed > 5)
        //         speed -= 5;
        //     else if (speed < -5)
        //         speed += 5;
        //     else speed = 0;

        // }
        // if (!Input.GetKey("w") && !Input.GetKey("s"))
        // {
        //     if (speed > 0)
        //     {
        //         speed--;
        //         //transform.Translate(forward * speed * Time.deltaTime);

        //     }
        //     else if (speed < 0)
        //     {
        //         speed++;
        //         //transform.Translate(backward * speed * Time.deltaTime);

        //     }
        // }

        // AddForceAtAngle(speed, angle);


            if (Input.GetKey("w"))
            {
                if (speed <= 40)
                    speed++;
                transform.Translate(forward * speed * Time.deltaTime);
            }
            if (Input.GetKey("s"))
            {
                if (speed >= -10)
                    speed--;
                if (speed < 0)
                    transform.Translate(backward * speed * -1 * Time.deltaTime);
                else
                    transform.Translate(forward * speed * Time.deltaTime);
            }

            if (Input.GetKey("d"))
            {
                Quaternion deltaRotationRight = Quaternion.Euler(rotationRight * Time.deltaTime);
                rb.MoveRotation(rb.rotation * deltaRotationRight);
            }

            if (Input.GetKey("a"))
            {
                Quaternion deltaRotationLeft = Quaternion.Euler(rotationLeft * Time.deltaTime);
                rb.MoveRotation(rb.rotation * deltaRotationLeft);
            }
            if (Input.GetKey("space"))
            {
                if (speed > 5)
                    speed -= 5;
                else if (speed < -5)
                    speed += 5;
                else speed = 0;
            }
            if (!Input.GetKey("w") && !Input.GetKey("s"))
            {
                if (speed > 0)
                {
                    speed--;
                    transform.Translate(forward * speed * Time.deltaTime);
                }
                else if (speed < 0)
                {
                    speed++;
                    transform.Translate(backward * speed * Time.deltaTime);
                }
            }
    }
}