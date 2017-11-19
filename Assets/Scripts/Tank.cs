using UnityEngine;

public class Tank : MonoBehaviour
{

    // Speed tank movement
    public float Speed = 5f;

    Vector3 _direction = Vector3.zero;
    float _angle = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector3.down;
            _angle = 180f;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            _direction = Vector3.up;
            _angle = 0f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            _direction = Vector3.left;
            _angle = 90f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _direction = Vector3.right;
            _angle = -90f;
        }
        else
        {
            _direction = Vector3.zero;
        }

        transform.rotation = Quaternion.Euler(0, 0, _angle);
        transform.position += _direction * Time.deltaTime * Speed;
    }
}
