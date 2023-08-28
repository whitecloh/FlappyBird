using UnityEngine;

public class PlayerTriggers : MonoBehaviour
{
    [SerializeField]
    private LayerMask _point;
    [SerializeField]
    private ScoreComponent _scoreComponent;
    [SerializeField]
    private GameOverComponent _gameOverComponent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer==7)
        {
            _scoreComponent.Score(0.5f);
        }
        else
        {
            Time.timeScale = 0f;
            _gameOverComponent.GameOver();
        }
    }
}
