using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _force;
    [SerializeField]
    private Rigidbody2D _rb;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0)&&Time.timeScale>0f)
        {
            Jump();
        }
    }

    private void Jump()
    {
        _rb.velocity = Vector2.up * _force;
        SoundManager.Instance.PlaySound(Sound.BirdJump);
    }
}
