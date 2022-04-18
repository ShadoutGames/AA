using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private void Update() 
    {
        if (MainObject.Instance.chilObjectCount==ArrowController.Instance.ArrowIndex)
        {
           GameManager.Instance.StopGame();
           GameManager.Instance.NextLevel();
        }
    }

}
