Public Class ItemForContainter
    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _quantity As Integer
    Public Property Quantity() As Integer
        Get
            Return _quantity
        End Get
        Set(ByVal value As Integer)
            _quantity = value
        End Set
    End Property

    Private _price As Integer
    Public Property Price() As Integer
        Get
            Return _price
        End Get
        Set(ByVal value As Integer)
            _price = value
        End Set
    End Property

    Public Sub New()
        _name = ""
        _quantity = 0
        _price = 0
    End Sub

    Public Sub New(ByVal names As String, ByVal quantitys As Integer, ByVal prices As Integer)
        _name = names
        _quantity = quantitys
        _price = prices
    End Sub

    Public Overrides Function ToString() As String
        Return _name & " - " & _quantity & " - " & _price
    End Function
End Class

