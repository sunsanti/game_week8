using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("!");
        if (other.CompareTag("Player"))
        {
            Debug.Log("!");
            SceneManager.LoadScene("_Scene_1");
        }
    }
}