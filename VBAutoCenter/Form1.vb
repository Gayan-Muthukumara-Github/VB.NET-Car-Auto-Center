Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim title As String
        title = "Exit"
        Dim message As String
        Dim frm As New Form1

        'Message Box with title, yes no and cancel Butttons  
        MsgBox("Do you really want to exit?", 3, "Exit")
        ' Assume that you press yes Button  
        Me.Close()







    End Sub

    Private Sub PurchaseAVehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseAVehicleToolStripMenuItem.Click
        Dim frm2 As New Form2
        Dim frm1 As New Form1
        Me.Hide()
        frm2.Show()





    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim frm3 As New Form3
        Me.Hide()
        frm3.Show()

    End Sub
End Class
