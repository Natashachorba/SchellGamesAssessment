using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball Ball;
    
    private int _playerScore;
    private int _AIScore;

    public void PlayerScores()
    {
        _playerScore++;
        Ball.ResetPosition();
    }

    public void AIScores()
    {
        _AIScore++;
        Ball.ResetPosition();
    }

    private void ResetGame()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
