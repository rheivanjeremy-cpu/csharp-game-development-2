using UnityEngine;

public class BelajarWhile : MonoBehaviour
{
    void Start()
    {
        int hitungMundur = 5;

        Debug.Log("== Memulai Hitung Mundur ==");

        while (hitungMundur > 0)
        {
            Debug.Log("Waktu tersisa: " + hitungMundur);
            hitungMundur--;
        }

        Debug.Log("Game Dimulai!");
    }
}