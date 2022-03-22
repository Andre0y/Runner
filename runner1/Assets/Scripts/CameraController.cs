using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 _offset = new Vector3(0, 4, -10);
    [SerializeField] private Transform _player;



    void LateUpdate ()
    {
        transform.position = _player.transform.position + _offset;
	}
}
