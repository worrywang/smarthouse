using UnityEngine;
using System.Collections;

public class ButtonScripts : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnLabelButtonClick() {
        print("Label button be click.");
    }

    public void OnSpriteButtonClick() {
        print("SpriteButton has be clicked.");
    }

    public void DisabledButton(GameObject go) {
        if (go != null) {
            UIButton[] ub = go.GetComponents<UIButton>();
            Debug.Log("disabled button is pressed.");

            if (ub != null && ub.Length > 0)
            {
                Debug.Log("UIButton list sizes "+ub.Length);
                //for (int i = 0; i < ub.Length; i++)
                //{
                //    if (ub[i].isEnabled)
                //    {
                //        ub[i].enabled = false;
                //    }
                //    else
                //    {
                //        ub[i].enabled = true;
                //    }
                //}

            }
        }
    }
}
