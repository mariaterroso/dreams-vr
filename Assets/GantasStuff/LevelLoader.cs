using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    crystalDestroy crystalDestroy;

    public Animator transition;

    public float transitionTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        crystalDestroy = GameObject.Find("Pouch").GetComponent<crystalDestroy>();
    }

    // Update is called once per frame
    void Update()
    {
        if (crystalDestroy.score == 8) 
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel() 
    {

       StartCoroutine( LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    
    }

    IEnumerator LoadLevel(int levelIndex) 
    {
        Debug.Log("As cia");
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    
    }
}
