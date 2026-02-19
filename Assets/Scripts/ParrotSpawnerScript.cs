using UnityEngine;

public class ParrotSpawnerScript : MonoBehaviour
{
    public GameObject Parrot;
    public GameObject[] shots;
    int nextShot = 0;

    GameUIScript GameUI;

    public float throwStrength = 1;
    public float maxSpeed = 10;

    bool isDragging = false;

    SpriteRenderer colorChange;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Color newColor = new Color(0.3f, 0.4f, 0.6f);
        colorChange = GetComponent<SpriteRenderer>();

        GameUI = GameObject.FindGameObjectWithTag("GameUI").GetComponent<GameUIScript>();
        GameUI.SetShotsLeft(shots.Length);

    }

    // Update is called once per frame
    void Update()
    {
 
        if (Input.GetMouseButtonUp(0) && isDragging && nextShot < shots.Length)
        {
            isDragging = false;

            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            MousePos.z = 0;

            Vector2 throwVelocity = (transform.position - MousePos) * throwStrength;
            if (throwVelocity.magnitude > maxSpeed)
            {
                throwVelocity = throwVelocity.normalized * maxSpeed;
            }

            GameObject newParrot = Instantiate(shots[nextShot], transform.position, Quaternion.identity);
            nextShot++;
            Rigidbody2D rb = newParrot.GetComponent<Rigidbody2D>();
            rb.linearVelocity = throwVelocity;

            GameUI.SetShotsLeft(shots.Length - nextShot);
        }

        if (isDragging)
        {
            colorChange.color = Color.softRed;
        }
        else
        {
            colorChange.color = Color.white;
        }
    }

    private void OnMouseDown()
    {

        if (nextShot < shots.Length)
        {
        isDragging = true;

        }
    }
}
