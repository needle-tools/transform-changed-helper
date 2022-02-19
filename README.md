# TransformChanged helper

Ever wanted to listen on [transform.hasChanged](https://docs.unity3d.com/ScriptReference/Transform-hasChanged.html)?   
But no one is responsible for setting to false again so using it is a gamble?  

Well search no more: this package handles transform.hasChanged for you and you can just subscribe to an event ⚡ to get a notification.

---
## Usage

Just subscribe to the transform of your choice by using the extension method:

```csharp
this.transform.OnHasChanged(this.MyTransformChangedCallbackMethod);
```

That's it.