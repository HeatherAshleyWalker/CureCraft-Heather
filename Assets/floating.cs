using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floating : MonoBehaviour
{
    Rigidbody body;
    public float impulseForce = 3f;
    public ForceMode mode = ForceMode.Impulse;

    // Declare variables to hold position components
    float positionX;
    float centerY;
    float centerZ;

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Get the position of the Rigidbody every FixedUpdate
        Vector3 position = body.position;
        positionX = position.x;
        centerY = position.y;
        centerZ = position.z;

        // Rest of your FixedUpdate logic...
        int randomint = Random.Range(0, 100);
        float randomx = Random.Range(0.0f, 1.0f);
        float randomy = Random.Range(0.0f, 1.0f);
        float randomz = Random.Range(0.0f, 1.0f);
        float randforce = Random.Range(0.0f, 1.0f);

        if (centerY < 4.0f && centerY > 2.0f)
        {
            body.AddForce(Vector3.down * impulseForce * Random.Range(0.0f, 1.0f), mode);
        }

        if (centerY < 2.0f && centerY > 0.0f)
        {
            body.AddForce(Vector3.up * impulseForce * Random.Range(0.0f, 1.0f), mode);
        }

        if (positionX > 0.0f)
        {
            body.AddForce(Vector3.left * impulseForce * Random.Range(0.0f, 1.0f), mode);
        }

        if (positionX < 0.0f)
        {
            body.AddForce(Vector3.right * impulseForce * Random.Range(0.0f, 1.0f), mode);
        }

        //body.AddTorque(1000 * randomx, 1000 * randomy, 1000 * randomz, ForceMode.Force);
    }
}
