﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Modificar_Proyecto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_modifcar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Txt_descripcion = New System.Windows.Forms.TextBox()
        Me.Txt_industria = New System.Windows.Forms.TextBox()
        Me.Txt_nombre = New System.Windows.Forms.TextBox()
        Me.Txt_idCliente = New System.Windows.Forms.TextBox()
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_volver = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(751, 85)
        Me.Panel1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(258, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modificar proyectos"
        '
        'Btn_modifcar
        '
        Me.Btn_modifcar.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_modifcar.ForeColor = System.Drawing.Color.Black
        Me.Btn_modifcar.Location = New System.Drawing.Point(387, 397)
        Me.Btn_modifcar.Name = "Btn_modifcar"
        Me.Btn_modifcar.Size = New System.Drawing.Size(123, 39)
        Me.Btn_modifcar.TabIndex = 27
        Me.Btn_modifcar.Text = "Modificar"
        Me.Btn_modifcar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(159, 386)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(449, 3)
        Me.Panel3.TabIndex = 26
        '
        'Txt_descripcion
        '
        Me.Txt_descripcion.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_descripcion.Location = New System.Drawing.Point(136, 286)
        Me.Txt_descripcion.Multiline = True
        Me.Txt_descripcion.Name = "Txt_descripcion"
        Me.Txt_descripcion.Size = New System.Drawing.Size(201, 83)
        Me.Txt_descripcion.TabIndex = 25
        '
        'Txt_industria
        '
        Me.Txt_industria.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_industria.Location = New System.Drawing.Point(407, 141)
        Me.Txt_industria.Name = "Txt_industria"
        Me.Txt_industria.Size = New System.Drawing.Size(154, 27)
        Me.Txt_industria.TabIndex = 24
        '
        'Txt_nombre
        '
        Me.Txt_nombre.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_nombre.Location = New System.Drawing.Point(139, 215)
        Me.Txt_nombre.Name = "Txt_nombre"
        Me.Txt_nombre.Size = New System.Drawing.Size(154, 27)
        Me.Txt_nombre.TabIndex = 23
        '
        'Txt_idCliente
        '
        Me.Txt_idCliente.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_idCliente.Location = New System.Drawing.Point(139, 141)
        Me.Txt_idCliente.Name = "Txt_idCliente"
        Me.Txt_idCliente.ReadOnly = True
        Me.Txt_idCliente.Size = New System.Drawing.Size(154, 27)
        Me.Txt_idCliente.TabIndex = 22
        '
        'Calendario
        '
        Me.Calendario.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calendario.Location = New System.Drawing.Point(407, 207)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.ShowTodayCircle = False
        Me.Calendario.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(448, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 19)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Fecha de finalización"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(135, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Descripción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(403, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Industria a la que pertenece"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(135, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 19)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Nombre del proyecto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(135, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Identificación del cliente"
        '
        'Btn_volver
        '
        Me.Btn_volver.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_volver.ForeColor = System.Drawing.Color.Black
        Me.Btn_volver.Location = New System.Drawing.Point(234, 397)
        Me.Btn_volver.Name = "Btn_volver"
        Me.Btn_volver.Size = New System.Drawing.Size(123, 39)
        Me.Btn_volver.TabIndex = 28
        Me.Btn_volver.Text = "Volver"
        Me.Btn_volver.UseVisualStyleBackColor = True
        '
        'Frm_Modificar_Proyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(750, 450)
        Me.Controls.Add(Me.Btn_volver)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btn_modifcar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Txt_descripcion)
        Me.Controls.Add(Me.Txt_industria)
        Me.Controls.Add(Me.Txt_nombre)
        Me.Controls.Add(Me.Txt_idCliente)
        Me.Controls.Add(Me.Calendario)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Modificar_Proyecto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Modificar_Proyecto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_modifcar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Txt_descripcion As TextBox
    Friend WithEvents Txt_industria As TextBox
    Friend WithEvents Txt_nombre As TextBox
    Friend WithEvents Txt_idCliente As TextBox
    Friend WithEvents Calendario As MonthCalendar
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_volver As Button
End Class
