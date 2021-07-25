using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    // �÷��̾� �Է��� �˷��ִ� ������Ʈ
    private PlayerInput playerInput;

    //���� �������� �����Ǵ� ���
    public GameObject magicPrefabPos;

    //���� ������
    public GameObject magicPrefab;

    //������ �߻�� ��ġ
    public Transform magicPosition;

    void Start()
    {
        //����� ������Ʈ�� ���� ��������
        playerInput = GetComponent<PlayerInput>();
    }

    //���� �ֱ⿡ ���� �����
    void Update()
    {
        if (playerInput.fireMagic == true)
        {
            fireMagic();
        }
    }

    private void fireMagic()
    {
        GameObject magic = Instantiate(magicPrefab, magicPosition.position, magicPosition.rotation); // magic�� magicPrefabPos�� �����Ѵ�.
        //magic.transform.LookAt(magicPosition.forward);
    }

}
