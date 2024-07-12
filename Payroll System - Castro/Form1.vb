Public Class Form1
    'i didn't use tab control, instead I only used buttons for the tabs
    Function calculateDeduction(ByVal tax As Double, ByVal gsis As Double, ByVal sss As Double, ByVal phil As Double) As Double
        Dim g As Double
        g = tax + gsis + sss + phil
        Return g
    End Function

    Function calculateGrossSalary(ByVal rph As Double, ByVal hpd As Double, ByVal dw As Double) As Double
        Dim g As Double
        g = rph * hpd * dw
        Return g
    End Function

    Function calculateNetSalary(ByVal td As Double, ByVal gs As Double) As Double
        Dim g As Double
        g = gs - td
        Return g
    End Function
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub btn_okay_Click(sender As Object, e As EventArgs) Handles btn_okay.Click
        fullname.Text = fName.Text & " " & mInitial.Text & ". " & lName.Text
        td.Text = calculateDeduction(tax.Text, gsis.Text, sss.Text, phil.Text)

        gs.Text = calculateGrossSalary(rph.Text, hpd.Text, dw.Text)
        ns.Text = calculateNetSalary(td.Text, gs.Text)

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        'clear all
        fName.Text = ""
        mInitial.Text = ""
        lName.Text = ""

        rph.Text = ""
        hpd.Text = ""
        dw.Text = ""

        tax.Text = ""
        gsis.Text = ""
        sss.Text = ""
        phil.Text = ""

        fullname.Text = ""
        gs.Text = ""
        td.Text = ""
        ns.Text = ""


    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub PayRollTab_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub fullname_TextChanged(sender As Object, e As EventArgs) Handles fullname.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub ns_TextChanged(sender As Object, e As EventArgs) Handles ns.TextChanged

    End Sub

    Private Sub td_TextChanged(sender As Object, e As EventArgs) Handles td.TextChanged

    End Sub

    Private Sub gs_TextChanged(sender As Object, e As EventArgs) Handles gs.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub fName_TextChanged(sender As Object, e As EventArgs) Handles fName.TextChanged

    End Sub

    Private Sub mInitial_TextChanged(sender As Object, e As EventArgs) Handles mInitial.TextChanged

    End Sub

    Private Sub lName_TextChanged(sender As Object, e As EventArgs) Handles lName.TextChanged

    End Sub

    Private Sub rph_TextChanged(sender As Object, e As EventArgs) Handles rph.TextChanged

    End Sub

    Private Sub hpd_TextChanged(sender As Object, e As EventArgs) Handles hpd.TextChanged

    End Sub

    Private Sub dw_TextChanged(sender As Object, e As EventArgs) Handles dw.TextChanged

    End Sub

    Private Sub tax_TextChanged(sender As Object, e As EventArgs) Handles tax.TextChanged

    End Sub

    Private Sub gsis_TextChanged(sender As Object, e As EventArgs) Handles gsis.TextChanged

    End Sub

    Private Sub sss_TextChanged(sender As Object, e As EventArgs) Handles sss.TextChanged

    End Sub

    Private Sub phil_TextChanged(sender As Object, e As EventArgs) Handles phil.TextChanged

    End Sub

    Private Sub HomeTab_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AboutTab_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Kto12Tab_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ResourcesTab_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProcurementTab_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ContactTab_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RegionsTab_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub
End Class
