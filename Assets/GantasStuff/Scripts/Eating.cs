using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Eating : MonoBehaviour
{

    public AudioSource source;
    public AudioClip clip;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.layer == 9)         
    //    {
    //        source.PlayOneShot(clip);
    //        Destroy(collision.gameObject);
    //    }

    //}


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            source.PlayOneShot(clip);
            Destroy(other.gameObject);

        }
    }

}