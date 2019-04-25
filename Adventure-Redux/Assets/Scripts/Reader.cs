using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reader : MonoBehaviour
{
  public InputField inputBox;
  public Text outputBox;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      Question(
        "What has many keys, but can't open any doors?",
        "piano",
        "Excellent - you may pass through!",
        "I don't think so, perhaps you should try again."
      );
    }

    bool Question(string q, string a, string right, string wrong) {
      // Ask a question.
      outputBox.text = q;

      if (inputBox.text.ToLower().IndexOf(a) >= 0) {
        outputBox.text += "\n\n" + right;
        // You would probably do something else here too:
        // - Award some points
        // - Remove a barrier
        // - Next level
        return true;
      } else {
        // Prompt to try again or perhaps bring on doom...
        outputBox.text += "\n\n" + wrong;
        return false;
      }
    }
}
