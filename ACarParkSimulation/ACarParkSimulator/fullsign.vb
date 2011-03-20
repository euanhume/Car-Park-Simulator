Public Class FullSign

    Private state As Boolean

    Public Sub New()

    End Sub

    Public Sub New(ByVal FullSignBox As TextBox)
        state = False
        FullSignBox.Text = "OFF"
    End Sub

    Public Function getState() As Boolean
        Return state
    End Function

    Public Sub changeState(ByVal FullSignBox As TextBox)
        If state = False Then
            state = True
            FullSignBox.Text = "ON"
        ElseIf state = True Then
            state = False
            FullSignBox.Text = "OFF"
        End If
    End Sub
End Class
