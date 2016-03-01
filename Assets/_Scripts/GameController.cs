using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class GameController : MonoBehaviour
{
    // PRIVATE INSTANCE VARIABLES
    private int _scoreValue;
    private int _livesValue;


    //[SerializeField]
    //private AudioSource _gameOverSound;



    // PUBLIC ACCESS METHODS
    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }

        set
        {
            this._scoreValue = value;
            this.ScoreLabel.text = "Score: " + this._scoreValue;

        }
    }

    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }

        set
        {
            this._livesValue = value;
            if (this._livesValue <= 0)
            {
                //this._endGame();
                this._endGame();
            }
            else
            {
                this.LivesLabel.text = "Lives: " + this._livesValue;
            }
        }
    }





    //PUBLIC INSTANCE VARIABLES
    ////public int enemyNumber = 3;
    ////public EnemyController enemy;
    public Text LivesLabel;
    public Text ScoreLabel;
    public Text Good;
    //public Text GameOverLabel2;
    //public PlayerController player;
    //public CoinController coin;
    //public Text HighScoreLabel;
    //public Button RestartButton;

    // Use this for initialization
    void Start()
    {

        this._initialize();
        //enemy.gameObject
    }

    // Update is called once per frame
    void Update()
    {

    }

    //private methods=========================



    private void _initialize()
    {
        this.ScoreValue = 0;
        this.LivesValue = 5;


        //this.Good.gameObject.SetActive(false);
        //this.HighScoreLabel.gameObject.SetActive(false);
        //this.RestartButton.gameObject.SetActive(false);
        


        //for (int enemyCount = 0; enemyCount < this.enemyNumber; enemyCount++)
        //{
        //    Instantiate(enemy.gameObject);
        //}
    }


    private void _endGame()
    {
        //this.GameOverLabel.gameObject.SetActive(true);
        //this.player.gameObject.SetActive(false);
        //this.coin.gameObject.SetActive(false);
        //this.LivesLabel.gameObject.SetActive(false);
        //this.ScoreLabel.gameObject.SetActive(false);
        //this.HighScoreLabel.gameObject.SetActive(true);
        //this.HighScoreLabel.text = "High Score: " + this._scoreValue;
        //this._gameOverSound.Play();
        //this.RestartButton.gameObject.SetActive(true);
    }





    // PUBLIC METHODS

    public void RestartButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}