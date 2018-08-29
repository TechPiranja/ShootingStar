using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public GameObject shootingStar;

    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
            transform.Translate(new Vector3( 0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));

        if (Input.GetKeyDown(KeyCode.Space) && StarSpawner.availableStars > 0)
        {
            Instantiate(shootingStar, transform.position, transform.rotation);
            StarSpawner.availableStars--;
        }            
        else if (Input.GetKeyDown(KeyCode.Space))
            Debug.Log("No Stars left...");
    }
}
