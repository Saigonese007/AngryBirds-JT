using System.Linq;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManagerScript : MonoBehaviour
{
    GameObject[] enemies;

    public float winDelay;

    bool levelCleared = false;

    GameUIScript GameUI;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        GameUI = GameObject.FindGameObjectWithTag("GameUI").GetComponent<GameUIScript>();
        GameUI.SetEnemiesLeft(enemies.Length);
    }

    // Update is called once per frame
    void Update()
    {
        int enemiesAlive = 0;

        for (int i = 0; i < enemies.Length; i++)
        {
            if (enemies[i] != null)
            {
                enemiesAlive++;
            }
        }
        GameUI.SetEnemiesLeft(enemiesAlive);

        if (enemiesAlive == 0 && levelCleared == false)
        {
            levelCleared = true;
            Invoke("ReturnToLevelSelect", winDelay);
            Debug.Log("Level cleared");
        }


    }

    void ReturnToLevelSelect()
    {
        SceneManager.LoadScene("Level Select");
    }
}
