using System.Collections;
using UnityEngine;

public class AngelControls : MonoBehaviour
{

    private bool angelDead = false;
    private Rigidbody2D rb2d;

    private float upForce;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (angelDead == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2 (0, upForce));
            }
        }
        
    }

    void OnCollisionEnter2D ()
    {
        rb2d.velocity = Vector2.zero;
        angelDead = true;
        GameController.instance.angelDied();
    }
}
