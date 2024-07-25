using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = this.GetComponent<Rigidbody>();

        // Rigidbodyが見つからなかった場合のデバッグメッセージ
        if (_rigidbody == null)
        {
            Debug.LogError("Rigidbodyがアタッチされていません！");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.forward * 10f, ForceMode.Impulse);
            Debug.Log("スペースキーが押された!");
        }
    }
}
