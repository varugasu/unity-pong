using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputePaddle : Paddle {
    public Rigidbody2D ball;

    void FixedUpdate() {
        if (ball.velocity.x > 0) {
            if (ball.position.y > transform.position.y) {
                _rigidbody.AddForce(Vector2.up * speed);
            } else if (ball.position.y < transform.position.y) {
                _rigidbody.AddForce(Vector2.down * speed);
            } else {
                _rigidbody.velocity = Vector2.zero;
            }
        } else {
            if (transform.position.y > 0.0f) {
                _rigidbody.AddForce(Vector2.down * speed);
            } else if (transform.position.y < 0.0f) {
                _rigidbody.AddForce(Vector2.up * speed);
            } else {
                _rigidbody.velocity = Vector2.zero;
            }
        }

    }
}
