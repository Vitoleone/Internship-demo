using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinishScreen : MonoBehaviour
{
    [SerializeField] GameObject finishScreen;
    [SerializeField] GameObject scoreText;
    [SerializeField] GameObject sumosDefeatedText;
    [SerializeField] GameObject positionText;
    [SerializeField] GameObject pauseButton;

    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").gameObject.GetComponent<GameManager>();
    }

    private void Update()
    {
        if(gameManager.instance.isGameOver == true)
        {
            
            finishScreen.SetActive(true);
            pauseButton.SetActive(false);
            scoreText.GetComponent<TextMeshProUGUI>().text = gameManager.instance.score.ToString();//ScoreText's text get value of gameManager's score
            positionText.GetComponent<TextMeshProUGUI>().text = "#" + (gameManager.GetComponent<PositionScript>().instance.position).ToString();
            sumosDefeatedText.GetComponent<TextMeshProUGUI>().text = gameManager.instance.defeatedSumos.ToString();
        }
        
    }

}
