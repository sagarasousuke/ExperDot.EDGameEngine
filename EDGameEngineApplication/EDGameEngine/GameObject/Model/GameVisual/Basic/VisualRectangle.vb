﻿Imports System.Numerics
''' <summary>
''' 基础几何图元,矩形
''' </summary>
Public Class VisualRectangle
    Inherits GameVisual
    Public Property Rect As Rect
    Public Sub New(rect As Rect)
        Me.Rect = rect
    End Sub
    Public Overrides Sub StartEx()
    End Sub
    Public Overrides Sub UpdateEx()
    End Sub
End Class
