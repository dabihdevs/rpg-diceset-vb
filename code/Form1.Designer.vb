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
        txtResults = New TextBox()
        lblResults = New Label()
        btnClear = New Button()
        cbxDices = New ComboBox()
        lblDice = New Label()
        lblQuantity = New Label()
        btnRoll = New Button()
        nudQuantity = New NumericUpDown()
        nudBonus = New NumericUpDown()
        Label1 = New Label()
        CType(nudQuantity, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudBonus, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtResults
        ' 
        txtResults.Location = New Point(323, 81)
        txtResults.Multiline = True
        txtResults.Name = "txtResults"
        txtResults.ScrollBars = ScrollBars.Vertical
        txtResults.Size = New Size(261, 249)
        txtResults.TabIndex = 0
        ' 
        ' lblResults
        ' 
        lblResults.AutoSize = True
        lblResults.Location = New Point(323, 41)
        lblResults.Name = "lblResults"
        lblResults.Size = New Size(97, 25)
        lblResults.TabIndex = 1
        lblResults.Text = "Roll results"
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(323, 370)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(147, 42)
        btnClear.TabIndex = 2
        btnClear.Text = "Clear results"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' cbxDices
        ' 
        cbxDices.FormattingEnabled = True
        cbxDices.Items.AddRange(New Object() {"d20", "d12", "d10", "d100", "d8", "d6", "d4"})
        cbxDices.Location = New Point(57, 81)
        cbxDices.Name = "cbxDices"
        cbxDices.Size = New Size(182, 33)
        cbxDices.TabIndex = 3
        cbxDices.Text = "d20"
        ' 
        ' lblDice
        ' 
        lblDice.AutoSize = True
        lblDice.Location = New Point(56, 41)
        lblDice.Name = "lblDice"
        lblDice.Size = New Size(99, 25)
        lblDice.TabIndex = 4
        lblDice.Text = "Select dice:"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(56, 135)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(130, 25)
        lblQuantity.TabIndex = 5
        lblQuantity.Text = "Insert quantity:"
        ' 
        ' btnRoll
        ' 
        btnRoll.Font = New Font("Roman Antique", 18F, FontStyle.Bold, GraphicsUnit.Point)
        btnRoll.Location = New Point(56, 346)
        btnRoll.Name = "btnRoll"
        btnRoll.Size = New Size(177, 66)
        btnRoll.TabIndex = 7
        btnRoll.Text = "Roll!"
        btnRoll.UseVisualStyleBackColor = True
        ' 
        ' nudQuantity
        ' 
        nudQuantity.Location = New Point(56, 174)
        nudQuantity.Name = "nudQuantity"
        nudQuantity.Size = New Size(179, 31)
        nudQuantity.TabIndex = 8
        nudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' nudBonus
        ' 
        nudBonus.Location = New Point(57, 264)
        nudBonus.Minimum = New Decimal(New Integer() {100, 0, 0, Integer.MinValue})
        nudBonus.Name = "nudBonus"
        nudBonus.Size = New Size(180, 31)
        nudBonus.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(56, 227)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 25)
        Label1.TabIndex = 10
        Label1.Text = "Insert bonus:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(630, 450)
        Controls.Add(Label1)
        Controls.Add(nudBonus)
        Controls.Add(nudQuantity)
        Controls.Add(btnRoll)
        Controls.Add(lblQuantity)
        Controls.Add(lblDice)
        Controls.Add(cbxDices)
        Controls.Add(btnClear)
        Controls.Add(lblResults)
        Controls.Add(txtResults)
        Name = "Form1"
        Text = "RPG Dice Set"
        CType(nudQuantity, ComponentModel.ISupportInitialize).EndInit()
        CType(nudBonus, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtResults As TextBox
    Friend WithEvents lblResults As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents cbxDices As ComboBox
    Friend WithEvents lblDice As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents btnRoll As Button
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents nudBonus As NumericUpDown
    Friend WithEvents Label1 As Label
End Class
