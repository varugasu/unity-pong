using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public Text playerScoreText;
    public Text computerScoreText;
    private int _playerScore;
    private int _computerScore;

    public void PlayerScores() {
        _playerScore++;
        playerScoreText.text = _playerScore.ToString();

        ResetRound();
    }

    public void ComputerScores() {
        _computerScore++;
        computerScoreText.text = _computerScore.ToString();

        ResetRound();
    }

    private void ResetRound() {
        ball.ResetPosition();
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        Invoke(nameof(AddForceToBall), .5f);
    }

    private void AddForceToBall() {
        ball.AddStartingForce();
    }
}
