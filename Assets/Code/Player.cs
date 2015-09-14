using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float m_score = 0;
    private float speed = 0.1f;
    private bool canRotate = false;
    private float rotateSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        //beweeg de speler naar rechts
        this.transform.position += Vector3.right * speed;

        if (canRotate == true)
        {
            this.transform.Rotate(0,0,1);
        }
    }

    public void AddScore()
    {
        Debug.Log("triggered");
        m_score += 1;
    }

    public void Slow()
    {
        speed = 0.05f;
    }

    public void Rotate()
    {
        canRotate = true;
    }
}
