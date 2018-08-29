using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        transform.Translate(new Vector3(-1 * moveSpeed * Time.deltaTime, 0f, 0f));

        if (transform.position.y <= -10 || transform.position.x <= -8)
        {
            Destroy(gameObject);
            Debug.Log("Out of Range");
        }   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ShootingStar")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Score.count++;
        }           
    }
}
