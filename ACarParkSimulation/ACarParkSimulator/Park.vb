Public Class Park

    Private maxSpace As Integer = 5
    Private space As Integer = maxSpace

    Public Sub New()

    End Sub
    Public Sub New(ByRef spacesBox As TextBox)
        spacesBox.Text = maxSpace
    End Sub

    Public Sub increment(ByRef spacesBox As TextBox)
        space = space + 1
        spacesBox.Text = space
    End Sub

    Public Sub decrement(ByRef spacesBox As TextBox)
        space = space - 1
        spacesBox.Text = space
    End Sub

    Public Function totalSpace() As Integer
        Return maxSpace
    End Function

    Public Function availableSpace() As Integer
        availableSpace = maxSpace - space
    End Function

    Public Function isFull() As Boolean
        If space = 0 Then
            isFull = True
        Else
            isFull = False
        End If
    End Function

    Public Function isAvailable() As Boolean
        If space = 0 Then
            isAvailable = False
        Else
            isAvailable = True
        End If
        'If space = 0 Then
        '    isAvailable = True
        'Else
        '    isAvailable = False
        'End If
    End Function
End Class
