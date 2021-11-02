using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformLooper : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float range = 6f;

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.PingPong(Time.time * speed, 1) * range;
        this.gameObject.transform.position = new Vector2(0, y);
    }
}
