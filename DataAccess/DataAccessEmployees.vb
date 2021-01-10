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
    Public Function selectRegionByRegionDescription(RegionDescription As String) As Region
        Dim objSqlCommand As SqlCommand = New SqlCommand("select * from Region where RegionDescription = '" + RegionDescription + "'", objSqlConnection)
        objSqlConnection.Open()
        Dim objSqlDataReader As SqlDataReader = objSqlCommand.ExecuteReader()
        Dim objRegion = New Region
        If (objSqlDataReader.Read()) Then
            objRegion.RegionID = Convert.ToString(objSqlDataReader("RegionID"))
            objRegion.RegionDescription = Convert.ToString(objSqlDataReader("RegionDescription"))
        End If
        objSqlConnection.Close()
        Return objRegion
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
End Class
