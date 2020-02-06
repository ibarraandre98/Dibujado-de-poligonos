<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panelpintar = New System.Windows.Forms.PictureBox()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.OPF = New System.Windows.Forms.OpenFileDialog()
        CType(Me.panelpintar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelpintar
        '
        Me.panelpintar.BackColor = System.Drawing.Color.White
        Me.panelpintar.Location = New System.Drawing.Point(1, 1)
        Me.panelpintar.Name = "panelpintar"
        Me.panelpintar.Size = New System.Drawing.Size(900, 400)
        Me.panelpintar.TabIndex = 0
        Me.panelpintar.TabStop = False
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(418, 422)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 1
        Me.btnOpen.Text = "Cargar"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'OPF
        '
        Me.OPF.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 476)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.panelpintar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.panelpintar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelpintar As PictureBox
    Friend WithEvents btnOpen As Button
    Friend WithEvents OPF As OpenFileDialog
End Class
