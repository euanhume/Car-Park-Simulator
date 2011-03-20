<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInterface
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FullSignBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EntryBarrierBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ExitBarrierBox = New System.Windows.Forms.TextBox()
        Me.CarArrivesButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SpacesBox = New System.Windows.Forms.TextBox()
        Me.PressforCoinButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EnterCarParkButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CarExitButton = New System.Windows.Forms.Button()
        Me.EnterCoinButton = New System.Windows.Forms.Button()
        Me.ExitCarParkButton = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CoinMachineBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AvailableCoinBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A Car Park Simulator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Full Sign"
        '
        'FullSignBox
        '
        Me.FullSignBox.Location = New System.Drawing.Point(47, 143)
        Me.FullSignBox.Name = "FullSignBox"
        Me.FullSignBox.Size = New System.Drawing.Size(100, 20)
        Me.FullSignBox.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(191, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Entry Barrier"
        '
        'EntryBarrierBox
        '
        Me.EntryBarrierBox.Location = New System.Drawing.Point(194, 143)
        Me.EntryBarrierBox.Name = "EntryBarrierBox"
        Me.EntryBarrierBox.Size = New System.Drawing.Size(147, 20)
        Me.EntryBarrierBox.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(353, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Exit Barrier"
        '
        'ExitBarrierBox
        '
        Me.ExitBarrierBox.Location = New System.Drawing.Point(356, 143)
        Me.ExitBarrierBox.Name = "ExitBarrierBox"
        Me.ExitBarrierBox.Size = New System.Drawing.Size(149, 20)
        Me.ExitBarrierBox.TabIndex = 7
        '
        'CarArrivesButton
        '
        Me.CarArrivesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarArrivesButton.Location = New System.Drawing.Point(47, 291)
        Me.CarArrivesButton.Name = "CarArrivesButton"
        Me.CarArrivesButton.Size = New System.Drawing.Size(127, 45)
        Me.CarArrivesButton.TabIndex = 12
        Me.CarArrivesButton.Text = "Car Arrives at Car Park"
        Me.CarArrivesButton.UseVisualStyleBackColor = True
        Me.CarArrivesButton.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(518, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(218, 18)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Number of available Spaces"
        '
        'SpacesBox
        '
        Me.SpacesBox.Location = New System.Drawing.Point(521, 143)
        Me.SpacesBox.Name = "SpacesBox"
        Me.SpacesBox.Size = New System.Drawing.Size(98, 20)
        Me.SpacesBox.TabIndex = 15
        '
        'PressforCoinButton
        '
        Me.PressforCoinButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressforCoinButton.Location = New System.Drawing.Point(47, 347)
        Me.PressforCoinButton.Name = "PressforCoinButton"
        Me.PressforCoinButton.Size = New System.Drawing.Size(127, 38)
        Me.PressforCoinButton.TabIndex = 16
        Me.PressforCoinButton.Text = "Press for Coin"
        Me.PressforCoinButton.UseVisualStyleBackColor = True
        Me.PressforCoinButton.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 18)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Car Arrival Simulation"
        '
        'EnterCarParkButton
        '
        Me.EnterCarParkButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterCarParkButton.Location = New System.Drawing.Point(47, 404)
        Me.EnterCarParkButton.Name = "EnterCarParkButton"
        Me.EnterCarParkButton.Size = New System.Drawing.Size(127, 49)
        Me.EnterCarParkButton.TabIndex = 18
        Me.EnterCarParkButton.Text = "Enter Car Park"
        Me.EnterCarParkButton.UseVisualStyleBackColor = True
        Me.EnterCarParkButton.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(353, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 18)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Car Exit Simulation"
        '
        'CarExitButton
        '
        Me.CarExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarExitButton.Location = New System.Drawing.Point(356, 291)
        Me.CarExitButton.Name = "CarExitButton"
        Me.CarExitButton.Size = New System.Drawing.Size(113, 45)
        Me.CarExitButton.TabIndex = 20
        Me.CarExitButton.Text = "Car Arrives at Exit"
        Me.CarExitButton.UseVisualStyleBackColor = True
        Me.CarExitButton.Visible = False
        '
        'EnterCoinButton
        '
        Me.EnterCoinButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterCoinButton.Location = New System.Drawing.Point(356, 347)
        Me.EnterCoinButton.Name = "EnterCoinButton"
        Me.EnterCoinButton.Size = New System.Drawing.Size(113, 38)
        Me.EnterCoinButton.TabIndex = 21
        Me.EnterCoinButton.Text = "Enter Coin"
        Me.EnterCoinButton.UseVisualStyleBackColor = True
        Me.EnterCoinButton.Visible = False
        '
        'ExitCarParkButton
        '
        Me.ExitCarParkButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitCarParkButton.Location = New System.Drawing.Point(356, 404)
        Me.ExitCarParkButton.Name = "ExitCarParkButton"
        Me.ExitCarParkButton.Size = New System.Drawing.Size(113, 49)
        Me.ExitCarParkButton.TabIndex = 22
        Me.ExitCarParkButton.Text = "Exit Car Park"
        Me.ExitCarParkButton.UseVisualStyleBackColor = True
        Me.ExitCarParkButton.Visible = False
        '
        'StartButton
        '
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.Location = New System.Drawing.Point(254, 199)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 29)
        Me.StartButton.TabIndex = 23
        Me.StartButton.Text = "START"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(795, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 18)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Coin Machine"
        '
        'CoinMachineBox
        '
        Me.CoinMachineBox.Location = New System.Drawing.Point(799, 144)
        Me.CoinMachineBox.Name = "CoinMachineBox"
        Me.CoinMachineBox.Size = New System.Drawing.Size(149, 20)
        Me.CoinMachineBox.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(808, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 18)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Available Coins"
        '
        'AvailableCoinBox
        '
        Me.AvailableCoinBox.Location = New System.Drawing.Point(810, 250)
        Me.AvailableCoinBox.Name = "AvailableCoinBox"
        Me.AvailableCoinBox.Size = New System.Drawing.Size(100, 20)
        Me.AvailableCoinBox.TabIndex = 27
        '
        'UserInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 485)
        Me.Controls.Add(Me.AvailableCoinBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CoinMachineBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.ExitCarParkButton)
        Me.Controls.Add(Me.EnterCoinButton)
        Me.Controls.Add(Me.CarExitButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.EnterCarParkButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PressforCoinButton)
        Me.Controls.Add(Me.SpacesBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CarArrivesButton)
        Me.Controls.Add(Me.ExitBarrierBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EntryBarrierBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FullSignBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UserInterface"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FullSignBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EntryBarrierBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ExitBarrierBox As System.Windows.Forms.TextBox
    Friend WithEvents CarArrivesButton As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SpacesBox As System.Windows.Forms.TextBox
    Friend WithEvents PressforCoinButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EnterCarParkButton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CarExitButton As System.Windows.Forms.Button
    Friend WithEvents EnterCoinButton As System.Windows.Forms.Button
    Friend WithEvents ExitCarParkButton As System.Windows.Forms.Button
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CoinMachineBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents AvailableCoinBox As System.Windows.Forms.TextBox

End Class
