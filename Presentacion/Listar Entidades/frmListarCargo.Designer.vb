﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarCargo
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblCantCarg = New System.Windows.Forms.Label()
        Me.btnSig = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.cbCargos = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbDept = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rtxtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCerrar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGuardar)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 192)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(380, 30)
        Me.FlowLayoutPanel1.TabIndex = 18
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(304, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(73, 23)
        Me.btnCerrar.TabIndex = 15
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(225, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(73, 23)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(146, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Administrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblCantCarg
        '
        Me.lblCantCarg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantCarg.Location = New System.Drawing.Point(238, 159)
        Me.lblCantCarg.Name = "lblCantCarg"
        Me.lblCantCarg.Size = New System.Drawing.Size(117, 24)
        Me.lblCantCarg.TabIndex = 10
        Me.lblCantCarg.Text = "999/999"
        Me.lblCantCarg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSig
        '
        Me.btnSig.Location = New System.Drawing.Point(369, 159)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSig.Size = New System.Drawing.Size(23, 25)
        Me.btnSig.TabIndex = 11
        Me.btnSig.Text = ">"
        Me.btnSig.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(209, 159)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAnterior.Size = New System.Drawing.Size(23, 25)
        Me.btnAnterior.TabIndex = 9
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'cbCargos
        '
        Me.cbCargos.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCargos.FormattingEnabled = True
        Me.cbCargos.Location = New System.Drawing.Point(17, 159)
        Me.cbCargos.Name = "cbCargos"
        Me.cbCargos.Size = New System.Drawing.Size(187, 27)
        Me.cbCargos.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 141)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listar cargos"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbDept, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.rtxtDescripcion, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbID, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbNombre, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 24)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(369, 108)
        Me.TableLayoutPanel1.TabIndex = 19
        '
        'lbDept
        '
        Me.lbDept.AutoSize = True
        Me.lbDept.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbDept.Location = New System.Drawing.Point(150, 48)
        Me.lbDept.Name = "lbDept"
        Me.lbDept.Size = New System.Drawing.Size(97, 15)
        Me.lbDept.TabIndex = 9
        Me.lbDept.Text = "Texto de ejemplo"
        Me.lbDept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(3, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Departamento:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rtxtDescripcion
        '
        Me.rtxtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.rtxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtxtDescripcion.Enabled = False
        Me.rtxtDescripcion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.rtxtDescripcion.Location = New System.Drawing.Point(150, 75)
        Me.rtxtDescripcion.Name = "rtxtDescripcion"
        Me.rtxtDescripcion.Size = New System.Drawing.Size(216, 30)
        Me.rtxtDescripcion.TabIndex = 7
        Me.rtxtDescripcion.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(3, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 15)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Descripción:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbID.Location = New System.Drawing.Point(150, 0)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(63, 15)
        Me.lbID.TabIndex = 1
        Me.lbID.Text = "XXXXXXXX"
        Me.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbNombre.Location = New System.Drawing.Point(150, 24)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(97, 15)
        Me.lbNombre.TabIndex = 3
        Me.lbNombre.Text = "Texto de ejemplo"
        Me.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombres:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmListarCargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 234)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.lblCantCarg)
        Me.Controls.Add(Me.btnSig)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.cbCargos)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmListarCargo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listar cargos"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblCantCarg As Label
    Friend WithEvents btnSig As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents cbCargos As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rtxtDescripcion As RichTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbDept As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class