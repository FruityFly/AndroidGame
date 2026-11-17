using UnityEngine;

[CreateAssetMenu(fileName = "Enemy_SO", menuName = "Scriptable Objects/Enemy_SO")]
public class Enemy_SO : ScriptableObject
{
    public Sprite sprite;
    public new string name;
    public int dropAmount;
    public int hp;
    public int speed;
    public int attack;
}
