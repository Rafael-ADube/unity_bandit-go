using UnityEngine;
using extOSC;

public class OSCSpawnControl : MonoBehaviour
{
    public extOSC.OSCReceiver oscReceiver;
    public extOSC.OSCTransmitter oscTransmitter;
    public voiture_bleu voiture_bleu;
    public voiture_rouge voiture_rouge;
    public static float spawnInterval = 3f;

    private void Start()
    {
        oscReceiver.Bind("*", OnSpawnIntervalReceived);
  
    }

    void OnSpawnIntervalReceived(OSCMessage oscMessage)
    {
        float value;
        if (oscMessage.Values[0].Type == OSCValueType.Int)
        {
            value = oscMessage.Values[0].IntValue;
            
        }
        else if (oscMessage.Values[0].Type == OSCValueType.Float)
        {
            value = oscMessage.Values[0].FloatValue;
            
            if(oscMessage.Address == "/voitureBleu")  {
            voiture_bleu.vitesseVoiture = value;
            }

            if(oscMessage.Address == "/voitureRouge")  {
            voiture_rouge.vitesseVoiture = value;
            }
        
        }
        else
        {
       
            // Si la valeur n'est ni un foat ou int, on quitte la méthode :
            return;
        }


    }
}
