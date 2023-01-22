using UnityEngine;

[CreateAssetMenu(fileName = "New character class", menuName = "Character class")]
public class Char_Class : ScriptableObject
{
    public string Class_name;
    public int STR;
    public int INT;
    public int WP;
    public int AGI;
    public int END;
    public int LUCK;
}
