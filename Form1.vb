Public Class Form1
    'Muuttujien määrittely
    Dim ekaNum As Decimal
    Dim tokaNum As Decimal
    Dim operaattori As Integer
    Dim laskutoimitus As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Jos teksti ei ole "0", lisätään perään numero(string) "1". Jos teksti on "0", korvataan se numerolla(string) "1"
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "1"
        Else
            TextBox1.Text = "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "2"
        Else
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "3"
        Else
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "4"
        Else
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "5"
        Else
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "6"
        Else
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "7"
        Else
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "8"
        Else
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "9"
        Else
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Jos teksti ei ole pelkkä numero(string) "0", lisätään "0"
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "0"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Not TextBox1.Text.Contains(",") Then ' Jos tekstissä ei ole "," lisätään se.
            TextBox1.Text += ","
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        'CE-näppäin. Korvataan teksti numerolla(string) "0"
        TextBox1.Text = "0"
        ekaNum = 0
        tokaNum = 0
        laskutoimitus = False
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If laskutoimitus Then Return 'Estetään useamman operaattorin painaminen peräkkäin
        ekaNum = Decimal.Parse(TextBox1.Text) 'Muuttujaan ekaNum tallennetaan muuttujan TextBox1 teksti(string) desimaalina(decimal)
        operaattori = 1  'Jakolaskun operaattori
        TextBox1.Text = "0" ' Muutetaan näytettävä teksti numero(string) "0"
        laskutoimitus = True 'Laskutoimitus suoritetaan, kun painetaan summa painiketta
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If laskutoimitus Then Return
        ekaNum = Decimal.Parse(TextBox1.Text)
        operaattori = 2  'Kertoaskun operaattori
        TextBox1.Text = "0"
        laskutoimitus = True
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If laskutoimitus Then Return
        ekaNum = Decimal.Parse(TextBox1.Text)
        operaattori = 3  'Vähennyslaskun operaattori
        TextBox1.Text = "0"
        laskutoimitus = True
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If laskutoimitus Then Return
        ekaNum = Decimal.Parse(TextBox1.Text)
        operaattori = 4  'Yhteenlaskun operaattori
        TextBox1.Text = "0"
        laskutoimitus = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If laskutoimitus = True Then 'Summa-painike. Suoritetaan laskutoimitus, jos ehto on tosi tallennetaan luku toiseen muuttujaan laskemista varten
            tokaNum = Decimal.Parse(TextBox1.Text) 'Tallennetaan luku toiseen muuttujaan laskemista varten
            If operaattori = 1 And tokaNum <> 0 Then 'Jos operaattori on 1 ja tokaNum ei ole 0, suoritetaan jakolasku
                TextBox1.Text = ekaNum / tokaNum ' Jakolasku
            ElseIf operaattori = 2 And tokaNum <> 0 Then
                TextBox1.Text = ekaNum * tokaNum ' Kertolasku
            ElseIf operaattori = 3 And tokaNum <> 0 Then
                TextBox1.Text = ekaNum - tokaNum 'Vähennyslasku
            Else
                TextBox1.Text = ekaNum + tokaNum 'Yhteenlasku
            End If
        End If

        ekaNum = Decimal.Parse(TextBox1.Text) 'Muutetaan desimaaliksi
        laskutoimitus = False ' Muutetaan muuttujan laskutoimitus arvo takaisin False
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        MessageBox.Show("Laskin" + Environment.NewLine +
               "Versio: " + Application.ProductVersion + Environment.NewLine +
               "Ohjelman tekijä: Aki Lahtinen GitHub: aki-lahtinen" + Environment.NewLine +
               "© 2025" + Environment.NewLine + Environment.NewLine +
               "Ohjelmaa saa käyttää ja jakaa vapaasti." + Environment.NewLine +
               "Tekijä ei vastaa mahdollisista vahingoista." + Environment.NewLine + Environment.NewLine +
               "Ohjelman ikoni on ladattu osoitteesta: www.flaticon.com",
               "Tietoja",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information)
    End Sub
End Class

