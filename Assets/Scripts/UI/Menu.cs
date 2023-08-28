using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private GameObject _settingsPanel;


    public void ShowSettings()
    {
        SoundManager.Instance.PlaySound(Sound.ButtonClick);
        _settingsPanel.GetComponent<CanvasGroup>().alpha = 1;
        _settingsPanel.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    public void CloseSettings()
    {
        SoundManager.Instance.PlaySound(Sound.ButtonClick);
        _settingsPanel.GetComponent<CanvasGroup>().alpha = 0;
        _settingsPanel.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    public void StartNewGame()
    {
        SoundManager.Instance.PlaySound(Sound.ButtonClick);
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGame()
    {
        SoundManager.Instance.PlaySound(Sound.ButtonClick);
#if UNITY_EDITOR
        EditorApplication.isPaused = true;
#elif UNITY_ANDROID
        Application.Quit();
#endif
    }
}
