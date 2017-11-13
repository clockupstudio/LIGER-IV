using UnityEngine;

public class TankInputBehaviour : MonoBehaviour
{

    // Speed tank movement
    public float Speed = 5;

    // Update is called once per frame
    void Update()
    {
        var direction = Vector3.zero;

        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction = Vector3.down;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            direction = Vector3.up;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = Vector3.left;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = Vector3.right;
        }

        transform.Translate(direction * Time.deltaTime * Speed);
    }
}
