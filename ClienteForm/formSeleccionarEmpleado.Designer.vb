<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSeleccionarEmpleado
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvRegionTerritorios = New System.Windows.Forms.DataGridView()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.cmbFiltro = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEmpleadoEmployeeID = New System.Windows.Forms.Label()
        Me.lblEmpleadoLastName = New System.Windows.Forms.Label()
        Me.lblEmpleadoFirstName = New System.Windows.Forms.Label()
        Me.lblEmpleadoTitle = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        CType(Me.dgvRegionTerritorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(420, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Region y Territorios:"
        '
        'dgvRegionTerritorios
        '
        Me.dgvRegionTerritorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegionTerritorios.Location = New System.Drawing.Point(423, 46)
        Me.dgvRegionTerritorios.Name = "dgvRegionTerritorios"
        Me.dgvRegionTerritorios.Size = New System.Drawing.Size(240, 150)
        Me.dgvRegionTerritorios.TabIndex = 14
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Location = New System.Drawing.Point(12, 46)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.Size = New System.Drawing.Size(405, 150)
        Me.dgvEmpleados.TabIndex = 13
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(283, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 12
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(177, 6)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltro.TabIndex = 11
        '
        'cmbFiltro
        '
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Location = New System.Drawing.Point(50, 6)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltro.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Empleados:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Filtro:"
        '
        'lblEmpleadoEmployeeID
        '
        Me.lblEmpleadoEmployeeID.AutoSize = True
        Me.lblEmpleadoEmployeeID.Location = New System.Drawing.Point(85, 199)
        Me.lblEmpleadoEmployeeID.Name = "lblEmpleadoEmployeeID"
        Me.lblEmpleadoEmployeeID.Size = New System.Drawing.Size(16, 13)
        Me.lblEmpleadoEmployeeID.TabIndex = 113
        Me.lblEmpleadoEmployeeID.Text = "..."
        '
        'lblEmpleadoLastName
        '
        Me.lblEmpleadoLastName.AutoSize = True
        Me.lblEmpleadoLastName.Location = New System.Drawing.Point(85, 225)
        Me.lblEmpleadoLastName.Name = "lblEmpleadoLastName"
        Me.lblEmpleadoLastName.Size = New System.Drawing.Size(16, 13)
        Me.lblEmpleadoLastName.TabIndex = 112
        Me.lblEmpleadoLastName.Text = "..."
        '
        'lblEmpleadoFirstName
        '
        Me.lblEmpleadoFirstName.AutoSize = True
        Me.lblEmpleadoFirstName.Location = New System.Drawing.Point(84, 251)
        Me.lblEmpleadoFirstName.Name = "lblEmpleadoFirstName"
        Me.lblEmpleadoFirstName.Size = New System.Drawing.Size(16, 13)
        Me.lblEmpleadoFirstName.TabIndex = 111
        Me.lblEmpleadoFirstName.Text = "..."
        '
        'lblEmpleadoTitle
        '
        Me.lblEmpleadoTitle.AutoSize = True
        Me.lblEmpleadoTitle.Location = New System.Drawing.Point(84, 277)
        Me.lblEmpleadoTitle.Name = "lblEmpleadoTitle"
        Me.lblEmpleadoTitle.Size = New System.Drawing.Size(16, 13)
        Me.lblEmpleadoTitle.TabIndex = 110
        Me.lblEmpleadoTitle.Text = "..."
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(48, 277)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(30, 13)
        Me.Label27.TabIndex = 109
        Me.Label27.Text = "Title:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(21, 251)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(57, 13)
        Me.Label28.TabIndex = 108
        Me.Label28.Text = "FirstName:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(21, 225)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(58, 13)
        Me.Label29.TabIndex = 107
        Me.Label29.Text = "LastName:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(12, 199)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(67, 13)
        Me.Label30.TabIndex = 106
        Me.Label30.Text = "EmployeeID:"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(342, 267)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccionar.TabIndex = 114
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'formSeleccionarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 306)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.lblEmpleadoEmployeeID)
        Me.Controls.Add(Me.lblEmpleadoLastName)
        Me.Controls.Add(Me.lblEmpleadoFirstName)
        Me.Controls.Add(Me.lblEmpleadoTitle)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvRegionTerritorios)
        Me.Controls.Add(Me.dgvEmpleados)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.cmbFiltro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formSeleccionarEmpleado"
        Me.Text = "Seleccionar Empleado"
        CType(Me.dgvRegionTerritorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents dgvRegionTerritorios As DataGridView
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents cmbFiltro As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEmpleadoEmployeeID As Label
    Friend WithEvents lblEmpleadoLastName As Label
    Friend WithEvents lblEmpleadoFirstName As Label
    Friend WithEvents lblEmpleadoTitle As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents btnSeleccionar As Button
End Class
