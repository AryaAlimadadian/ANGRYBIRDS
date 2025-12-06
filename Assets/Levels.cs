using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    static int _nextLevelIndex = 1;
    Kill[] _enemies;

    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Kill>();
    }
    void Update()
    {
       foreach(Kill enemy in  _enemies)
        {
            if (enemy != null)
                return;
        }

        Debug.Log("You killed all enemies");

        _nextLevelIndex++;
        Debug.Log(_nextLevelIndex);
        string nextLevelName = "Level" + _nextLevelIndex;
        SceneManager.LoadScene(nextLevelName);
    }
}
