using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PusherScript : MonoBehaviour
{
    Rigidbody _rb;
    Vector3 _defaultPos;

    [SerializeField]
    [Header("スピード")]
    float _speed;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _defaultPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        _rb.MovePosition(new Vector3(_defaultPos.x, _defaultPos.y, _defaultPos.z + Mathf.PingPong(Time.time, _speed)));
    }
}
