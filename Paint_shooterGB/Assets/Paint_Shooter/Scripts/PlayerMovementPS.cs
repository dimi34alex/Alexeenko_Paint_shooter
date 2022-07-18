using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementPS : MonoBehaviour
{
    private Vector3 direction;
    private Vector3 view;
    [SerializeField] private float speed = 5f;
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");
        transform.position += direction * speed * Time.deltaTime;

        view.y = Input.GetAxis("HorizontalView");
        view.x = Input.GetAxis("VerticalView");
        transform.rotation += view;
    }
}
