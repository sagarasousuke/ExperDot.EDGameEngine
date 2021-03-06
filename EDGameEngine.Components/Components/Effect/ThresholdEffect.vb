﻿Imports EDGameEngine.Core
Imports Microsoft.Graphics.Canvas
Imports Windows.Graphics.Effects
Imports Windows.UI
''' <summary>
''' 二值化效果器
''' </summary>
Public Class ThresholdEffect
    Inherits EffectBase
    Public Property Split As Integer = 128
    Public Overrides Function Effect(source As IGraphicsEffectSource, DrawingSession As CanvasDrawingSession) As IGraphicsEffectSource
        Using bmp As CanvasBitmap = BitmapCacheHelper.CacheEntireImage(DrawingSession, CType(source, ICanvasImage))
            Dim RawColors() As Color = bmp.GetPixelColors
            Dim NowColors(RawColors.Count - 1) As Color
            For i = 0 To RawColors.Count - 1
                NowColors(i) = If(BitmapPixelHelper.GetColorAverage(RawColors(i)) < Split, Colors.Black, Color.FromArgb(0, 0, 0, 0))
            Next
            Return CanvasBitmap.CreateFromColors(DrawingSession, NowColors, CInt(bmp.Bounds.Width), CInt(bmp.Bounds.Height))
        End Using
    End Function
End Class
