using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverComponent : MonoBehaviour
{
    [SerializeField]
    private Image _gameOver;

    public void GameOver()
    {
        _gameOver.GetComponent<CanvasGroup>().alpha = 1;
        _gameOver.GetComponent<CanvasGroup>().blocksRaycasts = true;
        SoundManager.Instance.PlaySound(Sound.GameOver);
    }

    public void Restart()
    {
        SoundManager.Instance.PlaySound(Sound.ButtonClick);
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameScene");
    }

    public void LoadMenu()
    {
        SoundManager.Instance.PlaySound(Sound.ButtonClick);
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuScene");
    }
}
