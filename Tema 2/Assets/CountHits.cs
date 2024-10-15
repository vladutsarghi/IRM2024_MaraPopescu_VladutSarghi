using UnityEngine;
using TMPro; 

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreText2;

    private int score = 0; 

    void Start()
    {
        UpdateScoreText(); 
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bat")) 
        {
            score++; 
            UpdateScoreText(); 
            Debug.Log("Mingea a fost lovita! Scor: " + score);
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Scor: " + score;
        scoreText2.text = "Scor: " + score;

    }
}
