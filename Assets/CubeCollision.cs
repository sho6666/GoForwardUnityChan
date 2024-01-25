using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    public AudioClip block;
    private AudioSource audiosource;
    public GameObject blocksound;

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.CompareTag("ground") || collidedObject.CompareTag("Cube"))
        {
            PlaySound(collidedObject);
        }

        if (collidedObject.CompareTag("unitychan2D"))
        {
            // �����������K�v�Ȃ炱���ɏ���
        }

        if (audiosource == null)
        {
           
            Debug.LogError("AudioSource not found on the blocksound GameObject.");
        }
    }

    void PlaySound(GameObject obj)
    {
        
            AudioSource audioSource = obj.GetComponent<AudioSource>();

            if (audioSource !=null&&audioSource.clip !=null)
            {
               audioSource.Play(); 
            }

            
          
        
    }

  
}