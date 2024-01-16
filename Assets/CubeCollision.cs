using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{

    private AudioSource audiosource;
    public AudioClip block;

    public GameObject ground;
    public GameObject CubePrefab;
    public GameObject UnityChan2D;

    void OnCollisionEnter(Collision collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collision.gameObject.CompareTag("ground"))
        {
            PlaySound();
        }

        if (collision.gameObject.CompareTag("Cube"))
        {
            PlaySound();
        }

        if (collision.gameObject.CompareTag("unitychan2D"))
        {

        }
    }

    void PlaySound()
    {
        if(audiosource!=null&&block!=null)
        {
            audiosource.PlayOneShot(block);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    // Update is called once per frame

}
