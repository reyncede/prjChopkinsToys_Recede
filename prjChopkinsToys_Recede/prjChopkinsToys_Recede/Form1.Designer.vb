<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt12Qty = New System.Windows.Forms.TextBox()
        Me.txt12Total = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt5Qty = New System.Windows.Forms.TextBox()
        Me.txt5Total = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt2Qty = New System.Windows.Forms.TextBox()
        Me.txt2Total = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtShipping = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalQty = New System.Windows.Forms.TextBox()
        Me.txtSaleTotal = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Invoice"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Date ordered:"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(143, 72)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(91, 20)
        Me.txtDate.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "&12 pack:"
        '
        'txt12Qty
        '
        Me.txt12Qty.Location = New System.Drawing.Point(105, 105)
        Me.txt12Qty.Name = "txt12Qty"
        Me.txt12Qty.Size = New System.Drawing.Size(44, 20)
        Me.txt12Qty.TabIndex = 4
        '
        'txt12Total
        '
        Me.txt12Total.BackColor = System.Drawing.SystemColors.Info
        Me.txt12Total.Location = New System.Drawing.Point(155, 105)
        Me.txt12Total.Name = "txt12Total"
        Me.txt12Total.ReadOnly = True
        Me.txt12Total.Size = New System.Drawing.Size(100, 20)
        Me.txt12Total.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&5 pack:"
        '
        'txt5Qty
        '
        Me.txt5Qty.Location = New System.Drawing.Point(105, 131)
        Me.txt5Qty.Name = "txt5Qty"
        Me.txt5Qty.Size = New System.Drawing.Size(44, 20)
        Me.txt5Qty.TabIndex = 7
        '
        'txt5Total
        '
        Me.txt5Total.BackColor = System.Drawing.SystemColors.Info
        Me.txt5Total.Location = New System.Drawing.Point(155, 131)
        Me.txt5Total.Name = "txt5Total"
        Me.txt5Total.ReadOnly = True
        Me.txt5Total.Size = New System.Drawing.Size(100, 20)
        Me.txt5Total.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "&2 pack:"
        '
        'txt2Qty
        '
        Me.txt2Qty.Location = New System.Drawing.Point(105, 157)
        Me.txt2Qty.Name = "txt2Qty"
        Me.txt2Qty.Size = New System.Drawing.Size(44, 20)
        Me.txt2Qty.TabIndex = 10
        '
        'txt2Total
        '
        Me.txt2Total.BackColor = System.Drawing.SystemColors.Info
        Me.txt2Total.Location = New System.Drawing.Point(155, 157)
        Me.txt2Total.Name = "txt2Total"
        Me.txt2Total.ReadOnly = True
        Me.txt2Total.Size = New System.Drawing.Size(100, 20)
        Me.txt2Total.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Shipping:"
        '
        'txtShipping
        '
        Me.txtShipping.BackColor = System.Drawing.SystemColors.Info
        Me.txtShipping.Location = New System.Drawing.Point(155, 194)
        Me.txtShipping.Name = "txtShipping"
        Me.txtShipping.ReadOnly = True
        Me.txtShipping.Size = New System.Drawing.Size(100, 20)
        Me.txtShipping.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Sale totals:"
        '
        'txtTotalQty
        '
        Me.txtTotalQty.Location = New System.Drawing.Point(105, 225)
        Me.txtTotalQty.Name = "txtTotalQty"
        Me.txtTotalQty.ReadOnly = True
        Me.txtTotalQty.Size = New System.Drawing.Size(44, 20)
        Me.txtTotalQty.TabIndex = 15
        '
        'txtSaleTotal
        '
        Me.txtSaleTotal.BackColor = System.Drawing.SystemColors.Info
        Me.txtSaleTotal.Location = New System.Drawing.Point(155, 225)
        Me.txtSaleTotal.Name = "txtSaleTotal"
        Me.txtSaleTotal.ReadOnly = True
        Me.txtSaleTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSaleTotal.TabIndex = 16
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(24, 264)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 17
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(105, 264)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(186, 264)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 312)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtSaleTotal)
        Me.Controls.Add(Me.txtTotalQty)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtShipping)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt2Total)
        Me.Controls.Add(Me.txt2Qty)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt5Total)
        Me.Controls.Add(Me.txt5Qty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt12Total)
        Me.Controls.Add(Me.txt12Qty)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "                     Chopkins Toys"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt12Qty As TextBox
    Friend WithEvents txt12Total As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt5Qty As TextBox
    Friend WithEvents txt5Total As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt2Qty As TextBox
    Friend WithEvents txt2Total As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtShipping As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotalQty As TextBox
    Friend WithEvents txtSaleTotal As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
