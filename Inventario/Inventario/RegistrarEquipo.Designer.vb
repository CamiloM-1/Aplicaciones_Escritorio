<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarEquipo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarEquipo))
        Me.LblEquipo = New System.Windows.Forms.Label()
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.LblDocumento = New System.Windows.Forms.Label()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.LblDetalle = New System.Windows.Forms.Label()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblEquipo
        '
        Me.LblEquipo.AutoSize = True
        Me.LblEquipo.Location = New System.Drawing.Point(57, 94)
        Me.LblEquipo.Name = "LblEquipo"
        Me.LblEquipo.Size = New System.Drawing.Size(86, 13)
        Me.LblEquipo.TabIndex = 0
        Me.LblEquipo.Text = "Serial del Equipo"
        '
        'LblMarca
        '
        Me.LblMarca.AutoSize = True
        Me.LblMarca.Location = New System.Drawing.Point(57, 134)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(89, 13)
        Me.LblMarca.TabIndex = 1
        Me.LblMarca.Text = "Marca del equipo"
        '
        'LblDocumento
        '
        Me.LblDocumento.AutoSize = True
        Me.LblDocumento.Location = New System.Drawing.Point(57, 174)
        Me.LblDocumento.Name = "LblDocumento"
        Me.LblDocumento.Size = New System.Drawing.Size(129, 13)
        Me.LblDocumento.TabIndex = 2
        Me.LblDocumento.Text = "Documento de Odentidad"
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Location = New System.Drawing.Point(57, 58)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(78, 13)
        Me.LblTipo.TabIndex = 3
        Me.LblTipo.Text = "Tipo de equipo"
        '
        'LblDetalle
        '
        Me.LblDetalle.AutoSize = True
        Me.LblDetalle.Location = New System.Drawing.Point(57, 216)
        Me.LblDetalle.Name = "LblDetalle"
        Me.LblDetalle.Size = New System.Drawing.Size(45, 13)
        Me.LblDetalle.TabIndex = 4
        Me.LblDetalle.Text = "Detalles"
        '
        'txtSerial
        '
        Me.txtSerial.Location = New System.Drawing.Point(289, 87)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(182, 20)
        Me.txtSerial.TabIndex = 6
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(289, 127)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(182, 20)
        Me.txtMarca.TabIndex = 7
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(289, 167)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(182, 20)
        Me.txtDocumento.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Portatil", "Tablet", "Computador Mesa", "Otro"})
        Me.ComboBox1.Location = New System.Drawing.Point(289, 49)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'txtDetalle
        '
        Me.txtDetalle.Location = New System.Drawing.Point(289, 209)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(182, 20)
        Me.txtDetalle.TabIndex = 10
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackgroundImage = CType(resources.GetObject("btnRegistrar.BackgroundImage"), System.Drawing.Image)
        Me.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Location = New System.Drawing.Point(87, 302)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(59, 52)
        Me.btnRegistrar.TabIndex = 11
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.BackgroundImage = CType(resources.GetObject("btnBorrar.BackgroundImage"), System.Drawing.Image)
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Location = New System.Drawing.Point(298, 302)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(65, 52)
        Me.btnBorrar.TabIndex = 12
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Location = New System.Drawing.Point(490, 302)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(70, 52)
        Me.btnExit.TabIndex = 13
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'RegistrarEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(700, 489)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.LblDetalle)
        Me.Controls.Add(Me.LblTipo)
        Me.Controls.Add(Me.LblDocumento)
        Me.Controls.Add(Me.LblMarca)
        Me.Controls.Add(Me.LblEquipo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegistrarEquipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrarEquipo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblEquipo As Label
    Friend WithEvents LblMarca As Label
    Friend WithEvents LblDocumento As Label
    Friend WithEvents LblTipo As Label
    Friend WithEvents LblDetalle As Label
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnExit As Button
End Class
