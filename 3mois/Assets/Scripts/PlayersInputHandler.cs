using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static UnityEngine.InputSystem.InputAction;
public class PlayersInputHandler : MonoBehaviour
{

    private Mouvement mouvementScript;
    // Start is called before the first frame update
    void Start()
    {
        mouvementScript.GetComponent<Mouvement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnMove(CallbackContext context)
    {
        
    }
}
