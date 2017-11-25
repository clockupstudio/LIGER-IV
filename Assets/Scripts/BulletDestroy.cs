using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{

    void OnEnable()
    {
        // Destroy bullet after 2 seconds.
        Invoke("Destroy", 2f);
    }

    void OnDisable() {
        CancelInvoke();
    }

    void Destroy()
    {
        gameObject.SetActive(false);
    }
}
