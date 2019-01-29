<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Registrar_Caso_De_Uso
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnRegistrarCasoDeUso = New System.Windows.Forms.Button()
        Me.LblUpdateText = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btn_Volver = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(735, 85)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Medium", 24.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(200, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registrar casos de uso"
        '
        'Txt_Codigo
        '
        Me.Txt_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Txt_Codigo.Location = New System.Drawing.Point(150, 170)
        Me.Txt_Codigo.Multiline = True
        Me.Txt_Codigo.Name = "Txt_Codigo"
        Me.Txt_Codigo.Size = New System.Drawing.Size(154, 27)
        Me.Txt_Codigo.TabIndex = 1
        '
        'Txt_Descripcion
        '
        Me.Txt_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Txt_Descripcion.Location = New System.Drawing.Point(150, 270)
        Me.Txt_Descripcion.Multiline = True
        Me.Txt_Descripcion.Name = "Txt_Descripcion"
        Me.Txt_Descripcion.Size = New System.Drawing.Size(434, 60)
        Me.Txt_Descripcion.TabIndex = 2
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Txt_Nombre.Location = New System.Drawing.Point(430, 170)
        Me.Txt_Nombre.Multiline = True
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(154, 27)
        Me.Txt_Nombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto Medium", 13.0!)
        Me.Label2.Location = New System.Drawing.Point(146, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Código"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto Medium", 13.0!)
        Me.Label3.Location = New System.Drawing.Point(426, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto Medium", 13.0!)
        Me.Label4.Location = New System.Drawing.Point(146, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descripción"
        '
        'BtnRegistrarCasoDeUso
        '
        Me.BtnRegistrarCasoDeUso.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnRegistrarCasoDeUso.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnRegistrarCasoDeUso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnRegistrarCasoDeUso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.BtnRegistrarCasoDeUso.Location = New System.Drawing.Point(300, 360)
        Me.BtnRegistrarCasoDeUso.Name = "BtnRegistrarCasoDeUso"
        Me.BtnRegistrarCasoDeUso.Size = New System.Drawing.Size(109, 39)
        Me.BtnRegistrarCasoDeUso.TabIndex = 7
        Me.BtnRegistrarCasoDeUso.Text = "Registrar"
        Me.BtnRegistrarCasoDeUso.UseVisualStyleBackColor = False
        '
        'LblUpdateText
        '
        Me.LblUpdateText.AutoSize = True
        Me.LblUpdateText.ForeColor = System.Drawing.Color.Red
        Me.LblUpdateText.Location = New System.Drawing.Point(339, 135)
        Me.LblUpdateText.Name = "LblUpdateText"
        Me.LblUpdateText.Size = New System.Drawing.Size(0, 13)
        Me.LblUpdateText.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(145, 351)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(439, 3)
        Me.Panel3.TabIndex = 14
        '
        'Btn_Volver
        '
        Me.Btn_Volver.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Btn_Volver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Btn_Volver.Location = New System.Drawing.Point(12, 360)
        Me.Btn_Volver.Name = "Btn_Volver"
        Me.Btn_Volver.Size = New System.Drawing.Size(109, 39)
        Me.Btn_Volver.TabIndex = 15
        Me.Btn_Volver.Text = "Volver"
        Me.Btn_Volver.UseVisualStyleBackColor = False
        '
        'Frm_Registrar_Caso_De_Uso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 411)
        Me.Controls.Add(Me.Btn_Volver)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.LblUpdateText)
        Me.Controls.Add(Me.BtnRegistrarCasoDeUso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_Nombre)
        Me.Controls.Add(Me.Txt_Descripcion)
        Me.Controls.Add(Me.Txt_Codigo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Registrar_Caso_De_Uso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Codigo As TextBox
    Friend WithEvents Txt_Descripcion As TextBox
    Friend WithEvents Txt_Nombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnRegistrarCasoDeUso As Button
    Friend WithEvents LblUpdateText As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btn_Volver As Button
End Class
