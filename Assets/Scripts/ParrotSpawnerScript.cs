using UnityEngine;

public class ParrotSpawnerScript : MonoBehaviour
{
    public GameObject Parrot;
    public Vector2 throwSpeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            newPosition.z = 0;

            GameObject newParrot =  Instantiate(Parrot, Input.mousePosition, Quaternion.identity);
            Rigidbody2D rb = newParrot.GetComponent<Rigidbody2D>();
        }
    }
}
