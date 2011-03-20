Public Class EntryBarrier

    Private carPark As Park

    Public Sub New()

    End Sub

    Public Sub New(ByRef aCarPark As Park, ByRef EntryBarrierBox As TextBox)
        carPark = aCarPark
        EntryBarrierBox.Text = "DOWN"
    End Sub

    Public Sub raise(ByRef display As TextBox)
        display.Text = "UP"
    End Sub

    Public Sub lower(ByRef EntryBarrierBox As TextBox, ByRef aCarPark As Park, ByRef spacesbox As TextBox)
        carPark.decrement(spacesbox)
        aCarPark = carPark
        EntryBarrierBox.Text = "DOWN"
    End Sub
End Class
