using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private PipeSpawner _pipeSpawner;

    [SerializeField]
    private float _easyLevelSpawnTimer;
    [SerializeField]
    private float _mediumLevelSpawnTimer;
    [SerializeField]
    private float _hardLevelSpawnTimer;

    [SerializeField]
    private float _easyLevelGapSize;
    [SerializeField]
    private float _mediumLevelGapSize;
    [SerializeField]
    private float _hardLevelGapSize;

    [SerializeField]
    private float _easyLevelPipeSpeed;
    [SerializeField]
    private float _mediumLevelPipeSpeed;
    [SerializeField]
    private float _hardLevelPipeSpeed;

    private float _spawnTimer;
    private float _gapSize;
    private float _pipeSpeed;
    public float PipeSpeed => _pipeSpeed;

    private int _modeType;

    private static GameManager instance;
    public static GameManager Instance => instance;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        if (PlayerPrefs.HasKey("_modeNumber"))
        {
            _modeType = PlayerPrefs.GetInt("_modeNumber");
            LoadParameters(_modeType);
        }
    }

    private void LoadParameters(int type)
    {
        switch(type)
        {
            case 0:
                Debug.Log("Easy Level");
                _spawnTimer = _easyLevelSpawnTimer;
                _gapSize = _easyLevelGapSize;
                _pipeSpeed = _easyLevelPipeSpeed;
                break;
            case 1:
                Debug.Log("Medium Level");
                _spawnTimer = _mediumLevelSpawnTimer;
                _gapSize = _mediumLevelGapSize;
                _pipeSpeed = _mediumLevelPipeSpeed;
                break;
            case 2:
                Debug.Log("Hard Level");
                _spawnTimer = _hardLevelSpawnTimer;
                _gapSize = _hardLevelGapSize;
                _pipeSpeed = _hardLevelPipeSpeed;
                break;
            default:
                Debug.Log("No prmtrs");
                break;
        }

        _pipeSpawner.SpawnTimer = _spawnTimer;
        _pipeSpawner.GapSize = _gapSize;

    }
}
