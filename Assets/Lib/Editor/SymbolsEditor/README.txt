[TODO]
- Add icon on custom window.

- Add link to website of explaining "Scriptiong define symbol" on custom window.
https://docs.unity3d.com/Manual/PlatformDependentCompilation.html

[FIXME]
- Error when you open the window first time.

NullReferenceException: Object reference not set to an instance of an object
MyLib.Editor.SymbolsEditor.SymbolsEditor.GetModelSymbolsList () (at Assets/Lib/Editor/SymbolsEditor/SymbolsEditor.cs:66)
MyLib.Editor.SymbolsEditor.SymbolsEditor.SyncWithPlayerSettings () (at Assets/Lib/Editor/SymbolsEditor/SymbolsEditor.cs:87)
MyLib.Editor.SymbolsEditor.SymbolsEditor..ctor () (at Assets/Lib/Editor/SymbolsEditor/SymbolsEditor.cs:48)
MyLib.Editor.SymbolsEditor.SymbolsEditorWindow.OnEnable () (at Assets/Lib/Editor/SymbolsEditor/SymbolsEditorWindow.cs:23)
UnityEditor.EditorWindow:GetWindow(Type, Boolean, String)
MyLib.Editor.SymbolsEditor.SymbolsEditor:Open() (at Assets/Lib/Editor/SymbolsEditor/SymbolsEditor.cs:54)

- Error when you open the window first time.
NullReferenceException: Object reference not set to an instance of an object
MyLib.Editor.SymbolsEditor.SymbolsEditorWindow.InitList () (at Assets/Lib/Editor/SymbolsEditor/SymbolsEditorWindow.cs:47)
MyLib.Editor.SymbolsEditor.SymbolsEditorWindow.DrawList () (at Assets/Lib/Editor/SymbolsEditor/SymbolsEditorWindow.cs:56)
MyLib.Editor.SymbolsEditor.SymbolsEditorWindow.OnGUI () (at Assets/Lib/Editor/SymbolsEditor/SymbolsEditorWindow.cs:32)
System.Reflection.MonoMethod.Invoke (System.Object obj, BindingFlags invokeAttr, System.Reflection.Binder binder, System.Object[] parameters, System.Globalization.CultureInfo culture) (at /Users/builduser/buildslave/mono/build/mcs/class/corlib/System.Reflection/MonoMethod.cs:222)
Rethrow as TargetInvocationException: Exception has been thrown by the target of an invocation.
System.Reflection.MonoMethod.Invoke (System.Object obj, BindingFlags invokeAttr, System.Reflection.Binder binder, System.Object[] parameters, System.Globalization.CultureInfo culture) (at /Users/builduser/buildslave/mono/build/mcs/class/corlib/System.Reflection/MonoMethod.cs:232)
System.Reflection.MethodBase.Invoke (System.Object obj, System.Object[] parameters) (at /Users/builduser/buildslave/mono/build/mcs/class/corlib/System.Reflection/MethodBase.cs:115)
UnityEditor.HostView.Invoke (System.String methodName, System.Object obj) (at C:/buildslave/unity/build/Editor/Mono/HostView.cs:285)
UnityEditor.HostView.Invoke (System.String methodName) (at C:/buildslave/unity/build/Editor/Mono/HostView.cs:278)
UnityEditor.HostView.InvokeOnGUI (Rect onGUIPosition) (at C:/buildslave/unity/build/Editor/Mono/HostView.cs:245)
UnityEngine.GUIUtility:ProcessEvent(Int32, IntPtr)

- SymbolEditor.cs
/*
 * FIXME : Use automatic refarence.
 * This still has a rick when user changed directionary structure.
 */

- SymbolEditor.cs
/*
 * QESTION : I don't know "Resources" directory is best in this case.
 * Maybe I don't have to use "Resources" to load this scriptable object.
 */