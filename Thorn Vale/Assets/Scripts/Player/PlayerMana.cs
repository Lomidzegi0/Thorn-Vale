using UnityEngine;

public class PlayerMana : MonoBehaviour
{
    [Header("Config")]    
    [SerializeField] private PlayerStats stats;


 private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            UseMana(1f);
        }
    }
    public void UseMana(float amount)
    {
        stats.Mana = Mathf.Max(stats.Mana -= amount, 0f);
    }
}