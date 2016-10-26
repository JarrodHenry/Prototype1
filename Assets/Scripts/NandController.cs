using UnityEngine;
using System.Collections;


public class NandController : MonoBehaviour {

    public Transform inputA;
    public Transform inputB;
    public Transform output;
    private InputController scriptA;
    private InputController scriptB;
    
	// Use this for initialization
	void Start () {
        
        inputA = transform.FindChild("Input A");
        inputB = transform.FindChild("Input B");
        
        output = transform.FindChild("Output");
      
         scriptA = inputA.GetComponent<InputController>();
         scriptB = inputB.GetComponent<InputController>();
	}
	
	
	void FixedUpdate () {

        bool result = GateModule.NandGate(scriptA.Status, scriptB.Status);
        // bool result = GateModule.(scriptA.Status);
        if (result)
        {
            output.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);
        }
        else
        {
            output.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
        }
	}
}

public class GateModule
{
    public static bool AndGate(bool a, bool b)
    {
        // Programatically
        //return a && b;

        // NAND Logic
        bool nand1 = NandGate(a, b);
        return NandGate(nand1, nand1);

    }

    public static bool OrGate(bool a, bool b)
    {
        //Programatically
        //return a || b;

        // NAND Logic
        bool nand1 = NandGate(a, a);
        bool nand2 = NandGate(b, b);
        return NandGate(nand1, nand2);
    }

    public static bool NotGate(bool a)
    {
        // return !a;
        return NandGate(a, a);
    }

    public static bool XorGate(bool a, bool b)
    {
        // Programmatically 
        // return a ^ b;

        // NAND Logic
        bool nand1 = NandGate(a, b);
        bool nand2 = NandGate(nand1, a);
        bool nand3 = NandGate(nand1, b);
        return NandGate(nand2, nand3);

    }

    public static bool NandGate(bool a, bool b)
    {
        return !(a && b);
    }

    public static bool NorGate(bool a, bool b)
    {
        return !(a || b);
    }
}
