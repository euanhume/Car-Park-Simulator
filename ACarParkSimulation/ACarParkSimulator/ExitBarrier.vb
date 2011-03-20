Public Class ExitBarrier

    Private carPark As Park

    Public Sub New()

    End Sub

    Public Sub New(ByRef aCarPark As Park, ByRef ExitBarrierBox As TextBox)
        carPark = aCarPark
        ExitBarrierBox.Text = "DOWN"
    End Sub

    Public Sub raise(ByRef display As TextBox)
        display.Text = "UP"
    End Sub

    Public Sub lower(ByRef ExitBarrierBox As TextBox, ByRef aCarPark As Park, ByRef spacesbox As TextBox)
        carPark.increment(spacesbox)
        aCarPark = carPark
        ExitBarrierBox.Text = "DOWN"
    End Sub
End Class
