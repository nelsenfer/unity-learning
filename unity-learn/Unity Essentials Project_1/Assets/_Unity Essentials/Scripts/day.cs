using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // Lama 1 hari (dalam detik dunia nyata)
    // Bisa diubah di Inspector
    [SerializeField] private float dayDurationInSeconds = 120f;

    // Sudut rotasi total untuk 1 hari (360 derajat)
    private const float fullRotation = 360f;

    void Update()
    {
        // Hitung derajat rotasi per detik
        float rotationPerSecond = fullRotation / dayDurationInSeconds;

        // Rotasi light secara perlahan
        transform.Rotate(Vector3.right * rotationPerSecond * Time.deltaTime);
    }
}
