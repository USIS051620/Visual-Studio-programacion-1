﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblntabla = New System.Windows.Forms.Label()
        Me.txtntabla = New System.Windows.Forms.TextBox()
        Me.lstTablas = New System.Windows.Forms.ListBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblntabla
        '
        Me.lblntabla.AutoSize = True
        Me.lblntabla.Location = New System.Drawing.Point(71, 127)
        Me.lblntabla.Name = "lblntabla"
        Me.lblntabla.Size = New System.Drawing.Size(37, 13)
        Me.lblntabla.TabIndex = 0
        Me.lblntabla.Text = "Tabla:"
        '
        'txtntabla
        '
        Me.txtntabla.Location = New System.Drawing.Point(125, 127)
        Me.txtntabla.Name = "txtntabla"
        Me.txtntabla.Size = New System.Drawing.Size(84, 20)
        Me.txtntabla.TabIndex = 1
        '
        'lstTablas
        '
        Me.lstTablas.FormattingEnabled = True
        Me.lstTablas.Location = New System.Drawing.Point(233, 67)
        Me.lstTablas.Name = "lstTablas"
        Me.lstTablas.Size = New System.Drawing.Size(317, 147)
        Me.lstTablas.TabIndex = 2
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(74, 169)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(135, 45)
        Me.btnProcesar.TabIndex = 3
        Me.btnProcesar.Text = "Generar Tabla"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 321)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.lstTablas)
        Me.Controls.Add(Me.txtntabla)
        Me.Controls.Add(Me.lblntabla)
        Me.Name = "Form1"
        Me.Text = "Tablas de Multiplicar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblntabla As Label
    Friend WithEvents txtntabla As TextBox
    Friend WithEvents lstTablas As ListBox
    Friend WithEvents btnProcesar As Button
End Class