using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _sensivity;
    [SerializeField] private float _speed;
    [SerializeField] private int coins;
    [SerializeField] private Text textCoins;
    private int _xRange = 13;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move(Vector3.forward);
        Limit();
        if (Input.touchCount > 0)
        {
            MoveHorizontal();
        }
    }

    private void Move(Vector3 direction)
    {
        transform.Translate(_speed * Time.deltaTime * direction);
    }

    private void Limit()
    {
        if (transform.position.x < -_xRange)
        {
            transform.position = new Vector3(-_xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > _xRange)
        {
            transform.position = new Vector3(_xRange, transform.position.y, transform.position.z);
        }
    }

    private void MoveHorizontal()
    {
        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Moved)
        {
            float move = touch.deltaPosition.x * Time.deltaTime * _sensivity;
            _rigidbody.AddForce(Vector3.right * move);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            coins++;
            textCoins.text = coins.ToString();
            Destroy(other.gameObject);
        }
        
        
        if (other.gameObject.tag == "MediumCoin")
        {
           coins += 3;
           textCoins.text = coins.ToString();
           Destroy(other.gameObject);
        }
        
        
        if (other.gameObject.tag == "BigCoin")
        {
                coins += 10;
                textCoins.text = coins.ToString();
                Destroy(other.gameObject);
        }
        

    }
}

