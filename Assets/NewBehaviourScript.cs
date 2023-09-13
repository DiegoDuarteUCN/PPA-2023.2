using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    # region VARIABLES
    // Declarar variable
    [Header("Variables")]
    public int numeroBonito = 11;

    private float _valorQueNoSeVaAVerEnElInspector = 13;
    [SerializeField] private float _valorALaLuz = 31;

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
