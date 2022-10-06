using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private const string PlayerTag = "Player";

    private GameManager _gameManager;
    
    
    
    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.CompareTag(PlayerTag)) return;
        if (_gameManager.GetCurrentBuildIndex() <= 2)
        {
            _gameManager.LoadNextLevel();
        }
        else
        {
            _gameManager.LoadScene(1);
        }
    }
}
