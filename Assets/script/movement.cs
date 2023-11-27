using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float rotationSpeed = 180f;
    // private Animator animator;

    private void Awake()
    {
        // animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // ������ �� ���� ������ �������� ����� ������
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // ����� ������ ������ ������ ������
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        transform.Translate(movement * movementSpeed * Time.deltaTime);

        // ������ �� ������ ������
        float rotateY = Input.GetAxis("Mouse X");
        Vector3 rotation = new Vector3(0f, rotateY, 0f);
        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);


        // ����� ���� ���������
        //if (movement.magnitude > 0f)
        //{
        //       animator.SetBool("IsMoving", true);
        // }
        //  else
        // {
        //   animator.SetBool("IsMoving", false);
        // }

    }
}


