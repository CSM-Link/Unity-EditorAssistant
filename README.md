# Unity-EditorAssistant
custom non-destructive/invasive unity editor tools



提供如下主动功能：

- Tools/Toggle Domain and Scene Reloading，启停进入 Play Mode 时进行的 Reloading 步骤。



提供如下被动功能：

- 如果 Preferences -- Asset Pipeline 中，关闭了 Auto Refresh，在进入 PlayMode 时会自动触发一次 `AssetDatabase.Refresh()`