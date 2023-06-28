using UnityEngine;
using Mirror;

/// <summary>
/// Игрок
/// </summary>
public class Player : NetworkBehaviour
{
    /// <summary>
    /// Скорость перемещения
    /// </summary>
    [SerializeField] private float m_MovementSpeed;


    private void Update()
    {
        if (isOwned)
        {
            Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

            transform.Translate(dir * Time.deltaTime * m_MovementSpeed);
        }
    }
}
