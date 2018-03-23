using UnityEngine;

public class CommandLineArgsDebugger : MonoBehaviour
{
    #region Method

    private void OnGUI()
    {
        GUILayout.Label("Command Line Args :");
        GUILayout.Label(CommandLineArgs.ToString());

        // NOTE:
        // When you want to get a values.
        // 
        // int[] samplesA;
        // if (CommandLineArgs.GetValuesAsInt("-SamplesA", out samplesA))
        // {
        //     GUILayout.Label("Get Values: " + samplesA.Length);
        // }
    }

    #endregion Method
}