using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIManager : MonoBehaviour
{
    public TMPro.TMP_Text scoreTextValue;
    public TMPro.TMP_Text levelTextValue;
    public TMPro.TMP_Text linesTextValue;

    public GameObject pauseMenu;
    public GameObject gameOverMenuPrefab;

    private GameObject _gameOverMenu;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !pauseMenu.activeSelf && _gameOverMenu == null) {
            pauseMenu.SetActive(true);
            pauseMenu.GetComponent<PauseMenu>().PauseGame();
        }
    }

    public void UpdateScoreValue(int score)
    {
        scoreTextValue.text = score.ToString();
    }

    public void UpdateLevelValue(int level)
    {
        levelTextValue.text = level.ToString();
    }

    public void UpdateLinesValue(int lines)
    {
        linesTextValue.text = lines.ToString();
    }

    public void showGameOverMenu(int score)
    {
        _gameOverMenu = Instantiate(gameOverMenuPrefab, transform);
        _gameOverMenu.GetComponent<GameOverMenu>().setScore(score);
    }
}
