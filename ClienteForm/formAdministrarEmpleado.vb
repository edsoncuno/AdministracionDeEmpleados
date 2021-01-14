Imports Domain
Imports Business
Public Class formAdministrarEmpleado
    Dim objBusinessEmployees As Business.BusinessEmployees = New Business.BusinessEmployees
    Dim dtEmpleadoRegionTerritorios As DataTable
    Dim empleado As Employees
    Private Sub formAdministrarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar()
    End Sub
    Private Sub inicializar()
        dgvEmpleados.DataSource = objBusinessEmployees.mostrarEmpleados
        Dim now As DateTime = Date.Now
        mcEmpleadoBirthDate.ShowToday = False
        mcEmpleadoBirthDate.SetDate(now)
        mcEmpleadoHireDate.ShowToday = False
        mcEmpleadoHireDate.SetDate(now)
        llenarCmbFiltros(cmbFiltro)
        txtFiltro.Text = ""
        lblEmpleadoEmployeeID.Text = ""
        txtEmpleadoLastName.Text = ""
        txtEmpleadoFirstName.Text = ""
        txtEmpleadoTitle.Text = ""
        txtEmpleadoTitleOfCourtesy.Text = ""
        mcEmpleadoBirthDate.SetDate(Date.Now)
        mcEmpleadoHireDate.SetDate(Date.Now)
        txtEmpleadoAddress.Text = ""
        txtEmpleadoCity.Text = ""
        txtEmpleadoRegion.Text = ""
        txtEmpleadoPostalCode.Text = ""
        txtEmpleadoCountry.Text = ""
        txtEmpleadoHomePhone.Text = ""
        txtEmpleadoExtension.Text = ""
        txtEmpleadoNotes.Text = ""
        btnEmpleadoReportsTo.Text = ""
        txtEmpleadoPhotoPath.Text = ""
        lblReportarAEmployeeID.Text = ""
        lblReportarALastName.Text = ""
        lblReportarAFirstName.Text = ""
        lblReportarATitle.Text = ""
        lblReportarATitleOfCourtesy.Text = ""
        lblReportarABirthDate.Text = ""
        lblReportarAHireDate.Text = ""
        lblReportarAAddress.Text = ""
        lblReportarACity.Text = ""
        lblReportarARegion.Text = ""
        lblReportarAPostalCode.Text = ""
        lblReportarACountry.Text = ""
        lblReportarAHomePhone.Text = ""
        lblReportarAExtension.Text = ""
        lblReportarANotes.Text = ""
        lblReportarAReportsTo.Text = ""
        lblReportarAPhotoPath.Text = ""
        cmbRegion.Items.Clear()
        cmbTerritorio.Items.Clear()
        llenarCmbRegion(cmbRegion)
        dtEmpleadoRegionTerritorios = New DataTable
        dtEmpleadoRegionTerritorios.Columns.Add("RegionDescription", GetType(String))
        dtEmpleadoRegionTerritorios.Columns.Add("TerritoryDescription", GetType(String))
        dgvEmpleadoRegionTerritorios.DataSource = dtEmpleadoRegionTerritorios
        empleado = New Employees
        dgvEmpleadoRegionTerritorios.DataSource = Nothing
        dgvRegionTerritorios.DataSource = Nothing
    End Sub
    Private Sub llenarCmbFiltros(cmb As ComboBox)
        cmb.Items.Clear()
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
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dgvEmpleados.DataSource = objBusinessEmployees.mostrarEmpleadosConFiltro(cmbFiltro.Text, txtFiltro.Text)
    End Sub
    Private Sub dgvEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellClick
        If e.RowIndex >= 0 And e.RowIndex < dgvEmpleados.Rows.Count - 1 Then
            Dim fila As DataGridViewRow
            fila = dgvEmpleados.Rows(e.RowIndex)
            empleado.EmployeeID = fila.Cells("EmployeeID").Value.ToString()
            empleado = objBusinessEmployees.obtenerEmpleado(empleado.EmployeeID)
            mostrarEmpleado(empleado)
            mostrarRegionTerritorios(empleado)
            mostrarEmpleadoRegionTerritorios(empleado)
        End If
    End Sub
    Private Sub mostrarEmpleado(objEmployees As Employees)
        mostarDatosDeEmpleado(objEmployees)
        Dim objEmployeesAQuienSeReporta As Employees = New Employees
        If objEmployees.ReportsTo <> "" Then
            objEmployeesAQuienSeReporta = objBusinessEmployees.obtenerEmpleado(objEmployees.ReportsTo)
            mostrarDatosDelEmpleadoAQuienSeReporta(objEmployeesAQuienSeReporta)
        Else
            objEmployeesAQuienSeReporta.BirthDate = Nothing
            objEmployeesAQuienSeReporta.HireDate = Nothing
            mostrarDatosDelEmpleadoAQuienSeReporta(objEmployeesAQuienSeReporta)
        End If
    End Sub
    Private Sub mostarDatosDeEmpleado(objEmployees As Employees)
        lblEmpleadoEmployeeID.Text = objEmployees.EmployeeID
        txtEmpleadoLastName.Text = objEmployees.LastName
        txtEmpleadoFirstName.Text = objEmployees.FirstName
        txtEmpleadoTitle.Text = objEmployees.Title
        txtEmpleadoTitleOfCourtesy.Text = objEmployees.TitleOfCourtesy
        mcEmpleadoBirthDate.SetDate(convertirStringADateTime(objEmployees.BirthDate))
        mcEmpleadoHireDate.SetDate(convertirStringADateTime(objEmployees.HireDate))
        txtEmpleadoAddress.Text = objEmployees.Address
        txtEmpleadoCity.Text = objEmployees.City
        txtEmpleadoRegion.Text = objEmployees.Region
        txtEmpleadoPostalCode.Text = objEmployees.PostalCode
        txtEmpleadoCountry.Text = objEmployees.Country
        txtEmpleadoHomePhone.Text = objEmployees.HomePhone
        txtEmpleadoExtension.Text = objEmployees.HomePhone
        txtEmpleadoNotes.Text = objEmployees.Notes
        btnEmpleadoReportsTo.Text = objEmployees.ReportsTo
        txtEmpleadoPhotoPath.Text = objEmployees.PhotoPath
    End Sub
    Private Sub mostrarDatosDelEmpleadoAQuienSeReporta(objEmployees As Employees)
        lblReportarAEmployeeID.Text = objEmployees.EmployeeID
        lblReportarALastName.Text = objEmployees.LastName
        lblReportarAFirstName.Text = objEmployees.FirstName
        lblReportarATitle.Text = objEmployees.Title
        lblReportarATitleOfCourtesy.Text = objEmployees.TitleOfCourtesy
        If objEmployees.BirthDate = Nothing Then
            lblReportarABirthDate.Text = ""
        Else
            lblReportarABirthDate.Text = objEmployees.BirthDate.ToString()
        End If
        If objEmployees.HireDate = Nothing Then
            lblReportarAHireDate.Text = ""
        Else
            lblReportarAHireDate.Text = objEmployees.HireDate.ToString()
        End If
        lblReportarAAddress.Text = objEmployees.Address
        lblReportarACity.Text = objEmployees.City
        lblReportarARegion.Text = objEmployees.Region
        lblReportarAPostalCode.Text = objEmployees.PostalCode
        lblReportarACountry.Text = objEmployees.Country
        lblReportarAHomePhone.Text = objEmployees.HomePhone
        lblReportarAExtension.Text = objEmployees.HomePhone
        lblReportarANotes.Text = objEmployees.Notes
        lblReportarAReportsTo.Text = objEmployees.ReportsTo
        lblReportarAPhotoPath.Text = objEmployees.PhotoPath
    End Sub
    Private Sub mostrarRegionTerritorios(objEmployees As Employees)
        dgvRegionTerritorios.DataSource = objBusinessEmployees.mostrarEmpleadoTerritoriosPorEmployeeID(objEmployees.EmployeeID)
    End Sub
    Private Sub mostrarEmpleadoRegionTerritorios(objEmployees As Employees)
        dtEmpleadoRegionTerritorios = objBusinessEmployees.mostrarEmpleadoTerritoriosPorEmployeeID(objEmployees.EmployeeID)
        dgvEmpleadoRegionTerritorios.DataSource = dtEmpleadoRegionTerritorios
    End Sub
    Private Sub llenarComboBoxConDataTable(cmb As ComboBox, dt As DataTable, column As String)
        cmb.Items.Clear()
        Dim dr As DataRow
        For indexRow = 0 To dt.Rows.Count - 1
            dr = dt.Rows.Item(indexRow)
            cmb.Items.Add(dr(column))
        Next
        cmb.SelectedIndex = 0
    End Sub
    Private Sub llenarCmbRegion(cmb As ComboBox)
        llenarComboBoxConDataTable(cmb, objBusinessEmployees.mostrarRegion(), "RegionDescription")
    End Sub
    Private Sub cmbRegion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRegion.SelectedIndexChanged
        Dim RegionDescription As String = cmbRegion.Text
        llenarComboBoxConDataTable(cmbTerritorio, objBusinessEmployees.mostrarTerritoriosDeLaRegionPorRegionDescription(RegionDescription), "TerritoryDescription")
        dgvEmpleadoRegionTerritorios.Select()
    End Sub
    Private Sub cmbTerritorio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTerritorio.SelectedIndexChanged
        dgvEmpleadoRegionTerritorios.Select()
    End Sub
    Private Sub btnEmpleadoReportsTo_Click(sender As Object, e As EventArgs) Handles btnEmpleadoReportsTo.Click
        Dim objForm As Form = New formSeleccionarEmpleado()
        objForm.Show()
        Hide()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim existe As Boolean = False
        For indexRow = 0 To dtEmpleadoRegionTerritorios.Rows.Count - 1
            Dim dr As DataRow = dtEmpleadoRegionTerritorios.Rows.Item(indexRow)
            If dr("RegionDescription") = cmbRegion.Text And dr("TerritoryDescription") = cmbTerritorio.Text Then
                existe = True
            End If
        Next
        If existe = False Then
            dtEmpleadoRegionTerritorios.Rows.Add(cmbRegion.Text, cmbTerritorio.Text)
            actualizarEmpleadoRegionTerritorios()
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        For indexRow = 0 To dtEmpleadoRegionTerritorios.Rows.Count - 1
            Dim dr As DataRow = dtEmpleadoRegionTerritorios.Rows.Item(indexRow)
            If dr("RegionDescription") = cmbRegion.Text And dr("TerritoryDescription") = cmbTerritorio.Text Then
                dr.Delete()
            End If
        Next
        dtEmpleadoRegionTerritorios.AcceptChanges()
        actualizarEmpleadoRegionTerritorios()
    End Sub
    Private Sub actualizarEmpleadoRegionTerritorios()
        dgvEmpleadoRegionTerritorios.DataSource = dtEmpleadoRegionTerritorios
    End Sub
    Private Function convertirStringADateTime(objString As String) As DateTime
        Return Date.ParseExact(objString, "yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo)
    End Function
    Private Function convertirDateTimeAString(objDateTime As DateTime) As String
        Return objDateTime.Year.ToString + "-" + agregarUnCeroAlNumeroMenorADiez(objDateTime.Month.ToString) + "-" + agregarUnCeroAlNumeroMenorADiez(objDateTime.Day.ToString)
    End Function
    Private Function agregarUnCeroAlNumeroMenorADiez(numero As String) As String
        If numero.Length = 1 Then
            numero = "0" + numero
        End If
        Return numero
    End Function
    Private Sub obtenerDatosDeEmpleado()
        empleado.EmployeeID = lblEmpleadoEmployeeID.Text
        empleado.LastName = txtEmpleadoLastName.Text
        empleado.FirstName = txtEmpleadoFirstName.Text
        empleado.Title = txtEmpleadoTitle.Text
        empleado.TitleOfCourtesy = txtEmpleadoTitleOfCourtesy.Text
        empleado.BirthDate = convertirDateTimeAString(Convert.ToDateTime(mcEmpleadoBirthDate.SelectionRange.Start.ToUniversalTime()))
        empleado.HireDate = convertirDateTimeAString(Convert.ToDateTime(mcEmpleadoHireDate.SelectionRange.Start.ToUniversalTime()))
        empleado.Address = txtEmpleadoAddress.Text
        empleado.City = txtEmpleadoCity.Text
        empleado.Region = txtEmpleadoRegion.Text
        empleado.PostalCode = txtEmpleadoPostalCode.Text
        empleado.Country = txtEmpleadoCountry.Text
        empleado.HomePhone = txtEmpleadoHomePhone.Text
        empleado.Extension = txtEmpleadoExtension.Text
        empleado.Notes = txtEmpleadoNotes.Text
        empleado.ReportsTo = btnEmpleadoReportsTo.Text
        empleado.PhotoPath = txtEmpleadoPhotoPath.Text
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        inicializar()
    End Sub
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        obtenerDatosDeEmpleado()
        MessageBox.Show(objBusinessEmployees.registrarEmpleado(empleado, dtEmpleadoRegionTerritorios))
        inicializar()
    End Sub
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        obtenerDatosDeEmpleado()
        MessageBox.Show(objBusinessEmployees.actualizarEmpleado(empleado, dtEmpleadoRegionTerritorios))
        inicializar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        obtenerDatosDeEmpleado()
        MessageBox.Show(objBusinessEmployees.eliminarEmpleado(empleado))
        inicializar()
    End Sub
End Class
