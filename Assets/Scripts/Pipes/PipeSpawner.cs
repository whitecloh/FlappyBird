using System.Collections;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _pipePrefab;

    private float _spawnTimer;
    private float _gapSize;

    public float SpawnTimer
    {
        get
        {
            return _spawnTimer;
        }
        set
        {
            _spawnTimer = value;
        } 
    }
    public float GapSize
    {
        get
        {
            return _gapSize;
        }
        set
        {
            _gapSize = value;
        }
    }

    private void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(_spawnTimer);
            CreateGapPipes(Random.Range(20,30), Random.Range(0,_gapSize), 50);
        }
    }

    private void CreateGapPipes(float gapY,float gapSize,float xPosition)
    {
        CreatePipe(gapY-gapSize*0.5f,xPosition, true);
        CreatePipe(-gapY - gapSize * 0.5f,xPosition, false);
    }
    private void CreatePipe(float heigth,float xPosition, bool isBottom)
    {
        GameObject pipe = Instantiate(_pipePrefab,transform);
        Destroy(pipe, 15f);

        if(!isBottom)
        {
            pipe.transform.localScale = new Vector3(1, -1, 1);
        }
        pipe.transform.position = new Vector3(xPosition, -heigth);
    }
}
