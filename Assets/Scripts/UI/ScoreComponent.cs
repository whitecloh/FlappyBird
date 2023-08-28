using UnityEngine;
using UnityEngine.UI;

public class ScoreComponent : MonoBehaviour
{
    [SerializeField]
    private Text _scoreTxt;

    private float _score=0f;
    private int _scoreOut=0;

    public void Score(float i)
    {
        Debug.Log(_score);
        _score += i;
        _scoreOut++;
        if (_scoreOut % 2 == 0)
        {
            _scoreTxt.text = _score.ToString();
            SoundManager.Instance.PlaySound(Sound.Score);
        }
    }
}
