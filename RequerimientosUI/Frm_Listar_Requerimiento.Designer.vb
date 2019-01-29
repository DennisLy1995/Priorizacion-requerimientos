<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Listar_Requerimiento
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridRequerimientos = New System.Windows.Forms.DataGridView()
        Me.BtnAgregarRequerimiento = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txt_Buscar = New System.Windows.Forms.TextBox()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.BtnVisualizarRequerimientos = New System.Windows.Forms.Button()
        Me.LblUpdate = New System.Windows.Forms.Label()
        CType(Me.DataGridRequerimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(26, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Requerimientos"
        '
        'DataGridRequerimientos
        '
        Me.DataGridRequerimientos.AllowUserToAddRows = False
        Me.DataGridRequerimientos.AllowUserToDeleteRows = False
        Me.DataGridRequerimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridRequerimientos.Location = New System.Drawing.Point(33, 104)
        Me.DataGridRequerimientos.Name = "DataGridRequerimientos"
        Me.DataGridRequerimientos.ReadOnly = True
        Me.DataGridRequerimientos.Size = New System.Drawing.Size(509, 234)
        Me.DataGridRequerimientos.TabIndex = 1
        '
        'BtnAgregarRequerimiento
        '
        Me.BtnAgregarRequerimiento.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnAgregarRequerimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.BtnAgregarRequerimiento.Location = New System.Drawing.Point(271, 38)
        Me.BtnAgregarRequerimiento.Name = "BtnAgregarRequerimiento"
        Me.BtnAgregarRequerimiento.Size = New System.Drawing.Size(118, 31)
        Me.BtnAgregarRequerimiento.TabIndex = 2
        Me.BtnAgregarRequerimiento.Text = "+ Agregar"
        Me.BtnAgregarRequerimiento.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(570, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(164, 411)
        Me.Panel1.TabIndex = 3
        '
        'Txt_Buscar
        '
        Me.Txt_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Txt_Buscar.Location = New System.Drawing.Point(245, 361)
        Me.Txt_Buscar.Multiline = True
        Me.Txt_Buscar.Name = "Txt_Buscar"
        Me.Txt_Buscar.Size = New System.Drawing.Size(154, 27)
        Me.Txt_Buscar.TabIndex = 5
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Btn_Buscar.Location = New System.Drawing.Point(424, 361)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(118, 27)
        Me.Btn_Buscar.TabIndex = 6
        Me.Btn_Buscar.Text = "Buscar"
        Me.Btn_Buscar.UseVisualStyleBackColor = True
        '
        'BtnVisualizarRequerimientos
        '
        Me.BtnVisualizarRequerimientos.Enabled = False
        Me.BtnVisualizarRequerimientos.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnVisualizarRequerimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.BtnVisualizarRequerimientos.Location = New System.Drawing.Point(33, 357)
        Me.BtnVisualizarRequerimientos.Name = "BtnVisualizarRequerimientos"
        Me.BtnVisualizarRequerimientos.Size = New System.Drawing.Size(101, 31)
        Me.BtnVisualizarRequerimientos.TabIndex = 4
        Me.BtnVisualizarRequerimientos.Text = "Abrir"
        Me.BtnVisualizarRequerimientos.UseVisualStyleBackColor = True
        '
        'LblUpdate
        '
        Me.LblUpdate.AutoSize = True
        Me.LblUpdate.Location = New System.Drawing.Point(253, 88)
        Me.LblUpdate.Name = "LblUpdate"
        Me.LblUpdate.Size = New System.Drawing.Size(62, 13)
        Me.LblUpdate.TabIndex = 7
        Me.LblUpdate.Text = "Cargando..."
        '
        'Frm_Listar_Casos_De_Uso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(734, 411)
        Me.Controls.Add(Me.LblUpdate)
        Me.Controls.Add(Me.Btn_Buscar)
        Me.Controls.Add(Me.Txt_Buscar)
        Me.Controls.Add(Me.BtnVisualizarRequerimientos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnAgregarRequerimiento)
        Me.Controls.Add(Me.DataGridRequerimientos)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Listar_Casos_De_Uso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Listar_Casos_De_Uso"
        CType(Me.DataGridRequerimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridRequerimientos As DataGridView
    Friend WithEvents BtnAgregarRequerimiento As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Txt_Buscar As TextBox
    Friend WithEvents Btn_Buscar As Button
    Friend WithEvents BtnVisualizarRequerimientos As Button
    Friend WithEvents LblUpdate As Label
End Class
