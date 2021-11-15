using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerr : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed = 20f;
    public bool isGrounded = false;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(00, 7), ForceMode2D.Impulse);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("ball"))
        {
            Die();
        }
    }
    void Die()
    {

        SceneManager.LoadScene("GameOverScene");
    }

}