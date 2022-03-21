using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    
    private float horizontalInput;
    public float speed = 10f;
    public float xRange = 2f;
    public GameObject fire;
    private Vector3 offset = new Vector3(0f, 0.5f, 1f); 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(fire, transform.position + offset, Quaternion.identity);
        }

        

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Egg"))
        {
            Destroy(gameObject);
            Debug.Log("Game Over!!");
            Time.timeScale = 0;
            
        }
    }
}
