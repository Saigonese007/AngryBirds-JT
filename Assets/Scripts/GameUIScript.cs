using TMPro;
using UnityEngine;

public class GameUIScript : MonoBehaviour
{
    public GameObject ShotsLeftText;
    TextMeshProUGUI ShotsLeftTmp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShotsLeftTmp = ShotsLeftText.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetShotsLeft(int num)
    {
        ShotsLeftTmp.text = $"Shots left: {num}";
    }
}
