using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/WeaponData1", order = 1)]
public class WeaponData1 : ScriptableObject
{
    public GameObject bulletModel;

    public float bulletSpeed;
    public float fireCooldown;
    public int clipSize;
}
