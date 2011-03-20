Public Class UserInterface

    Public aPark As Park
    Public anEntryBarrier As EntryBarrier
    Public anExitBarrier As ExitBarrier
    Public aFullSign As FullSign
    Public aCoinMachine As CoinMachine

    Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click

        aPark = New Park(SpacesBox)
        anEntryBarrier = New EntryBarrier(aPark, EntryBarrierBox)
        anExitBarrier = New ExitBarrier(aPark, ExitBarrierBox)
        aFullSign = New FullSign(FullSignBox)
        aCoinMachine = New CoinMachine(AvailableCoinBox)

        CarArrivesButton.Visible = True
        PressforCoinButton.Visible = False
        EnterCarParkButton.Visible = False
        CarExitButton.Visible = False
        EnterCoinButton.Visible = False
        ExitCarParkButton.Visible = False
    End Sub

    Private Sub CarArrivesAtCarParkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarArrivesButton.Click
        CarArrivesButton.Visible = False
        aCoinMachine.carArrives(CoinMachineBox)
        PressforCoinButton.Visible = True
    End Sub

    Private Sub PressforCoinButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PressforCoinButton.Click
        PressforCoinButton.Visible = False
        aCoinMachine.pressCoin(CoinMachineBox, AvailableCoinBox)
        anEntryBarrier.raise(EntryBarrierBox)
        EnterCarParkButton.Visible = True
    End Sub

    Private Sub EnterCarParkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnterCarParkButton.Click
        anEntryBarrier.lower(EntryBarrierBox, aPark, SpacesBox)
        EnterCarParkButton.Visible = False
        If aPark.isFull = True Then
            CarArrivesButton.Visible = False
            aFullSign.changeState(FullSignBox)
        Else
            CarArrivesButton.Visible = True
        End If
        CarExitButton.Visible = True
    End Sub

    Private Sub CarArrivesAtExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarExitButton.Click
        CarExitButton.Visible = False
        aCoinMachine.carExits(CoinMachineBox)
        EnterCoinButton.Visible = True
    End Sub

    Private Sub EnterCoinButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnterCoinButton.Click
        EnterCoinButton.Visible = False
        aCoinMachine.enterCoin(CoinMachineBox, AvailableCoinBox)
        anExitBarrier.raise(ExitBarrierBox)
        ExitCarParkButton.Visible = True
    End Sub

    Private Sub ExitCarParkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitCarParkButton.Click
        If aPark.isAvailable = False Then
            aFullSign.changeState(FullSignBox)
        End If
        anExitBarrier.lower(ExitBarrierBox, aPark, SpacesBox)
        ExitCarParkButton.Visible = False
        If SpacesBox.Text = aPark.totalSpace Then
            CarExitButton.Visible = False
        Else
            CarExitButton.Visible = True
        End If
        CarArrivesButton.Visible = True
    End Sub

    Private Sub UserInterface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class