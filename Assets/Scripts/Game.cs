using System;
using System.Linq;
using UnityEngine;

[Serializable]
public class Game : MonoBehaviour {
    public State currentState;
    public GameView view;

    void OnEnable() {
        view.UpdateView(currentState);
    }
}
