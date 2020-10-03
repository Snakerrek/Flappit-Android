using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    float velocityY;
    bool isPlayerDead = false;

    [SerializeField] CameraShake cameraShake = null;
    [SerializeField] AudioClip deathSound = null;
    [SerializeField] AudioClip jumpSound = null;
    [SerializeField] AudioClip pointSound = null;
    [SerializeField] float deathSoundVolume = 0.7f;
    [SerializeField] float jumpSoundVolume = 0.7f;
    [SerializeField] float pointSoundVolume = 0.7f;

    Rigidbody2D myRigidbody2D;
    GameController gameController;
    Score score;
    Animator anim;
    new Animation animation;
    int points;
    private void Start()
    {
        gameController= FindObjectOfType<GameController>();
        score = FindObjectOfType<Score>();
        myRigidbody2D = GetComponent<Rigidbody2D>();
        velocityY = gameController.GetPlayerVelocityY();
        anim = GetComponent<Animator>();
        animation = GetComponent<Animation>();
    }
    void Update()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began && !isPlayerDead)
        {
            AudioSource.PlayClipAtPoint(jumpSound, Camera.main.transform.position, jumpSoundVolume);
            Jump();
            anim.SetTrigger("Active");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Heaven")
        {
            Die();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreIncreaser();
    }

    private void Jump()
    {

        myRigidbody2D.velocity = new Vector2(0, velocityY);
    }

    IEnumerator Delay(float a)
    {
        yield return new WaitForSeconds(a);
        FindObjectOfType<SceneLoader>().LoadGameOver();
    }
    private void Die()
    {
        AudioSource.PlayClipAtPoint(deathSound, Camera.main.transform.position, deathSoundVolume);
        StartCoroutine(cameraShake.Shake(0.2f, 0.3f));
        StartCoroutine(Delay(0.2f));
        isPlayerDead = true;
    }
    private void ScoreIncreaser()
    {
        points = gameController.GetPoints();
        AudioSource.PlayClipAtPoint(pointSound, Camera.main.transform.position, pointSoundVolume);
        score.AddPlayerScore(points);
    }
}

