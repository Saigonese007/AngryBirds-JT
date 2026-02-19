using TMPro;
using UnityEngine;

public class LevelSelectPanelScript : MonoBehaviour
{

    public GameObject button;
    public int numberOfButtons = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 1; i <= numberOfButtons; i++)
        {
            GameObject newButton = Instantiate(button, transform);
            newButton.GetComponent<ChangeSceneScript>().newLevel = $"Level {i}";
            newButton.GetComponentInChildren<TextMeshProUGUI>().text = $"Level {i}";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
