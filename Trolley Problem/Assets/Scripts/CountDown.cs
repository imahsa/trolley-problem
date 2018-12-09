using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    public float timeLeft = 10.0f;

    public Text text;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft > 0)
        {
        	text.text = "Time Left: " + Mathf.Round(timeLeft);
		}
        else if (timeLeft < -10) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}