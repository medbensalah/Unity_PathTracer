using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Transform _transform;

    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float speedMultiplier = 2;
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            speedMultiplier = 10;
        }

        if (Input.GetKey(KeyCode.W))
        {
            _transform.position += _transform.forward * (Time.deltaTime * 10 * speedMultiplier);
        }

        if (Input.GetKey(KeyCode.S))
        {
            _transform.position -= _transform.forward * (Time.deltaTime * 10 * speedMultiplier);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _transform.position -= _transform.right * (Time.deltaTime * 10 * speedMultiplier);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _transform.position += _transform.right * (Time.deltaTime * 10 * speedMultiplier);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            _transform.position -= _transform.up * (Time.deltaTime * 10 * speedMultiplier);
        }

        if (Input.GetKey(KeyCode.E))
        {
            _transform.position += _transform.up * (Time.deltaTime * 10 * speedMultiplier);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            var newRotation = _transform.rotation.eulerAngles;
            newRotation.x += Time.deltaTime * 45;
            _transform.rotation = Quaternion.Euler(newRotation);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            var newRotation = _transform.rotation.eulerAngles;
            newRotation.x -= Time.deltaTime * 45;
            _transform.rotation = Quaternion.Euler(newRotation);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            var newRotation = _transform.rotation.eulerAngles;
            newRotation.y -= Time.deltaTime * 45;
            _transform.rotation = Quaternion.Euler(newRotation);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            var newRotation = _transform.rotation.eulerAngles;
            newRotation.y += Time.deltaTime * 45;
            _transform.rotation = Quaternion.Euler(newRotation);
        }
    }
}