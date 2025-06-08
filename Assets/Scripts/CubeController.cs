using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public float MoveSpeed = 10f;
    public float HorizontalSpeed = 10f;
    public float JumpForce = 10;

    Rigidbody rb;
    public bool isGrounded;

    public Button button1, button2;
    

    void Awake()
    {
        button1.onClick.AddListener(RestartGame);
        button2.onClick.AddListener(RestartGame);
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    void Update()
    {
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, MoveSpeed);
        float moveHorizontal = 0;
        if (Input.GetKey(KeyCode.A))
        {
            moveHorizontal = -HorizontalSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveHorizontal = HorizontalSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }

        rb.velocity = new Vector3(moveHorizontal, rb.velocity.y, rb.velocity.z);
    }

    public GameObject Win, Lose;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Lose.SetActive(true);
            Debug.LogError("TEST");
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            Win.SetActive(true);
            Debug.LogError("Succes");
        }
    }
}