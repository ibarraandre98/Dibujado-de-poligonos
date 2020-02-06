Imports System.IO

Public Class Form1
    Dim arr As List(Of Puntos) = New List(Of Puntos)
    Dim zoom As Integer = 10

    Private Sub panelpintar_Paint(sender As Object, e As PaintEventArgs) Handles panelpintar.Paint
        Dim g As Graphics
        g = e.Graphics
        cuadricula(g)

    End Sub

    Private Sub cuadricula(ByVal g)
        Dim penGray As Pen = New Pen(Color.Gray)

        Dim w As Integer = panelpintar.Width
        Dim w2 As Integer = panelpintar.Width / 2 'y

        Dim h As Integer = panelpintar.Height
        Dim h2 As Integer = panelpintar.Height / 2 'x

        Dim penRed As Pen = New Pen(Color.Red, 3)



        For index = 0 To w2 - 1 Step zoom
            g.DrawLine(penGray, w2 - index, 0, w2 - index, h)
            g.DrawLine(penGray, w2 + index, 0, w2 + index, h)

        Next

        For index = 0 To h2 - 1 Step zoom
            g.DrawLine(penGray, 0, h2 - index, w, h2 - index)
            g.DrawLine(penGray, 0, h2 + index, w, h2 + index)
        Next

        g.DrawLine(penRed, 0, h2, w, h2)
        g.DrawLine(penRed, w2, 0, w2, h)


    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim nombrearchivo As String
        OPF.Filter = "Text File | *.txt"
        If OPF.ShowDialog Then
            nombrearchivo = OPF.FileName
        End If
        Dim objReader As New StreamReader(nombrearchivo)
        Dim vec As New ArrayList
        Dim linea As String = ""

        Do
            linea = objReader.ReadLine
            If Not linea Is Nothing Then
                vec.Add(linea)
            End If
        Loop Until linea Is Nothing
        objReader.Close()



        For Each linea In vec
            Dim separador() As String
            separador = linea.Split(" ")
            arr.Add(New Puntos(Convert.ToInt32(separador(0) * zoom), Convert.ToInt32(separador(1) * zoom), Convert.ToInt32(separador(2))))
        Next


        Dim hash As HashSet(Of Integer) = New HashSet(Of Integer)
        For Each item In arr
            hash.Add(item.setgetpol)
        Next

        Dim g As Graphics
        g = panelpintar.CreateGraphics()

        Dim points As New List(Of Point)
        For Each item In hash
            points.Clear()

            For Each item1 In arr
                If (item1.setgetpol = item) Then
                    points.Add(New Point((panelpintar.Width / 2) + item1.setgetx, (panelpintar.Height / 2) - item1.setgety))
                End If
            Next
            For index = 0 To points.Count - 1
                'MessageBox.Show(points.Count)
                'MessageBox.Show(index)
                If (index = points.Count - 1) Then
                    g.DrawLine(Pens.Black, points(index), points(0))
                    'MessageBox.Show("primer: " & points(index).X & " " & points(index).Y)
                Else
                    g.DrawLine(Pens.Black, points(index), points(index + 1))
                    'MessageBox.Show("segundo: " & points(index).X & " " & points(index).Y)
                End If

            Next
        Next



    End Sub
End Class
