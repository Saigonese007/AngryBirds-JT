using TMPro;
using UnityEngine;

public class GameUIScript : MonoBehaviour
{
    public GameObject ShotsLeftText, EnemiesLeftText;
    TextMeshProUGUI ShotsLeftTmp, EnemiesLeftTmp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        ShotsLeftTmp = ShotsLeftText.GetComponent<TextMeshProUGUI>();
        EnemiesLeftTmp = EnemiesLeftText.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetShotsLeft(int num)
    {
        ShotsLeftTmp.text = $"Shots left: {num}";
    }

    public void SetEnemiesLeft(int num)
    {
        EnemiesLeftTmp.text = $"Enemies left: {num}";
    }
}
