Imports Domain
Imports DataAccess
Public Class BusinessEmployees
    Dim objDataAccessEmployees As DataAccessEmployees = New DataAccessEmployees()
    Public Function mostrarEmpleados() As DataTable
        Dim objDataTable = objDataAccessEmployees.selectTableEmployees
        Return objDataTable
    End Function
    Public Function obtenerEmpleado(EmployeeID As String) As Employees
        Dim objEmployees = objDataAccessEmployees.selectEmployeesByEmployeeID(EmployeeID)
        Return objEmployees
    End Function
    Public Function mostrarEmpleadosConFiltro(filter As String, value As String) As DataTable
        If filter = "" Then
            Dim objDataTable = objDataAccessEmployees.selectTableEmployees
            Return objDataTable
        Else
            If filter = "EmployeeID" Or filter = "ReportsTo" Then
                Dim objDataTable = objDataAccessEmployees.selectTableEmployeesByFilter(filter, value)
                Return objDataTable
            Else
                Dim objDataTable = objDataAccessEmployees.selectTableEmployeesByFilter(filter, "'" + value + "'")
                Return objDataTable
            End If
        End If
    End Function
    Public Function mostrarRegion() As DataTable
        Dim objDataTable = objDataAccessEmployees.selectTableRegion
        Return objDataTable
    End Function
    Public Function mostrarTerritoriosDeLaRegionPorRegionDescription(RegionDescription As String) As DataTable
        Dim objRegion = objDataAccessEmployees.selectRegionByRegionDescription(RegionDescription)
        Dim objDataTable = objDataAccessEmployees.selectTableTerritoriesByRegionID(objRegion.RegionID)
        Return objDataTable
    End Function
    Public Function mostrarEmpleadoTerritoriosPorEmployeeID(EmployeeID As String) As DataTable
        Dim objDataTable = objDataAccessEmployees.selectTableEmployeeTerritoriesByEmployeeID(EmployeeID)
        Return objDataTable
    End Function
    Public Function registrarEmpleado(objEmployees As Employees, dtEmpleadoRegionTerritorios As DataTable) As String
        If objEmployees.ReportsTo = "" Then
            objEmployees.ReportsTo = "null"
        End If
        If esValido(objEmployees) = False Then
            Return "Los datos del empeado no son validos"
        End If
        objEmployees.EmployeeID = objDataAccessEmployees.insertEmployees(objEmployees)
        actualizarRegionTerritorios(objEmployees, dtEmpleadoRegionTerritorios)
        Return "Empleado registrado"
    End Function
    Public Function actualizarEmpleado(objEmployees As Employees, dtEmpleadoRegionTerritorios As DataTable) As String
        If objEmployees.ReportsTo = "" Then
            objEmployees.ReportsTo = "null"
        End If
        If esValido(objEmployees) = False Then
            Return "Los datos del empeado no son validos"
        End If
        If existe(objEmployees) = False Then
            Return "El empleado al que desea hacer los cambios no existe"
        End If
        objDataAccessEmployees.updateEmployees(objEmployees)
        actualizarRegionTerritorios(objEmployees, dtEmpleadoRegionTerritorios)
        Return "Empleado Actualizado"
    End Function
    Private Function existe(objEmployees As Employees) As Boolean
        objEmployees = objDataAccessEmployees.selectEmployeesByEmployeeID(objEmployees.EmployeeID)
        If objEmployees.EmployeeID = Nothing Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Function esValido(objEmployees As Employees) As Boolean
        If objEmployees.LastName = "" Then
            Return False
        End If
        If objEmployees.FirstName = "" Then
            Return False
        End If
        Return True
    End Function
    Private Sub actualizarRegionTerritorios(objEmployees As Employees, dtEmpleadoRegionTerritorios As DataTable)
        limpiarRegionTerritorios(objEmployees.EmployeeID)
        For index = 0 To dtEmpleadoRegionTerritorios.Rows.Count - 1
            Dim dr As DataRow = dtEmpleadoRegionTerritorios.Rows.Item(index)
            agregarTerritorio(objEmployees.EmployeeID, dr("RegionDescription").ToString, dr("TerritoryDescription").ToString)
        Next
    End Sub
    Private Sub limpiarRegionTerritorios(EmployeeID As String)
        objDataAccessEmployees.deleteEmployeeTerritories(EmployeeID)
    End Sub
    Public Sub agregarTerritorio(EmployeeID As String, RegionDescription As String, TerritoryDescription As String)
        Dim objRegion As Region = objDataAccessEmployees.selectRegionByRegionDescription(RegionDescription)
        Dim objTerritories As Territories = objDataAccessEmployees.selectTerritoriesByRegionIDAndTerritoryDescription(objRegion.RegionID, TerritoryDescription)
        objDataAccessEmployees.insertEmployeeTerritories(EmployeeID, objTerritories.TerritoryID)
    End Sub
    Public Function eliminarEmpleado(objEmployees As Employees) As String
        If esValido(objEmployees) = False Then
            Return "Los datos del empeado no son validos"
        End If
        If existe(objEmployees) = False Then
            Return "El empleado al que desea eliminar no existe"
        End If
        limpiarRegionTerritorios(objEmployees.EmployeeID)
        Return objDataAccessEmployees.deleteEmployeesByEmployeeID(objEmployees.EmployeeID)
    End Function
End Class

