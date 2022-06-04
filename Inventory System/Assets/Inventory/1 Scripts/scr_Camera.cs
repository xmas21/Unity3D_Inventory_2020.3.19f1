using UnityEngine;

public class scr_Camera : MonoBehaviour
{
    GameObject player;

    void Awake()
    {
        player = GameObject.Find("ª±®a Player");
    }

    void Update()
    {
        Track();
    }

    /// <summary>
    /// °lÂÜ
    /// </summary>
    void Track()
    {
        Transform _player = player.transform;
        Vector3 temp = new Vector3(_player.position.x, 8f, _player.position.z);

        transform.position = temp;
    }
}
