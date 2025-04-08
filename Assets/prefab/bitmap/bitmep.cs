using UnityEngine;

public class bitmap : MonoBehaviour
{
    [SerializeField] private Byte[] bites = new Byte[8];
    [SerializeField] int[] values;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<8;i++)
        {
            bites[i].SetValue(values[i]);
        }
    }
}
