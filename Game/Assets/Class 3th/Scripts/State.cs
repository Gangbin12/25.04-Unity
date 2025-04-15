using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    private void Awake()
    {
        // Awake �Լ���?
        // ���� ������Ʈ�� �����Ǿ��� �� �� �ѹ��� ȣ��Ǹ�
        // ��ũ��Ʈ�� ��Ȱ��ȭ�Ǿ� �ִ� ���¿����� ȣ��Ǵ� �̺�Ʈ�Լ��Դϴ�.

        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        // OnEnable �Լ���?
        // ���� ������Ʈ�� Ȱ��ȭ�Ǵ� �������� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("OnEnable");
    }

    private void Start()
    {
        // Start �Լ���?
        // ���� ������Ʈ�� �����Ǿ��� �� �� �� ���� ȣ��Ǹ�,
        // ��ũ��Ʈ�� ��Ȱ��ȭ�� ������ ��, ȣ����� �ʴ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        // FixedUpdate �Լ���?
        // TimeStep�� ������ ���� ���� ������ �������� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("FixedUpdate");
    }

    private void Update()
    {
        // Update �Լ���?
        //

        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // Late Update �Լ���?
        // Update �Լ��� ȣ��� ���Ŀ� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("LateUpdate");
    }

    private void OnDisable()
    {
        // OnDisable �Լ���?
        // ���� ������Ʈ�� ��Ȱ��ȭ �Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        // OnDestroy �Լ���?
        // ���� ������Ʈ�� �����Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("OnDestroy");
    }
}
