using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float speed = 5f; // Speed of movement

    void Update()
    {
        // Move the cube forward based on its current orientation
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}