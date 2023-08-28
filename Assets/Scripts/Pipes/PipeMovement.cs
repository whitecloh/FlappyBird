using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    private float _speed;

    private void Start()
    {
        _speed = GameManager.Instance.PipeSpeed;
    }

    private void Update()
    {
        transform.Translate(-_speed * Time.deltaTime, 0, 0);
    }
}
