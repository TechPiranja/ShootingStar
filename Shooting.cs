using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float moveSpeed;
    public float force;
    public new Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody.AddForce(new Vector3(0, force, 0));
    }

    void Update()
    {
        transform.Translate(new Vector3(1 * moveSpeed * Time.deltaTime, 0f, 0f));
    }
}
