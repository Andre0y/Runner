using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lose : MonoBehaviour
{
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private GameObject _gamePanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            _gamePanel.SetActive(false);
            _losePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
