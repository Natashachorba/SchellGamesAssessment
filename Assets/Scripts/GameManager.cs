using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball Ball;

    public Bumper PlayerBumper;
    private int _playerScore;
    public Text PlayerScoreText;

    public Bumper AIBumper;
    private int _AIScore;
    public Text AIScoreText;



    void Start()
    {
        NewGame();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NewGame()
    {
        _playerScore = 0;
        _AIScore = 0;
        StartNewRound();
    }

    private void StartNewRound()
    {
        PlayerBumper.ResetPosition();
        AIBumper.ResetPosition();
        Ball.StartRound();
    }

    public void PlayerScores()
    {
        _playerScore++;
        PlayerScoreText.text = $"Player Score: {_playerScore}";
        StartNewRound();
    }

    public void AIScores()
    {
        _AIScore++;
        AIScoreText.text = $"AI Score: {_AIScore}";
        StartNewRound();
    }
}
