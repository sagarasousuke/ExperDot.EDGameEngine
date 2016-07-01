﻿Imports System.Numerics
Imports Microsoft.Graphics.Canvas
''' <summary>
''' 图层
''' </summary>
Public Class Layer
    Inherits LayerBase
    Public Overrides Sub OnDraw(drawingSession As CanvasDrawingSession)
        Using cmdList = New CanvasCommandList(drawingSession.Device)
            Using Dl = cmdList.CreateDrawingSession
                For Each SubGameVisual In GameVisuals
                    SubGameVisual.Presenter.OnDraw(Dl)
                Next
            End Using
            drawingSession.DrawImage(Effector.Transform2D(cmdList, Transform))
        End Using
    End Sub
End Class
