using UnityEngine;

public class MyPixel : MonoBehaviour
{
    public Byte ByteR;
    public Byte ByteG;
    public Byte ByteB;
    public GameObject Pixel;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        if (Pixel != null)
        {
            spriteRenderer = Pixel.GetComponent<SpriteRenderer>();
        }

        if (ByteR != null && ByteG != null && ByteB != null && Pixel != null)
        {
            string colorCode = "#" + ByteR.getHex() + ByteG.getHex() + ByteB.getHex();

            if (ColorUtility.TryParseHtmlString(colorCode, out Color newColor))
            {
                spriteRenderer.color = newColor;
            }
            else
            {
                Debug.LogError("Ongeldige hex kleur: " + colorCode);
            }
        }
        else
        {
            Debug.LogError("Zorg dat alle referenties (ByteR, ByteG, ByteB, Pixel) correct zijn ingesteld in de Inspector.");
        }
    }
}
