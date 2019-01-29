<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Registrar_Requerimiento
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
        Me.Txt_Proyecto = New System.Windows.Forms.TextBox()
        Me.Txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnRegistrarReq = New System.Windows.Forms.Button()
        Me.LblUpdateText = New System.Windows.Forms.Label()
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.CheckBox_Urgencia = New System.Windows.Forms.CheckBox()
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(200, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registrar requerimiento"
        '
        'Txt_Proyecto
        '
        Me.Txt_Proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Txt_Proyecto.Location = New System.Drawing.Point(150, 170)
        Me.Txt_Proyecto.Multiline = True
        Me.Txt_Proyecto.Name = "Txt_Proyecto"
        Me.Txt_Proyecto.Size = New System.Drawing.Size(481, 27)
        Me.Txt_Proyecto.TabIndex = 1
        '
        'Txt_Descripcion
        '
        Me.Txt_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Txt_Descripcion.Location = New System.Drawing.Point(150, 236)
        Me.Txt_Descripcion.Multiline = True
        Me.Txt_Descripcion.Name = "Txt_Descripcion"
        Me.Txt_Descripcion.Size = New System.Drawing.Size(481, 60)
        Me.Txt_Descripcion.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label2.Location = New System.Drawing.Point(146, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Proyecto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label4.Location = New System.Drawing.Point(146, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descripción"
        '
        'BtnRegistrarReq
        '
        Me.BtnRegistrarReq.BackColor = System.Drawing.Color.White
        Me.BtnRegistrarReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrarReq.Location = New System.Drawing.Point(342, 346)
        Me.BtnRegistrarReq.Name = "BtnRegistrarReq"
        Me.BtnRegistrarReq.Size = New System.Drawing.Size(109, 39)
        Me.BtnRegistrarReq.TabIndex = 7
        Me.BtnRegistrarReq.Text = "Registrar"
        Me.BtnRegistrarReq.UseVisualStyleBackColor = False
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
        'LabelMensaje
        '
        Me.LabelMensaje.AutoSize = True
        Me.LabelMensaje.Location = New System.Drawing.Point(561, 389)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LabelMensaje.TabIndex = 10
        '
        'CheckBox_Urgencia
        '
        Me.CheckBox_Urgencia.AutoSize = True
        Me.CheckBox_Urgencia.Location = New System.Drawing.Point(150, 305)
        Me.CheckBox_Urgencia.Name = "CheckBox_Urgencia"
        Me.CheckBox_Urgencia.Size = New System.Drawing.Size(64, 17)
        Me.CheckBox_Urgencia.TabIndex = 13
        Me.CheckBox_Urgencia.Text = "Urgente"
        Me.CheckBox_Urgencia.UseVisualStyleBackColor = True
        '
        'Frm_Registrar_Requerimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(734, 411)
        Me.Controls.Add(Me.CheckBox_Urgencia)
        Me.Controls.Add(Me.LabelMensaje)
        Me.Controls.Add(Me.LblUpdateText)
        Me.Controls.Add(Me.BtnRegistrarReq)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_Descripcion)
        Me.Controls.Add(Me.Txt_Proyecto)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Registrar_Requerimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Proyecto As TextBox
    Friend WithEvents Txt_Descripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnRegistrarReq As Button
    Friend WithEvents LblUpdateText As Label
    Friend WithEvents LabelMensaje As Label
    Friend WithEvents CheckBox_Urgencia As CheckBox
End Class
