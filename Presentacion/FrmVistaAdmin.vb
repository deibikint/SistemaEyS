﻿Public Class FrmVistaAdmin
    Private Sub AñadirEntidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirEntidadToolStripMenuItem.Click
    End Sub

    Dim currentTime As Date = TimeOfDay


    Private Sub FrmVistaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDSistemaEySDataSet.tbl_Empleado' Puede moverla o quitarla según sea necesario.
        Me.Tbl_EmpleadoTableAdapter.Fill(Me.BDSistemaEySDataSet.tbl_Empleado)
        Me.Label1.Text = currentTime.ToLongTimeString

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ParámetrosGeneralesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParámetrosGeneralesToolStripMenuItem.Click
        frmParametrosGen.Show()
    End Sub

    Private Sub DepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentoToolStripMenuItem.Click
        FrmAddDepartamento.Show()
    End Sub

    Private Sub CargoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargoToolStripMenuItem.Click
        FrmAddCargo.Show()
    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
        FrmAddEmpleado.Show()
    End Sub

    Private Sub DepartamentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DepartamentoToolStripMenuItem1.Click
        frmListarDept.Show()
    End Sub

    Private Sub CargoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargoToolStripMenuItem1.Click
        frmListarCargo.Show()
    End Sub

    Private Sub EmpleadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem1.Click
        frmListarEmp.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        MessageBox.Show("Seguro que desea cerrar la sesión?", "Confirmación", MessageBoxButtons.YesNoCancel)
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class