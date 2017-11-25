using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{

    // Bullet is game object want to fire.
    public GameObject Bullet;

    public float FireRate = 0.05f;

    public int PooledAmount = 20;

    List<GameObject> _bullets;

    // Use this for initialization
    void Start()
    {
        _bullets = new List<GameObject>();
        for (var i = 0; i < PooledAmount; i++)
        {
            var obj = Instantiate(Bullet, transform.position, Quaternion.identity);
            obj.SetActive(false);
            _bullets.Add(obj);
        }
        InvokeRepeating("Fire", FireRate, FireRate);
    }

    // Update is called once per frame
    void Fire()
    {
        for (var i = 0; i < _bullets.Count; i++)
        {
            var bullet = _bullets[i];
            if (!bullet.activeInHierarchy)
            {
                Debug.Log(string.Format("Bullet #{0} is {1}", i, bullet.activeInHierarchy));
                bullet.transform.position = transform.position;
                // rotate the bullet base on tank rotation.
                bullet.transform.rotation = transform.rotation;
                bullet.SetActive(true);
                break;
            }
        }
    }
}
