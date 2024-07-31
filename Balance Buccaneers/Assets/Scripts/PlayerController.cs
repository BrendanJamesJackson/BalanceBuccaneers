using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    [SerializeField] PlayerInput _playerInput;

    private Rigidbody2D _rb;

    public int _playerNumber;
    public float _moveSpeed;
    public float _turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnValidate()
    {
        _playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float vertical = _playerInput.actions["Move"+_playerNumber].ReadValue<Vector2>().y;
        float horizontal = _playerInput.actions["Move" + _playerNumber].ReadValue<Vector2>().x;

        _rb.velocity = transform.up * vertical * _moveSpeed;

        _rb.MoveRotation(_rb.rotation + _turnSpeed * -horizontal);
    }
}
