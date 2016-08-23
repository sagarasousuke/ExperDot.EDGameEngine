﻿Imports System.Numerics
Imports EDGameEngine
''' <summary>
''' 初始化、更新可视化对象空间
''' </summary>
Public Class CustomWorld
    Inherits World
    Public Sub New(aw#, ah#)
        MyBase.New(aw, ah)
    End Sub
    Dim gho
    Public Overrides Sub CreateObject()

        Dim rect As New Rect(60, 40, 20, 20)
        Dim rectModel As New VisualRectangle(rect)
        MyScene.AddGameVisual(rectModel, New RectangleView(rectModel))
        rectModel.Effectors.Add(New LightEffector())


        'Dim tempModel As New ParticalFollow()
        'MyScene.AddGameVisual(tempModel, New ParticalView(tempModel))
        'tempModel.Effectors.Add(New LightEffector())

        'Dim tempModel2 As New Plant(New Vector2(MyScene.Width / 2, MyScene.Height * 0.8))
        'MyScene.AddGameVisual(tempModel2, New PlantView(tempModel2))
        'tempModel2.Effectors.Add(New LightEffector())

        'Dim tempModel3 As New AutoDrawModel() With {.Image = MyScene.ImageManager.GetResource(ImageResourceID.Scenery1)}
        'MyScene.AddGameVisual(tempModel3, New AutoDrawView(tempModel3))
    End Sub
End Class
