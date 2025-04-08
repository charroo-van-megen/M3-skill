using UnityEngine;

public class Byte : MonoBehaviour
{
    [SerializeField] private Bit[] bits = new Bit[8]; // bits[0] = meest rechtse bit
    [SerializeField] private int value = 0;           // Decimale waarde

    void Update()
    {
        BinToDec();
    }

    private void BinToDec()
    {
        value = 0; // Begin opnieuw bij 0

        if (bits[0].state) { value += 1; }
        if (bits[1].state) { value += 2; }
        if (bits[2].state) { value += 4; }
        if (bits[3].state) { value += 8; }
        if (bits[4].state) { value += 16; }
        if (bits[5].state) { value += 32; }
        if (bits[6].state) { value += 64; }
        if (bits[7].state) { value += 128; }

    }
}
