using UnityEngine;

public class Byte : MonoBehaviour
{
    [SerializeField] private Bit[] bits = new Bit[8]; // bits[0] = meest rechtse bit
    [SerializeField] private int value = 0;           // Decimale waarde

    // Zet de waarde van de byte en converteer naar binaire waarde
    public void SetValue(int newValue)
    {
        // Beperk de waarde tot 255 (omdat een byte slechts 8 bits heeft)
        if (newValue > 255)
        {
            newValue = 255;
        }

        // Sla de nieuwe waarde op
        this.value = newValue;

        // Converteer de waarde naar binaire vorm en stel de bits in
        for (int i = 0; i < 8; i++)
        {
            // Controleer of de bit actief moet zijn (True of False)
            bits[i].state = (newValue & (1 << (7 - i))) != 0;
        }
    }

    // Update wordt aangeroepen in elke frame, hier wordt de waarde berekend op basis van de bits
    void Update()
    {
        BinToDec();
    }

    // Bereken de waarde van de byte op basis van de bits
    private void BinToDec()
    {
        value = 0; // Begin opnieuw bij 0

        // Controleer de status van elk bit en voeg de overeenkomstige waarde toe
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
