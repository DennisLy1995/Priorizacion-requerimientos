<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_priorizar_requerimientos
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
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxInteresados = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonCalcularHoja = New System.Windows.Forms.Button()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.ButtonSeleccionar = New System.Windows.Forms.Button()
        Me.TextBoxProyecto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelMensaje
        '
        Me.LabelMensaje.AutoSize = True
        Me.LabelMensaje.Location = New System.Drawing.Point(-8, 374)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LabelMensaje.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(549, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(164, 411)
        Me.Panel1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(40, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Priorizacion de Requerimientos"
        '
        'TextBoxInteresados
        '
        Me.TextBoxInteresados.Enabled = False
        Me.TextBoxInteresados.Location = New System.Drawing.Point(37, 196)
        Me.TextBoxInteresados.MaxLength = 9
        Me.TextBoxInteresados.Name = "TextBoxInteresados"
        Me.TextBoxInteresados.Size = New System.Drawing.Size(198, 20)
        Me.TextBoxInteresados.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Cant Interesados"
        '
        'ButtonCalcularHoja
        '
        Me.ButtonCalcularHoja.Enabled = False
        Me.ButtonCalcularHoja.Location = New System.Drawing.Point(339, 139)
        Me.ButtonCalcularHoja.Name = "ButtonCalcularHoja"
        Me.ButtonCalcularHoja.Size = New System.Drawing.Size(109, 39)
        Me.ButtonCalcularHoja.TabIndex = 22
        Me.ButtonCalcularHoja.Text = "Crear Hoja"
        Me.ButtonCalcularHoja.UseVisualStyleBackColor = True
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Enabled = False
        Me.ButtonGuardar.Location = New System.Drawing.Point(339, 184)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(109, 39)
        Me.ButtonGuardar.TabIndex = 23
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'ButtonSeleccionar
        '
        Me.ButtonSeleccionar.Location = New System.Drawing.Point(339, 94)
        Me.ButtonSeleccionar.Name = "ButtonSeleccionar"
        Me.ButtonSeleccionar.Size = New System.Drawing.Size(109, 39)
        Me.ButtonSeleccionar.TabIndex = 24
        Me.ButtonSeleccionar.Text = "Seleccionar"
        Me.ButtonSeleccionar.UseVisualStyleBackColor = True
        '
        'TextBoxProyecto
        '
        Me.TextBoxProyecto.Location = New System.Drawing.Point(35, 122)
        Me.TextBoxProyecto.Name = "TextBoxProyecto"
        Me.TextBoxProyecto.Size = New System.Drawing.Size(198, 20)
        Me.TextBoxProyecto.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "ID Proyecto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 25)
        Me.Label4.TabIndex = 27
        '
        'Frm_priorizar_requerimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 372)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxProyecto)
        Me.Controls.Add(Me.ButtonSeleccionar)
        Me.Controls.Add(Me.ButtonGuardar)
        Me.Controls.Add(Me.ButtonCalcularHoja)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxInteresados)
        Me.Controls.Add(Me.LabelMensaje)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_priorizar_requerimientos"
        Me.Text = "Frm_priorizar_requerimientos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelMensaje As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxInteresados As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonCalcularHoja As Button
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents ButtonSeleccionar As Button
    Friend WithEvents TextBoxProyecto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
