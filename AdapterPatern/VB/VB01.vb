﻿Public Class VB01
    Implements IVBSeries

    Private Function IVBSeries_GetValue() As Integer Implements IVBSeries.GetValue
        Return 3000
    End Function
End Class
