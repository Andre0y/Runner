using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    [SerializeField] private GameObject _vinPanel;
    [SerializeField] private GameObject _gamePanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Victory")
        {
            _gamePanel.SetActive(false);
            _vinPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
