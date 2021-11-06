using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
using System.Linq;

public static class SceneSelector
{

    [MenuItem("Scenes/Lobby")]

    static void OpenLobby()
    {
        Load("Lobby");
    }

    [MenuItem("Scenes/Green Place")]

    static void OpenGreenPlace()
    {
        Load("GreenPlace");
    }

    [MenuItem("Scenes/Red Place")]

    static void OpenRedPlace()
    {
        Load("RedPlace");
    }


    static void Load(string scene)
    {

        EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();

        Scene xrScene = EditorSceneManager.OpenScene("Assets/Scenes/XR.unity", OpenSceneMode.Single);

        Scene newScene = EditorSceneManager.OpenScene("Assets/Scenes/" + scene + ".unity", OpenSceneMode.Additive);

        XRSceneTransitionManager.PlaceXRRig(xrScene, newScene);
    }
}
 