using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(0f, moveY, moveX) * 10f * Time.deltaTime;
        transform.Translate(movement);
    }
}
