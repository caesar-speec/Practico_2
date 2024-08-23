<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        LNya = New Label()
        LDni = New Label()
        LNombre = New Label()
        LApellido = New Label()
        LModificar = New Label()
        BEliminar = New Button()
        BGuardar = New Button()
        TNombre = New TextBox()
        TApellido = New TextBox()
        TDni = New TextBox()
        SuspendLayout()
        ' 
        ' LNya
        ' 
        LNya.AutoSize = True
        LNya.Location = New Point(12, 21)
        LNya.Name = "LNya"
        LNya.Size = New Size(107, 15)
        LNya.TabIndex = 0
        LNya.Text = "Nombre y Apellido"
        ' 
        ' LDni
        ' 
        LDni.AutoSize = True
        LDni.Location = New Point(21, 139)
        LDni.Name = "LDni"
        LDni.Size = New Size(27, 15)
        LDni.TabIndex = 1
        LDni.Text = "DNI"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(12, 95)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(51, 15)
        LNombre.TabIndex = 2
        LNombre.Text = "Nombre"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(12, 176)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(51, 15)
        LApellido.TabIndex = 3
        LApellido.Text = "Apellido"
        ' 
        ' LModificar
        ' 
        LModificar.AutoSize = True
        LModificar.BackColor = SystemColors.Control
        LModificar.ForeColor = Color.Red
        LModificar.Location = New Point(125, 21)
        LModificar.Name = "LModificar"
        LModificar.Size = New Size(58, 15)
        LModificar.TabIndex = 4
        LModificar.Text = "modificar"
        ' 
        ' BEliminar
        ' 
        BEliminar.Location = New Point(147, 226)
        BEliminar.Name = "BEliminar"
        BEliminar.Size = New Size(75, 23)
        BEliminar.TabIndex = 5
        BEliminar.Text = "Eliminar"
        BEliminar.UseVisualStyleBackColor = True
        ' 
        ' BGuardar
        ' 
        BGuardar.Location = New Point(12, 226)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(75, 23)
        BGuardar.TabIndex = 6
        BGuardar.Text = "Guardar"
        BGuardar.UseVisualStyleBackColor = True
        ' 
        ' TNombre
        ' 
        TNombre.Location = New Point(83, 95)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(100, 23)
        TNombre.TabIndex = 7
        ' 
        ' TApellido
        ' 
        TApellido.Location = New Point(83, 173)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(100, 23)
        TApellido.TabIndex = 8
        ' 
        ' TDni
        ' 
        TDni.Location = New Point(83, 136)
        TDni.Name = "TDni"
        TDni.Size = New Size(100, 23)
        TDni.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(255, 261)
        Controls.Add(TDni)
        Controls.Add(TApellido)
        Controls.Add(TNombre)
        Controls.Add(BGuardar)
        Controls.Add(BEliminar)
        Controls.Add(LModificar)
        Controls.Add(LApellido)
        Controls.Add(LNombre)
        Controls.Add(LDni)
        Controls.Add(LNya)
        Name = "Form1"
        Text = "Pequeño Formulario"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LNya As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LModificar As Label
    Friend WithEvents BEliminar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TDni As TextBox

End Class
