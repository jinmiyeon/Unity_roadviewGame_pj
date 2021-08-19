using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float speed = 8f;
    public float hp = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //float xInput = Input.GetAxis("Horizontal");
        //float zInput = Input.GetAxis("Vertical");

        //float xSpeed = xInput * speed;
        //float zSpeed = zInput * speed;

        //Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        //playerRigidbody.velocity = newVelocity;
    }
public void GetDamage(float amount)
    {
        hp -= amount;
        if (hp < 0)
        {
            Die();
        }
    }

    public void Die()
    {
        gameObject.SetActive(false);

        FindObjectOfType<GameManager>().EndGame();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            GetDamage(3.0f);
        }
        if (other.gameObject.tag == "PUNCH")
        {
            GetDamage(10.0f);
        }
        if (other.tag == "Bullet")
        {
            tomato bullet = other.GetComponent<tomato>();

            if (bullet != null)
            {
                Destroy(bullet.gameObject);

            }
        }
        //if (other.gameObject.tag == "SafeZone")
        //{
        //    SceneManager.LoadScene("EndScene");
        //    print("dddddddd");
        //}
    }
}
