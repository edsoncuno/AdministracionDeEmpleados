Imports System.Data
Imports System.Data.SqlClient
Imports Domain
Public Class DataAccessEmployees
    Dim connectionString As String = "Data Source=SQL5085.site4now.net;Initial Catalog=DB_A6A533_northwind;User ID=DB_A6A533_northwind_admin;Password=Ricardo51"
    Dim objSqlConnection As SqlConnection = New SqlConnection(connectionString)
    Public Function selectTableEmployees() As DataTable
        Dim objSqlCommand As SqlCommand = New SqlCommand("select * from Employees", objSqlConnection)
        objSqlConnection.Open()
        Dim objSqlDataReader As SqlDataReader = objSqlCommand.ExecuteReader()
        Dim dtEmployees As DataTable = New DataTable()
        dtEmployees.Load(objSqlDataReader)
        objSqlConnection.Close()
        Return dtEmployees
    End Function
    Public Function selectTableEmployeesByFilter(filter As String, value As String) As DataTable
        Dim objSqlCommand As SqlCommand = New SqlCommand("select * from Employees where " + filter + " = " + value + "", objSqlConnection)
        objSqlConnection.Open()
        Dim objSqlDataReader As SqlDataReader = objSqlCommand.ExecuteReader()
        Dim dtEmployees As DataTable = New DataTable()
        dtEmployees.Load(objSqlDataReader)
        objSqlConnection.Close()
        Return dtEmployees
    End Function
    Public Function selectEmployeesByEmployeeID(EmployeeID As String) As Employees
        Dim objSqlCommand As SqlCommand = New SqlCommand("select * from Employees where EmployeeID = " + EmployeeID + "", objSqlConnection)
        objSqlConnection.Open()
        Dim objSqlDataReader As SqlDataReader = objSqlCommand.ExecuteReader()
        Dim objEmployees = New Employees
        If (objSqlDataReader.Read()) Then
            objEmployees.EmployeeID = Convert.ToString(objSqlDataReader("EmployeeID"))
            objEmployees.LastName = Convert.ToString(objSqlDataReader("LastName"))
            objEmployees.FirstName = Convert.ToString(objSqlDataReader("FirstName"))
            objEmployees.Title = Convert.ToString(objSqlDataReader("Title"))
            objEmployees.TitleOfCourtesy = Convert.ToString(objSqlDataReader("TitleOfCourtesy"))
            objEmployees.BirthDate = Convert.ToDateTime(objSqlDataReader("BirthDate"))
            objEmployees.HireDate = Convert.ToDateTime(objSqlDataReader("HireDate"))
            objEmployees.Address = Convert.ToString(objSqlDataReader("Address"))
            objEmployees.City = Convert.ToString(objSqlDataReader("City"))
            objEmployees.Region = Convert.ToString(objSqlDataReader("Region"))
            objEmployees.City = Convert.ToString(objSqlDataReader("City"))
            objEmployees.PostalCode = Convert.ToString(objSqlDataReader("PostalCode"))
            objEmployees.Country = Convert.ToString(objSqlDataReader("Country"))
            objEmployees.HomePhone = Convert.ToString(objSqlDataReader("HomePhone"))
            objEmployees.Extension = Convert.ToString(objSqlDataReader("Extension"))
            objEmployees.Photo = CType(objSqlDataReader("Photo"), Byte())
            objEmployees.Notes = Convert.ToString(objSqlDataReader("Notes"))
            objEmployees.ReportsTo = Convert.ToString(objSqlDataReader("ReportsTo"))
            objEmployees.PhotoPath = Convert.ToString(objSqlDataReader("PhotoPath"))
        Else
            objEmployees.EmployeeID = Nothing
        End If
        objSqlConnection.Close()
        Return objEmployees
    End Function
    Public Function selectTableRegion() As DataTable
        Dim objSqlCommand As SqlCommand = New SqlCommand("select * from Region", objSqlConnection)
        objSqlConnection.Open()
        Dim objSqlDataReader As SqlDataReader = objSqlCommand.ExecuteReader()
        Dim dtRegion As DataTable = New DataTable()
        dtRegion.Load(objSqlDataReader)
        objSqlConnection.Close()
        Return dtRegion
    End Function
    Public Function selectTableTerritoriesByRegionID(RegionID As String)
        Dim objSqlCommand As SqlCommand = New SqlCommand("select * from Territories where RegionID =" + RegionID + "", objSqlConnection)
        objSqlConnection.Open()
        Dim objSqlDataReader As SqlDataReader = objSqlCommand.ExecuteReader()
        Dim dtTerritories As DataTable = New DataTable()
        dtTerritories.Load(objSqlDataReader)
        objSqlConnection.Close()
        Return dtTerritories
    End Function
    Public Function selectTableEmployeeTerritoriesByEmployeeID(EmployeeID As String) As DataTable
        Dim objSqlCommand As SqlCommand = New SqlCommand("select " +
                                                         "Region.RegionDescription, " +
                                                         "Territories.TerritoryDescription " +
                                                         "from EmployeeTerritories " +
                                                         "inner join Territories on " +
                                                         "Territories.TerritoryID = EmployeeTerritories.TerritoryID " +
                                                         "inner join Region on " +
                                                         "Territories.RegionID = Region.RegionID " +
                                                         "where EmployeeID =" + EmployeeID + "", objSqlConnection)
        objSqlConnection.Open()
        Dim objSqlDataReader As SqlDataReader = objSqlCommand.ExecuteReader()
        Dim dtEmployeeTerritories As DataTable = New DataTable()
        dtEmployeeTerritories.Load(objSqlDataReader)
        objSqlConnection.Close()
        Return dtEmployeeTerritories
    End Function
    Public Sub insertEmployees(objEmployees As Employees)
        Dim objSqlCommand As SqlCommand = New SqlCommand(
        "insert into Employees (LastName) values ('asd')", objSqlConnection)
        objSqlConnection.Open()
        objSqlCommand.ExecuteNonQuery()
        objSqlConnection.Close()
    End Sub
    Public Sub updateEmployees(objEmployees As Employees)
        Dim objSqlCommand As SqlCommand = New SqlCommand(
        "update Employees set " +
        "LastName = '" + objEmployees.LastName + "', " +
        "FirstName = '" + objEmployees.FirstName + "', " +
        "Title = '" + objEmployees.Title + "', " +
        "TitleOfCourtesy = '" + objEmployees.TitleOfCourtesy + "', " +
        "Address = '" + objEmployees.Address + "', " +
        "City = '" + objEmployees.City + "', " +
        "Region = '" + objEmployees.Region + "', " +
        "PostalCode = '" + objEmployees.PostalCode + "', " +
        "Country = '" + objEmployees.Country + "', " +
        "HomePhone = '" + objEmployees.HomePhone + "', " +
        "Extension = '" + objEmployees.Extension + "', " +
        "Notes = '" + objEmployees.Notes + "', " +
        "ReportsTo = " + objEmployees.ReportsTo + ", " +
        "PhotoPath = '" + objEmployees.PhotoPath + "' " +
        "where EmployeeID = " + objEmployees.EmployeeID + "", objSqlConnection)
        objSqlConnection.Open()
        objSqlCommand.ExecuteNonQuery()
        objSqlConnection.Close()
    End Sub
    Public Sub deleteEmployeeTerritories(EmployeeID As String)
        Dim objSqlCommand As SqlCommand = New SqlCommand(
        "delete from EmployeeTerritories where EmployeeID = " + EmployeeID + "", objSqlConnection)
        objSqlConnection.Open()
        objSqlCommand.ExecuteNonQuery()
        objSqlConnection.Close()
    End Sub
    Public Function selectRegionByRegionDescription(RegionDescription As String) As Region
        Dim objSqlCommand As SqlCommand = New SqlCommand("select * from Region where RegionDescription = '" + RegionDescription + "'", objSqlConnection)
        objSqlConnection.Open()
        Dim objSqlDataReader As SqlDataReader = objSqlCommand.ExecuteReader()
        Dim objRegion = New Region
        If (objSqlDataReader.Read()) Then
            objRegion.RegionID = Convert.ToString(objSqlDataReader("RegionID"))
            objRegion.RegionDescription = Convert.ToString(objSqlDataReader("RegionDescription"))
        Else
            objRegion.RegionID = Nothing
            objRegion.RegionDescription = Nothing
        End If
        objSqlConnection.Close()
        Return objRegion
    End Function
    Public Function selectTerritoriesByRegionIDAndTerritoryDescription(RegionID As String, TerritoryDescription As String) As Territories
        Dim objSqlCommand As SqlCommand = New SqlCommand(
        "select * from Territories where RegionID = " + RegionID + " and TerritoryDescription = '" + TerritoryDescription + "'", objSqlConnection)
        objSqlConnection.Open()
        Dim objSqlDataReader As SqlDataReader = objSqlCommand.ExecuteReader()
        Dim objTerritories = New Territories
        If (objSqlDataReader.Read()) Then
            objTerritories.TerritoryID = Convert.ToString(objSqlDataReader("TerritoryID"))
            objTerritories.TerritoryDescription = Convert.ToString(objSqlDataReader("TerritoryDescription"))
            objTerritories.RegionID = Convert.ToString(objSqlDataReader("RegionID"))
        Else
            objTerritories.TerritoryID = Nothing
            objTerritories.TerritoryDescription = Nothing
            objTerritories.RegionID = Nothing
        End If
        objSqlConnection.Close()
        Return objTerritories
    End Function
    Public Sub insertEmployeeTerritories(EmployeeID As String, TerritoryID As String)
        Dim objSqlCommand As SqlCommand = New SqlCommand(
        "insert into EmployeeTerritories (EmployeeID, TerritoryID) values (" + EmployeeID + ",'" + TerritoryID + "')", objSqlConnection)
        objSqlConnection.Open()
        objSqlCommand.ExecuteNonQuery()
        objSqlConnection.Close()
    End Sub
    Public Function deleteEmployeesByEmployeeID(EmployeeID As String) As String
        Dim objSqlCommand As SqlCommand = New SqlCommand(
        "delete from Employees where EmployeeID = " + EmployeeID + "", objSqlConnection)
        objSqlConnection.Open()
        Try
            objSqlCommand.ExecuteNonQuery()
            objSqlConnection.Close()
            Return "Empleado eliminado"
        Catch ex As Exception
            objSqlConnection.Close()
            Return "No se puedo eliminar al Empleado por que tiene Ordenes asociados"
        End Try
    End Function
End Class
