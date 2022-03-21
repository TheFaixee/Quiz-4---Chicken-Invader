using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public AudioClip killsound;
    public GameObject egg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        //Destroy(gameObject);
        Destroy(other.gameObject);
        GetComponent<AudioSource>().PlayOneShot(killsound);
        ScoreManager.scoreValue += 5;
        Instantiate(egg, transform.position, Quaternion.identity);
    }
}
