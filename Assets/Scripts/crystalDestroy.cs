using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class crystalDestroy : MonoBehaviour
{

    public int score;
    public TextMeshProUGUI scoreText;

    public AudioSource source;
    public AudioClip clip;



    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }


    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.layer == 8)         
    //    {
    //        score++;
    //        scoreText.text = score.ToString();
    //        Destroy(collision.gameObject);
    //    }

    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            score++;
            scoreText.text = score.ToString();
            Destroy(other.gameObject);
            source.PlayOneShot(clip);
        }
    }

}