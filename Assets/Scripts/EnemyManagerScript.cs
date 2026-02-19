using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManagerScript : MonoBehaviour
{
    GameObject[] enemies;

    public float winDelay;

    bool levelCleared = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
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
