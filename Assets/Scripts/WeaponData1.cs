using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/WeaponData")]
public class WeaponData : ScriptableObject
{
    public GameObject bulletModel;

    public float bulletSpeed;
    public float fireCooldown;
    public int clipSize;
}
