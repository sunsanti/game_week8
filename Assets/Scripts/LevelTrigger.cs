
using UnityEngine;

public class LevelTrigger : MonoBehaviour
{
    public GameObject GameMenu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player collided with Wall!");

            GameMenu.SetActive(true);
        }
    }
}
