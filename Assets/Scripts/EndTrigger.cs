using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        //test
        gameManager.CommpleteLevel();
    }
}
