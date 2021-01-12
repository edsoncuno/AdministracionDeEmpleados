Imports System.Data
Imports Domain
Imports Business
Public Class formSeleccionarEmpleado
    Dim objBusinessEmployees1 As Business.BusinessEmployees = New Business.BusinessEmployees
    Private Sub formSeleccionarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar()
    End Sub
    Private Sub inicializar()
        dgvEmpleados1.DataSource = objBusinessEmployees1.mostrarEmpleados
        llenarCmbFiltros(cmbFiltro1)
    End Sub
    Private Sub llenarCmbFiltros(cmb As ComboBox)
        cmb.Items.Add("")
        cmb.Items.Add("EmployeeID")
        cmb.Items.Add("LastName")
        cmb.Items.Add("FirstName")
        cmb.Items.Add("Title")
        cmb.Items.Add("TitleOfCourtesy")
        cmb.Items.Add("Address")
        cmb.Items.Add("City")
        cmb.Items.Add("Region")
        cmb.Items.Add("PostalCode")
        cmb.Items.Add("Country")
        cmb.Items.Add("HomePhone")
        cmb.Items.Add("Extension")
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar1.Click
        dgvEmpleados1.DataSource = objBusinessEmployees1.mostrarEmpleadosConFiltro(cmbFiltro1.Text, txtFiltro1.Text)
    End Sub
    Private Sub dgvEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados1.CellClick
        If e.RowIndex >= 0 And e.RowIndex < dgvEmpleados1.Rows.Count - 1 Then
            Dim fila As DataGridViewRow
            fila = dgvEmpleados1.Rows(e.RowIndex)
            Dim objEmployees As Employees = New Employees
            objEmployees.EmployeeID = fila.Cells("EmployeeID").Value.ToString()
            objEmployees = objBusinessEmployees1.obtenerEmpleado(objEmployees.EmployeeID)
            mostrarEmpleado(objEmployees)
            mostrarRegionTerritorios(objEmployees)
        End If
    End Sub
    Private Sub mostrarEmpleado(objEmployees As Employees)
        mostarDatosDeEmpleado(objEmployees)
    End Sub
    Private Sub mostarDatosDeEmpleado(objEmployees As Employees)
        lblEmpleadoEmployeeID1.Text = objEmployees.EmployeeID
        lblEmpleadoLastName1.Text = objEmployees.LastName
        lblEmpleadoFirstName1.Text = objEmployees.FirstName
        lblEmpleadoTitle1.Text = objEmployees.Title
    End Sub
    Private Sub mostrarRegionTerritorios(objEmployees As Employees)
        dgvRegionTerritorios1.DataSource = objBusinessEmployees1.mostrarEmpleadoTerritoriosPorEmployeeID(objEmployees.EmployeeID)
    End Sub
    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar1.Click
        formAdministrarEmpleado.Show()
        Dispose()
    End Sub
End Class