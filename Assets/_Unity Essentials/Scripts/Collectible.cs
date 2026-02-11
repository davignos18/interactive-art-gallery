using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotatingSpeed = 0.5f;
    public GameObject onCollectEffect;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotatingSpeed,0);


    }

    private void OnTriggerEnter(Collider other)
    {

        //Destroy the puzzle piece

        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }

        


    }



}
