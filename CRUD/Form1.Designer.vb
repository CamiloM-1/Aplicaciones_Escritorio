<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtCodigo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDescrip = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCost = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCant = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtObs = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCrear = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnModificar = New Guna.UI2.WinForms.Guna2Button()
        Me.txtBuscar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GridDatosInv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.txtVenta = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.GridDatosInv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderRadius = 5
        Me.txtCodigo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigo.DefaultText = ""
        Me.txtCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodigo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(35, 53)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigo.PlaceholderText = "Código"
        Me.txtCodigo.SelectedText = ""
        Me.txtCodigo.Size = New System.Drawing.Size(385, 50)
        Me.txtCodigo.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.BorderRadius = 5
        Me.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombre.DefaultText = ""
        Me.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(35, 111)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.PlaceholderText = "Nombre"
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.Size = New System.Drawing.Size(385, 50)
        Me.txtNombre.TabIndex = 1
        '
        'txtDescrip
        '
        Me.txtDescrip.BorderRadius = 5
        Me.txtDescrip.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescrip.DefaultText = ""
        Me.txtDescrip.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescrip.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescrip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescrip.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescrip.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescrip.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtDescrip.ForeColor = System.Drawing.Color.Black
        Me.txtDescrip.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescrip.Location = New System.Drawing.Point(35, 169)
        Me.txtDescrip.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescrip.PlaceholderText = "Descripcion"
        Me.txtDescrip.SelectedText = ""
        Me.txtDescrip.Size = New System.Drawing.Size(385, 50)
        Me.txtDescrip.TabIndex = 2
        '
        'txtCost
        '
        Me.txtCost.BorderRadius = 5
        Me.txtCost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCost.DefaultText = ""
        Me.txtCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCost.ForeColor = System.Drawing.Color.Black
        Me.txtCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCost.Location = New System.Drawing.Point(35, 227)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCost.PlaceholderText = "Costo"
        Me.txtCost.SelectedText = ""
        Me.txtCost.Size = New System.Drawing.Size(385, 50)
        Me.txtCost.TabIndex = 3
        '
        'txtCant
        '
        Me.txtCant.BorderRadius = 5
        Me.txtCant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCant.DefaultText = ""
        Me.txtCant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCant.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCant.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCant.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCant.ForeColor = System.Drawing.Color.Black
        Me.txtCant.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCant.Location = New System.Drawing.Point(35, 345)
        Me.txtCant.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCant.PlaceholderText = "Cantidad"
        Me.txtCant.SelectedText = ""
        Me.txtCant.Size = New System.Drawing.Size(385, 50)
        Me.txtCant.TabIndex = 4
        '
        'txtObs
        '
        Me.txtObs.BorderRadius = 5
        Me.txtObs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtObs.DefaultText = ""
        Me.txtObs.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtObs.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtObs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtObs.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtObs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtObs.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtObs.ForeColor = System.Drawing.Color.Black
        Me.txtObs.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtObs.Location = New System.Drawing.Point(35, 403)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObs.PlaceholderText = "Observación"
        Me.txtObs.SelectedText = ""
        Me.txtObs.Size = New System.Drawing.Size(385, 50)
        Me.txtObs.TabIndex = 5
        '
        'btnNuevo
        '
        Me.btnNuevo.BorderRadius = 5
        Me.btnNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(35, 473)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(180, 45)
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnCrear
        '
        Me.btnCrear.BorderRadius = 5
        Me.btnCrear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCrear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCrear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCrear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCrear.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(240, 537)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(180, 45)
        Me.btnCrear.TabIndex = 7
        Me.btnCrear.Text = "Crear"
        '
        'btnGuardar
        '
        Me.btnGuardar.BorderRadius = 5
        Me.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(240, 473)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(180, 45)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guargar"
        '
        'btnModificar
        '
        Me.btnModificar.BorderRadius = 5
        Me.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(35, 537)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(180, 45)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "Modificar"
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderRadius = 5
        Me.txtBuscar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuscar.DefaultText = ""
        Me.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtBuscar.ForeColor = System.Drawing.Color.Black
        Me.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscar.Location = New System.Drawing.Point(1013, 53)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscar.PlaceholderText = "Buscar"
        Me.txtBuscar.SelectedText = ""
        Me.txtBuscar.Size = New System.Drawing.Size(247, 50)
        Me.txtBuscar.TabIndex = 13
        '
        'GridDatosInv
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.GridDatosInv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridDatosInv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridDatosInv.BackgroundColor = System.Drawing.Color.White
        Me.GridDatosInv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridDatosInv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GridDatosInv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridDatosInv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridDatosInv.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridDatosInv.DefaultCellStyle = DataGridViewCellStyle3
        Me.GridDatosInv.EnableHeadersVisualStyles = False
        Me.GridDatosInv.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridDatosInv.Location = New System.Drawing.Point(452, 111)
        Me.GridDatosInv.Name = "GridDatosInv"
        Me.GridDatosInv.RowHeadersVisible = False
        Me.GridDatosInv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridDatosInv.Size = New System.Drawing.Size(808, 471)
        Me.GridDatosInv.TabIndex = 12
        Me.GridDatosInv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GridDatosInv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GridDatosInv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GridDatosInv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GridDatosInv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GridDatosInv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GridDatosInv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridDatosInv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridDatosInv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridDatosInv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GridDatosInv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GridDatosInv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GridDatosInv.ThemeStyle.HeaderStyle.Height = 4
        Me.GridDatosInv.ThemeStyle.ReadOnly = False
        Me.GridDatosInv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GridDatosInv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GridDatosInv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GridDatosInv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GridDatosInv.ThemeStyle.RowsStyle.Height = 22
        Me.GridDatosInv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridDatosInv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'txtVenta
        '
        Me.txtVenta.BorderRadius = 5
        Me.txtVenta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVenta.DefaultText = ""
        Me.txtVenta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVenta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVenta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVenta.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtVenta.ForeColor = System.Drawing.Color.Black
        Me.txtVenta.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVenta.Location = New System.Drawing.Point(35, 285)
        Me.txtVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVenta.Name = "txtVenta"
        Me.txtVenta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVenta.PlaceholderText = "Venta"
        Me.txtVenta.SelectedText = ""
        Me.txtVenta.Size = New System.Drawing.Size(385, 50)
        Me.txtVenta.TabIndex = 14
        '
        'FormInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 650)
        Me.Controls.Add(Me.txtVenta)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.GridDatosInv)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.txtCant)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtDescrip)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCodigo)
        Me.Name = "FormInventario"
        Me.Text = "Inventario"
        CType(Me.GridDatosInv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtCodigo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDescrip As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCost As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCant As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtObs As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCrear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnModificar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtBuscar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GridDatosInv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtVenta As Guna.UI2.WinForms.Guna2TextBox
End Class
