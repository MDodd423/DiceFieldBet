Public Class Form1

    Dim RolledNumber As Integer
    Dim Num2, Num3, Num4, Num5, Num6, Num7, Num8, Num9, Num10, Num11, Num12 As Integer
    Dim NotFieldNumber, SingleField, DoubleField, TripleField, TotalFieldRolls, TotalRolls As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim NumberofRolls As Integer

        TotalRolls = TotalRolls + TextBox1.Text

        For NumberofRolls = 1 To TextBox1.Text

            RolledNumber = Int((Rnd() * 6) + 1) + Int((Rnd() * 6) + 1)

            If RolledNumber = 2 Then
                Num2 = Num2 + 1
                DoubleField = DoubleField + 1
            End If
            If RolledNumber = 3 Then Num3 = Num3 + 1
            If RolledNumber = 4 Then Num4 = Num4 + 1
            If RolledNumber = 5 Then Num5 = Num5 + 1
            If RolledNumber = 6 Then Num6 = Num6 + 1
            If RolledNumber = 7 Then Num7 = Num7 + 1
            If RolledNumber = 8 Then Num8 = Num8 + 1
            If RolledNumber = 9 Then Num9 = Num9 + 1
            If RolledNumber = 10 Then Num10 = Num10 + 1
            If RolledNumber = 11 Then Num11 = Num11 + 1
            If RolledNumber = 12 Then
                Num12 = Num12 + 1
                TripleField = TripleField + 1
            End If

            If RolledNumber = 5 Or RolledNumber = 6 Or RolledNumber = 7 Or RolledNumber = 8 Then NotFieldNumber = NotFieldNumber + 1
            If RolledNumber = 3 Or RolledNumber = 4 Or RolledNumber = 9 Or RolledNumber = 10 Or RolledNumber = 11 Then SingleField = SingleField + 1


            TotalFieldRolls = SingleField + (DoubleField * 2) + (TripleField * 3)

            Label2.Text = Num2
            Label3.Text = Num3
            Label4.Text = Num4
            Label5.Text = Num5
            Label6.Text = Num6
            Label7.Text = Num7
            Label8.Text = Num8
            Label9.Text = Num9
            Label10.Text = Num10
            Label11.Text = Num11
            Label12.Text = Num12

            Label29.Text = NotFieldNumber
            Label30.Text = SingleField
            Label31.Text = DoubleField
            Label32.Text = TripleField
            Label34.Text = TotalFieldRolls
            Label36.Text = TotalFieldRolls - NotFieldNumber
            Label37.Text = TotalRolls

        Next NumberofRolls
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Num2 = 0
        Num3 = 0
        Num4 = 0
        Num5 = 0
        Num6 = 0
        Num7 = 0
        Num8 = 0
        Num9 = 0
        Num10 = 0
        Num11 = 0
        Num12 = 0

        NotFieldNumber = 0
        SingleField = 0
        DoubleField = 0
        TripleField = 0
        TotalFieldRolls = 0
        TotalRolls = 0

        Label2.Text = Num2
        Label3.Text = Num3
        Label4.Text = Num4
        Label5.Text = Num5
        Label6.Text = Num6
        Label7.Text = Num7
        Label8.Text = Num8
        Label9.Text = Num9
        Label10.Text = Num10
        Label11.Text = Num11
        Label12.Text = Num12

        Label29.Text = NotFieldNumber
        Label30.Text = SingleField
        Label31.Text = DoubleField
        Label32.Text = TripleField
        Label34.Text = TotalFieldRolls
        Label36.Text = TotalFieldRolls - NotFieldNumber
        Label37.Text = TotalRolls

    End Sub

End Class
