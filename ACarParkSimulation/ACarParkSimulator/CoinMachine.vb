Public Class CoinMachine

    Private noOfCoins As Integer = 10000

    Public Sub New()

    End Sub

    Public Sub New(ByRef AvailableCoinBox As TextBox)
        AvailableCoinBox.Text = noOfCoins
    End Sub

    Private Sub decrement()
        noOfCoins = noOfCoins - 1
    End Sub

    Private Sub increment()
        noOfCoins = noOfCoins + 1
    End Sub

    Private Function getNoOfCoins() As Integer
        Return noOfCoins
    End Function

    Public Sub enterCoin(ByRef CoinMachineBox As TextBox, ByRef AvailableCoinBox As TextBox)
        CoinMachineBox.Text = ""
        increment()
        AvailableCoinBox.Text = noOfCoins
    End Sub

    Public Sub carArrives(ByRef CoinMachineBox As TextBox)
        CoinMachineBox.Text = "Please Press For Coin"
    End Sub

    Public Sub carExits(ByRef CoinMachineBox As TextBox)
        CoinMachineBox.Text = "Please Insert Your Coin"
    End Sub

    Public Sub pressCoin(ByRef CoinMachineBox As TextBox, ByRef AvailableCoinBox As TextBox)
        CoinMachineBox.Text = ""
        decrement()
        AvailableCoinBox.Text = noOfCoins
    End Sub

End Class
