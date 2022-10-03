Public Class NumbersGrid
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        If (DataGrid.Rows.Count > 4) Then
            addBtn.Enabled = False
        Else
            asignar()
        End If
        sumarColum()
        sumarFilas()
    End Sub



    Public Sub asignar()
        Dim numCol As Integer = 0
        Dim v(2) As String
        Dim valor(2) As Integer

        For i = 0 To 2 Step 1
            numCol += 1
            v(i) = InputBox("Introduce el valor de la columna " & numCol & " a sumar:", "Valores", "")
            validar(v, valor, i)
        Next
        DataGrid.Rows.Add(valor(0), valor(1), valor(2))
    End Sub

    Function validar(ByRef text() As String, ByRef value() As Integer, ByRef pos As Integer)
        If (text(pos)) Like "*[a-zA-Z]*" Then
            text(pos) = InputBox("Introduce valores numéricos solamente: ", "Valores", "")
            value(pos) = Integer.Parse(text(pos))
        ElseIf (String.IsNullOrEmpty(text(pos))) Then
            text(pos) = 0
            value(pos) = Integer.Parse(text(pos))
        ElseIf (String.IsNullOrWhiteSpace(text(pos))) Then
            text(pos) = 0
        Else
            value(pos) = Integer.Parse(text(pos))
        End If

        If (IsNumeric(value(pos))) Then
            If value(pos) < 0 Then
                value(pos) = InputBox("Introduzca valores mayores a cero solamente: ", "Advertencia", "")
            End If
        Else
            value(pos) = InputBox("Solo se aceptan números, ingrese uno por favor:", "Inténtalo denuevo", "")
        End If
    End Function

    Public Sub sumarColum()
        For i = 0 To DataGrid.Rows.Count - 1
            Dim sumatoria As Integer = 0
            For j = 0 To DataGrid.Columns.Count - 1
                sumatoria += DataGrid.Rows(i).Cells(j).Value
                If (i = 0) Then
                    r1.Text = sumatoria
                ElseIf (i = 1) Then
                    r2.Text = sumatoria
                ElseIf (i = 2) Then
                    r3.Text = sumatoria
                ElseIf (i = 3) Then
                    r4.Text = sumatoria
                Else
                    r5.Text = sumatoria
                End If
            Next
        Next
    End Sub

    Public Sub sumarFilas()
        For i = 0 To DataGrid.Columns.Count - 1
            Dim sumatoria As Integer = 0
            For j = 0 To DataGrid.Rows.Count - 1
                sumatoria += DataGrid.Rows(j).Cells(i).Value
            Next
            If (i = 0) Then
                c1.Text = sumatoria
            ElseIf (i = 1) Then
                c2.Text = sumatoria
            Else
                c3.Text = sumatoria
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        sumarFilas()
        sumarColum()
    End Sub
End Class