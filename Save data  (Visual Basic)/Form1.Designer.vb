<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LstvContentData = New ListView()
        SaveArrayBtn = New Button()
        SaveBtn = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        NamePdrocutTxt = New TextBox()
        QuantityNud = New NumericUpDown()
        PriseNud = New NumericUpDown()
        Product = New ColumnHeader()
        Quantity = New ColumnHeader()
        Price_Finish = New ColumnHeader()
        CType(QuantityNud, ComponentModel.ISupportInitialize).BeginInit()
        CType(PriseNud, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LstvContentData
        ' 
        LstvContentData.Columns.AddRange(New ColumnHeader() {Product, Quantity, Price_Finish})
        LstvContentData.Location = New Point(296, 13)
        LstvContentData.Name = "LstvContentData"
        LstvContentData.Size = New Size(492, 426)
        LstvContentData.TabIndex = 0
        LstvContentData.UseCompatibleStateImageBehavior = False
        LstvContentData.View = View.Details
        ' 
        ' SaveArrayBtn
        ' 
        SaveArrayBtn.Location = New Point(117, 196)
        SaveArrayBtn.Name = "SaveArrayBtn"
        SaveArrayBtn.Size = New Size(75, 23)
        SaveArrayBtn.TabIndex = 1
        SaveArrayBtn.Text = "Save"
        SaveArrayBtn.UseVisualStyleBackColor = True
        ' 
        ' SaveBtn
        ' 
        SaveBtn.Location = New Point(65, 380)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(173, 23)
        SaveBtn.TabIndex = 2
        SaveBtn.Text = " Save Data Of File Text"
        SaveBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 15)
        Label1.TabIndex = 3
        Label1.Text = "Name of The Product"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 15)
        Label2.TabIndex = 4
        Label2.Text = "Quantity"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 15)
        Label3.TabIndex = 5
        Label3.Text = "Prise for one product"
        ' 
        ' NamePdrocutTxt
        ' 
        NamePdrocutTxt.Location = New Point(155, 15)
        NamePdrocutTxt.Name = "NamePdrocutTxt"
        NamePdrocutTxt.Size = New Size(135, 23)
        NamePdrocutTxt.TabIndex = 6
        ' 
        ' QuantityNud
        ' 
        QuantityNud.Location = New Point(155, 66)
        QuantityNud.Name = "QuantityNud"
        QuantityNud.Size = New Size(135, 23)
        QuantityNud.TabIndex = 7
        ' 
        ' PriseNud
        ' 
        PriseNud.Location = New Point(155, 113)
        PriseNud.Name = "PriseNud"
        PriseNud.Size = New Size(135, 23)
        PriseNud.TabIndex = 8
        ' 
        ' Product
        ' 
        Product.Text = "Product"
        Product.Width = 129
        ' 
        ' Quantity
        ' 
        Quantity.Text = "Quantity"
        Quantity.Width = 120
        ' 
        ' Price_Finish
        ' 
        Price_Finish.Text = "Price Finish"
        Price_Finish.Width = 129
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PriseNud)
        Controls.Add(QuantityNud)
        Controls.Add(NamePdrocutTxt)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(SaveBtn)
        Controls.Add(SaveArrayBtn)
        Controls.Add(LstvContentData)
        Name = "Form1"
        Text = "Form1"
        CType(QuantityNud, ComponentModel.ISupportInitialize).EndInit()
        CType(PriseNud, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LstvContentData As ListView
    Friend WithEvents SaveArrayBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NamePdrocutTxt As TextBox
    Friend WithEvents QuantityNud As NumericUpDown
    Friend WithEvents PriseNud As NumericUpDown
    Friend WithEvents Product As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents Price_Finish As ColumnHeader

End Class
