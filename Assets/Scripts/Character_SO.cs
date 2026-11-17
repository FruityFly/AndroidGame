using UnityEngine;

/*
 * Kafka Suenishi   
 * 11/17/26
 * Holds default values for characters
 */

[CreateAssetMenu(fileName = "Character_SO", menuName = "Scriptable Objects/Character_SO")]
public class Character_SO : ScriptableObject
{
    public Sprite sprite;
    public new string name;
    public int cost;
    public int hp;
    public int speed;
    public int attack;
}
