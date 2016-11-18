using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Splash : MonoBehaviour
{
    public float timer;
    public float changeSceneTime;

	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;

        if (timer > changeSceneTime)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
	}
}
