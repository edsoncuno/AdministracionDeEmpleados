Imports System.Data
Imports System.Data.SqlClient
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
End Class
