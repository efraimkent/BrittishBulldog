using System;
using UnityEngine;

[Serializable]
public class Game : MonoBehaviour {
    public State currentState;
    public GameView view;

    void OnEnable() {
        view.UpdateView(currentState);
    }
}
