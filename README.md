# Nintendo Joycon Patch
The repository is custom tool that can help developer pair Nintendo joy-con easily. If you would like to use this tool, selecting latest version at tag.
## How to use this tool
* Import `Tool.unitypackage` to your unity project, and your unity must support .NET Framework 3.5. You can set `Scripting Runtime Version` to change .NET version in configuration of playersettings.
<p align="left">
<img style="margin:auto;"  src="https://github.com/destiny5420/NintendoJoyconPatch/blob/develop/ReadMeSource/ToolUnityPackage.png">
</p>
<br>

* You can seet that `InputSetting` and `Plugin` folder appear in the project.
<p align="left">
<img style="margin:auto;"  src="https://github.com/destiny5420/NintendoJoyconPatch/blob/develop/ReadMeSource/Import_Unity_Package.png">
</p>
<br>

* Open Project Settings panel in the edit menu and select Input option. Then left click in preset button on upper right corner.
<p align="left">
<img style="margin:auto;"  src="https://github.com/destiny5420/NintendoJoyconPatch/blob/develop/ReadMeSource/Preset.png">
</p>
<br>

* Select `NintendoInputManagerAssets`, Input axes will become a custom setting for up to 4 player.
<p align="left">
<img style="margin:auto;"  src="https://github.com/destiny5420/NintendoJoyconPatch/blob/develop/ReadMeSource/Seletc_NintendoInputManagerAssets.png">
</p>
<br>

## NintendoJoyconManager
`class in PaperGmaeStudio.Controller`

<br>

* First, you must use `NintendoJoyconManager.Init()` in scripts to initialize the nintendojoycon manager. NintendoJoyconManager will automatically generate on the scene.
```C#
using UnityEngine;
using PaperGmaeStudio.Controller;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        NintendoJoyconManager.Init();
    }
}
```
<p align="left">
<img style="margin:auto;"  src="https://github.com/destiny5420/NintendoJoyconPatch/blob/develop/ReadMeSource/NintendoJoyconManagerInit.png">
</p>

<br>

* You need to register callback with manager if you want to capture the button event.
```C#
using UnityEngine;
using PaperGmaeStudio.Controller;

public class DemoScript : MonoBehaviour
{
    void Start()
    {
        NintendoJoyconManager.Init();
        NintendoJoyconManager.RegistCallback(NintendoJoyconManager.NINTENDO_KEY_TYPE.Player01_A, OnClick_A_01);
    }

    void OnClick_A_01(float v_value)
    {
        Debug.Log("OnClick_A_01 / value: " + v_value);
    }
}
```
<br>

## NINTENDO_KEY_TYPE
This tool have support for the following button events.

<p align="left">
<img style="margin:auto;"  src="https://github.com/destiny5420/NintendoJoyconPatch/blob/develop/ReadMeSource/NintendoJoyconRef.png">
</p>
