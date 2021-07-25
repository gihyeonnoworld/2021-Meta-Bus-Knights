using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour
{
    public float speed = 15f;
    private Rigidbody magicRigidbody;

    //������ ������ ��ġ�� ������ ����
    Vector3 hitPosition = Vector3.zero;

    //���� ���߽� ȿ��
    public GameObject magicEffectPrefab;

    void Start()
    {
        magicRigidbody = GetComponent<Rigidbody>();
        magicRigidbody.velocity = transform.forward * speed;

        //���� �ð��� ������ �ı�
        Destroy(gameObject, 4f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            Debug.Log("���ߵ�!");
            GameObject magicEffect = Instantiate(magicEffectPrefab, collision.transform.position, collision.transform.rotation);
            Destroy(magicEffect, 2f);
            Destroy(gameObject);
        }
        else if (collision.collider.CompareTag("Level"))
        {
            Destroy(gameObject);
        }
    }

}


