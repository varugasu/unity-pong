using UnityEngine;

public class Ball : MonoBehaviour {

    public float speed = 200;
    private Rigidbody2D _rigidbody;

    void Awake() {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Start() {
        ResetPosition();
        Invoke(nameof(AddStartingForce), 1);
    }

    public void AddStartingForce() {
        float x = Random.value < 0.5f ? -1 : 1;
        float y = Random.value < 0.5f ?
         Random.Range(-1.0f, -0.5f) :
         Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);

        _rigidbody.AddForce(direction * speed);
    }


    public void AddForce(Vector2 direction) {
        _rigidbody.AddForce(direction);
    }

    public void ResetPosition() {
        _rigidbody.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }
}
