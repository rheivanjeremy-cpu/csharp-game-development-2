using UnityEngine;

public class BelajarLogika : MonoBehaviour
{
    public int angka = 10;

    void Start()
    {
        if (angka > 0)
        {
            Debug.Log("Hasil Percabangan: Angka ini POSITIF");
        }
        else if (angka < 0)
        {
            Debug.Log("Hasil Percabangan: Angka ini NEGATIF");
        }
        else
        {
            Debug.Log("Hasil Percabangan: Angka ini adalah NOL");
        }

        // FOR LOOP
        for (int i = 1; i <= 5; i++)
        {
            Debug.Log("Hasil Perulangan ke-" + i);
        }
    }
}