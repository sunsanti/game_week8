using UnityEngine;

public class AirplaneController : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        transform.position -= transform.forward * speed * Time.deltaTime;
    }

}