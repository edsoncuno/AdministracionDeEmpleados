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
        Me.dgvRegionTerritorios1 = New System.Windows.Forms.DataGridView()
        Me.dgvEmpleados1 = New System.Windows.Forms.DataGridView()
        Me.btnBuscar1 = New System.Windows.Forms.Button()
        Me.txtFiltro1 = New System.Windows.Forms.TextBox()
        Me.cmbFiltro1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEmpleadoEmployeeID1 = New System.Windows.Forms.Label()
        Me.lblEmpleadoLastName1 = New System.Windows.Forms.Label()
        Me.lblEmpleadoFirstName1 = New System.Windows.Forms.Label()
        Me.lblEmpleadoTitle1 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btnSeleccionar1 = New System.Windows.Forms.Button()
        CType(Me.dgvRegionTerritorios1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmpleados1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'dgvRegionTerritorios1
        '
        Me.dgvRegionTerritorios1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegionTerritorios1.Location = New System.Drawing.Point(423, 46)
        Me.dgvRegionTerritorios1.Name = "dgvRegionTerritorios1"
        Me.dgvRegionTerritorios1.Size = New System.Drawing.Size(240, 150)
        Me.dgvRegionTerritorios1.TabIndex = 14
        '
        'dgvEmpleados1
        '
        Me.dgvEmpleados1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados1.Location = New System.Drawing.Point(12, 46)
        Me.dgvEmpleados1.Name = "dgvEmpleados1"
        Me.dgvEmpleados1.Size = New System.Drawing.Size(405, 150)
        Me.dgvEmpleados1.TabIndex = 13
        '
        'btnBuscar1
        '
        Me.btnBuscar1.Location = New System.Drawing.Point(283, 4)
        Me.btnBuscar1.Name = "btnBuscar1"
        Me.btnBuscar1.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar1.TabIndex = 12
        Me.btnBuscar1.Text = "Buscar"
        Me.btnBuscar1.UseVisualStyleBackColor = True
        '
        'txtFiltro1
        '
        Me.txtFiltro1.Location = New System.Drawing.Point(177, 6)
        Me.txtFiltro1.Name = "txtFiltro1"
        Me.txtFiltro1.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltro1.TabIndex = 11
        '
        'cmbFiltro1
        '
        Me.cmbFiltro1.FormattingEnabled = True
        Me.cmbFiltro1.Location = New System.Drawing.Point(50, 6)
        Me.cmbFiltro1.Name = "cmbFiltro1"
        Me.cmbFiltro1.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltro1.TabIndex = 10
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
        'lblEmpleadoEmployeeID1
        '
        Me.lblEmpleadoEmployeeID1.AutoSize = True
        Me.lblEmpleadoEmployeeID1.Location = New System.Drawing.Point(85, 199)
        Me.lblEmpleadoEmployeeID1.Name = "lblEmpleadoEmployeeID1"
        Me.lblEmpleadoEmployeeID1.Size = New System.Drawing.Size(16, 13)
        Me.lblEmpleadoEmployeeID1.TabIndex = 113
        Me.lblEmpleadoEmployeeID1.Text = "..."
        '
        'lblEmpleadoLastName1
        '
        Me.lblEmpleadoLastName1.AutoSize = True
        Me.lblEmpleadoLastName1.Location = New System.Drawing.Point(85, 225)
        Me.lblEmpleadoLastName1.Name = "lblEmpleadoLastName1"
        Me.lblEmpleadoLastName1.Size = New System.Drawing.Size(16, 13)
        Me.lblEmpleadoLastName1.TabIndex = 112
        Me.lblEmpleadoLastName1.Text = "..."
        '
        'lblEmpleadoFirstName1
        '
        Me.lblEmpleadoFirstName1.AutoSize = True
        Me.lblEmpleadoFirstName1.Location = New System.Drawing.Point(84, 251)
        Me.lblEmpleadoFirstName1.Name = "lblEmpleadoFirstName1"
        Me.lblEmpleadoFirstName1.Size = New System.Drawing.Size(16, 13)
        Me.lblEmpleadoFirstName1.TabIndex = 111
        Me.lblEmpleadoFirstName1.Text = "..."
        '
        'lblEmpleadoTitle1
        '
        Me.lblEmpleadoTitle1.AutoSize = True
        Me.lblEmpleadoTitle1.Location = New System.Drawing.Point(84, 277)
        Me.lblEmpleadoTitle1.Name = "lblEmpleadoTitle1"
        Me.lblEmpleadoTitle1.Size = New System.Drawing.Size(16, 13)
        Me.lblEmpleadoTitle1.TabIndex = 110
        Me.lblEmpleadoTitle1.Text = "..."
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
        'btnSeleccionar1
        '
        Me.btnSeleccionar1.Location = New System.Drawing.Point(342, 267)
        Me.btnSeleccionar1.Name = "btnSeleccionar1"
        Me.btnSeleccionar1.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccionar1.TabIndex = 114
        Me.btnSeleccionar1.Text = "Seleccionar"
        Me.btnSeleccionar1.UseVisualStyleBackColor = True
        '
        'formSeleccionarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 306)
        Me.Controls.Add(Me.btnSeleccionar1)
        Me.Controls.Add(Me.lblEmpleadoEmployeeID1)
        Me.Controls.Add(Me.lblEmpleadoLastName1)
        Me.Controls.Add(Me.lblEmpleadoFirstName1)
        Me.Controls.Add(Me.lblEmpleadoTitle1)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvRegionTerritorios1)
        Me.Controls.Add(Me.dgvEmpleados1)
        Me.Controls.Add(Me.btnBuscar1)
        Me.Controls.Add(Me.txtFiltro1)
        Me.Controls.Add(Me.cmbFiltro1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formSeleccionarEmpleado"
        Me.Text = "Seleccionar Empleado"
        CType(Me.dgvRegionTerritorios1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmpleados1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents dgvRegionTerritorios1 As DataGridView
    Friend WithEvents dgvEmpleados1 As DataGridView
    Friend WithEvents btnBuscar1 As Button
    Friend WithEvents txtFiltro1 As TextBox
    Friend WithEvents cmbFiltro1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEmpleadoEmployeeID1 As Label
    Friend WithEvents lblEmpleadoLastName1 As Label
    Friend WithEvents lblEmpleadoFirstName1 As Label
    Friend WithEvents lblEmpleadoTitle1 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents btnSeleccionar1 As Button
End Class
