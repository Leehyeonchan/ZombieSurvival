using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// �÷��̾� ĳ���͸� �����ϱ� ���� ����� �Է��� ����
// ������ �Է°��� �ٸ� ������Ʈ�� ����� �� �ֵ��� ����

public class PlayerInput : MonoBehaviour
{
    // �յ� �������� ���� �Է��� �̸�
    public string moveAxisName = "Vertivcal";
    // �¿� ȸ���� ���� �Է��� �̸�
    public string rotateAxisName = "Horizontal";
    // �߻縦 ���� �Է� ��ư �̸�
    public string fireButtonName = "Fire1";
    // �������� ���� �Է� ��ư �̸�
    public string reloadButtonName = "Reload";

    // ������Ƽ : �� �Ҵ��� ���ο����� ����
    // ������ ������ �Է°�
    public float move { get; private set; }
    // ������ ȸ�� �Է°�
    public float rotate { get; private set; }
    //������ �߻� �Է°�
    public bool fire { get; private set; }
    // ������ ������ �Է°�
    public bool reload { get; private set; }

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // �������� ����� �Է��� ����
    void Update() { 
        // ���ӿ��� ���¿����� ����� �Է��� �������� ����
        if(GameMamager.instance != null && GameManager.instance.isGaneover)
    {
        move = 0;
        rotate = 0;
        fire = false;
        reload = false;
        return;
    }

        // move�� ���� �Է� ����

        move =  Input.GetAxis(moveAxisName);
        // rotatemove�� ���� �Է� ����

        rotate = Input.GetAxis(rotateAxisName);

        // fire�� ���� �Է� ����

        fire = Input.GetButton(fireButtonName);

        // reload�� ���� �Է� ����

        reload = Input.GetButtonDown(reloadButtonName);

    }
