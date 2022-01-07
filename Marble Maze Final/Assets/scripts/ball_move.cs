using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball_move : MonoBehaviour
{

    public float speed;
    private Rigidbody rigb;

    private void Start()
    {
        rigb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveHoriz = (Input.GetAxis("Horizontal") * -1);
        float moveVert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveVert, 0.0f, moveHoriz);
        rigb.AddForce(movement * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Finish")
        {
            Debug.Log("Finish");
            SceneManager.LoadScene(2);
        }
    }
}
