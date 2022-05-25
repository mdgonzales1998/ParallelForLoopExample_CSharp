Public Class CustomerOrders
    'CustomerID
    'CompanyName
    'ContactName
    'ContactTitle
    'Customers.Address
    'Customers.City
    'Customers.Region
    'Customers.PostalCode
    'Customers.Country
    'Customers.Phone
    'Customers.Fax

    Private CustomerIDValue As String
    Public Property CustomerID() As String
        Get
            Return CustomerIDValue
        End Get
        Set(ByVal value As String)
            CustomerIDValue = value
        End Set
    End Property

    Private CompanyNameValue As String
    Public Property CompanyName() As String
        Get
            Return CompanyNameValue
        End Get
        Set(ByVal value As String)
            CompanyNameValue = value
        End Set
    End Property

    Private ContactNameValue As String
    Public Property ContactName() As String
        Get
            Return ContactNameValue
        End Get
        Set(ByVal value As String)
            ContactNameValue = value
        End Set
    End Property

    Private ContactTitleValue As String
    Public Property ContactTitle() As String
        Get
            Return ContactTitleValue
        End Get
        Set(ByVal value As String)
            ContactTitleValue = value
        End Set
    End Property

    Private Customers_AddressValue As String
    Public Property Customers_Address() As String
        Get
            Return Customers_AddressValue
        End Get
        Set(ByVal value As String)
            Customers_AddressValue = value
        End Set
    End Property

    Private Customers_CityValue As String
    Public Property Customers_City() As String
        Get
            Return Customers_CityValue
        End Get
        Set(ByVal value As String)
            Customers_CityValue = value
        End Set
    End Property

    Private Customers_RegionValue As String
    Public Property Customers_Region() As String
        Get
            Return Customers_RegionValue
        End Get
        Set(ByVal value As String)
            Customers_RegionValue = value
        End Set
    End Property

    Private Customers_PostalCodeValue As String
    Public Property Customers_PostalCode() As String
        Get
            Return Customers_PostalCodeValue
        End Get
        Set(ByVal value As String)
            Customers_PostalCodeValue = value
        End Set
    End Property

    Private Customers_CountryValue As String
    Public Property Customers_Country() As String
        Get
            Return Customers_CountryValue
        End Get
        Set(ByVal value As String)
            Customers_CountryValue = value
        End Set
    End Property

    Private Customers_PhoneValue As String
    Public Property Customers_Phone() As String
        Get
            Return Customers_PhoneValue
        End Get
        Set(ByVal value As String)
            Customers_PhoneValue = value
        End Set
    End Property

    Private Customers_FaxValue As String
    Public Property Customers_Fax() As String
        Get
            Return Customers_FaxValue
        End Get
        Set(ByVal value As String)
            Customers_FaxValue = value
        End Set
    End Property

End Class
