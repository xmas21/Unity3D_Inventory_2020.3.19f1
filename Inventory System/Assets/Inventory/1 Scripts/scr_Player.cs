using UnityEngine;
using UnityEngine.UI;

public class scr_Player : MonoBehaviour
{
    public static scr_Player instance;

    float moveSpeed;
    public int hp;
    public int mp;
    public int coin;

    public Text hp_text;
    public Text mp_text;
    public Text coin_text;

    void Awake()
    {
        instance = this;

        hp_text = GameObject.Find("UI/HP").GetComponent<Text>();
        mp_text = GameObject.Find("UI/MP").GetComponent<Text>();
        coin_text = GameObject.Find("UI/COIN").GetComponent<Text>();
    }

    void Start()
    {
        Initialize();
    }

    void Update()
    {
        Move(moveSpeed);
        UpdateHUD();
    }

    /// <summary>
    /// ��l��
    /// </summary>
    void Initialize()
    {
        moveSpeed = 5;
    }

    /// <summary>
    /// ����
    /// </summary>
    /// <param name="_speed">�t��</param>
    void Move(float _speed)
    {
        transform.Translate(Input.GetAxisRaw("Horizontal") * Time.deltaTime * _speed, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime * _speed);
    }

    /// <summary>
    /// ��s���
    /// </summary>
    void UpdateHUD()
    {
        hp_text.text = "HP : " + hp;
        mp_text.text = "MP : " + mp;
        coin_text.text = "COIN : " + coin;
    }
}
