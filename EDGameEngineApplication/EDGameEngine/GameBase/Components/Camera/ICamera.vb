﻿Imports System.Numerics
''' <summary>
''' 场景摄像机接口
''' </summary>
Public Interface ICamera
    Property Position As Vector2
    Sub Start()
    Sub Update()
End Interface
