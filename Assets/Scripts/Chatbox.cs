using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �Ψ��x�s��ܮت��T��
// ex: ��ѹ�H���H���Y��, ��ܮ�, ...

[CreateAssetMenu(fileName = "New Chatbox", menuName = "Chatbox/New Chatbox")]
public class Chatbox : ScriptableObject
{
    public Sprite HeadImage; // �Y���Ϥ�
    public Sprite ChatboxImage; // ��ܮعϤ�
    [TextArea] // �i�H��J�h�椺�e, �Ӥ��A�ȭ���1��
    public string Info; // ���դ�r(ex: �ɶ�)
}
