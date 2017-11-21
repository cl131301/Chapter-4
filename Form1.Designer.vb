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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdOrangeSherbert = New System.Windows.Forms.RadioButton()
        Me.rdStrawberry = New System.Windows.Forms.RadioButton()
        Me.rdChocolate = New System.Windows.Forms.RadioButton()
        Me.rdVanilla = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkWhipCream = New System.Windows.Forms.CheckBox()
        Me.chkCarmel = New System.Windows.Forms.CheckBox()
        Me.chkHotFudge = New System.Windows.Forms.CheckBox()
        Me.chkSprinkles = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdCookie = New System.Windows.Forms.RadioButton()
        Me.rdCandyBar = New System.Windows.Forms.RadioButton()
        Me.rdExtraScoop = New System.Windows.Forms.RadioButton()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdOrangeSherbert)
        Me.GroupBox1.Controls.Add(Me.rdStrawberry)
        Me.GroupBox1.Controls.Add(Me.rdChocolate)
        Me.GroupBox1.Controls.Add(Me.rdVanilla)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 182)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selecet Ice Cream Flavor"
        '
        'rdOrangeSherbert
        '
        Me.rdOrangeSherbert.AutoSize = True
        Me.rdOrangeSherbert.Location = New System.Drawing.Point(26, 139)
        Me.rdOrangeSherbert.Name = "rdOrangeSherbert"
        Me.rdOrangeSherbert.Size = New System.Drawing.Size(103, 17)
        Me.rdOrangeSherbert.TabIndex = 3
        Me.rdOrangeSherbert.TabStop = True
        Me.rdOrangeSherbert.Text = "Orange Sherbert"
        Me.rdOrangeSherbert.UseVisualStyleBackColor = True
        '
        'rdStrawberry
        '
        Me.rdStrawberry.AutoSize = True
        Me.rdStrawberry.Location = New System.Drawing.Point(26, 105)
        Me.rdStrawberry.Name = "rdStrawberry"
        Me.rdStrawberry.Size = New System.Drawing.Size(75, 17)
        Me.rdStrawberry.TabIndex = 2
        Me.rdStrawberry.TabStop = True
        Me.rdStrawberry.Text = "Strawberry"
        Me.rdStrawberry.UseVisualStyleBackColor = True
        '
        'rdChocolate
        '
        Me.rdChocolate.AutoSize = True
        Me.rdChocolate.Location = New System.Drawing.Point(26, 67)
        Me.rdChocolate.Name = "rdChocolate"
        Me.rdChocolate.Size = New System.Drawing.Size(73, 17)
        Me.rdChocolate.TabIndex = 1
        Me.rdChocolate.TabStop = True
        Me.rdChocolate.Text = "Chocolate"
        Me.rdChocolate.UseVisualStyleBackColor = True
        '
        'rdVanilla
        '
        Me.rdVanilla.AutoSize = True
        Me.rdVanilla.Location = New System.Drawing.Point(26, 31)
        Me.rdVanilla.Name = "rdVanilla"
        Me.rdVanilla.Size = New System.Drawing.Size(56, 17)
        Me.rdVanilla.TabIndex = 0
        Me.rdVanilla.TabStop = True
        Me.rdVanilla.Text = "Vanilla"
        Me.rdVanilla.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkWhipCream)
        Me.GroupBox2.Controls.Add(Me.chkCarmel)
        Me.GroupBox2.Controls.Add(Me.chkHotFudge)
        Me.GroupBox2.Controls.Add(Me.chkSprinkles)
        Me.GroupBox2.Location = New System.Drawing.Point(302, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 182)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Toppings"
        '
        'chkWhipCream
        '
        Me.chkWhipCream.AutoSize = True
        Me.chkWhipCream.Location = New System.Drawing.Point(20, 140)
        Me.chkWhipCream.Name = "chkWhipCream"
        Me.chkWhipCream.Size = New System.Drawing.Size(84, 17)
        Me.chkWhipCream.TabIndex = 3
        Me.chkWhipCream.Text = "Whip Cream"
        Me.chkWhipCream.UseVisualStyleBackColor = True
        '
        'chkCarmel
        '
        Me.chkCarmel.AutoSize = True
        Me.chkCarmel.Location = New System.Drawing.Point(20, 105)
        Me.chkCarmel.Name = "chkCarmel"
        Me.chkCarmel.Size = New System.Drawing.Size(58, 17)
        Me.chkCarmel.TabIndex = 2
        Me.chkCarmel.Text = "Carmel"
        Me.chkCarmel.UseVisualStyleBackColor = True
        '
        'chkHotFudge
        '
        Me.chkHotFudge.AutoSize = True
        Me.chkHotFudge.Location = New System.Drawing.Point(20, 68)
        Me.chkHotFudge.Name = "chkHotFudge"
        Me.chkHotFudge.Size = New System.Drawing.Size(76, 17)
        Me.chkHotFudge.TabIndex = 1
        Me.chkHotFudge.Text = "Hot Fudge"
        Me.chkHotFudge.UseVisualStyleBackColor = True
        '
        'chkSprinkles
        '
        Me.chkSprinkles.AutoSize = True
        Me.chkSprinkles.Location = New System.Drawing.Point(20, 32)
        Me.chkSprinkles.Name = "chkSprinkles"
        Me.chkSprinkles.Size = New System.Drawing.Size(69, 17)
        Me.chkSprinkles.TabIndex = 0
        Me.chkSprinkles.Text = "Sprinkles"
        Me.chkSprinkles.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdCookie)
        Me.GroupBox3.Controls.Add(Me.rdCandyBar)
        Me.GroupBox3.Controls.Add(Me.rdExtraScoop)
        Me.GroupBox3.Location = New System.Drawing.Point(302, 234)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 114)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Side Order"
        '
        'rdCookie
        '
        Me.rdCookie.AutoSize = True
        Me.rdCookie.Location = New System.Drawing.Point(20, 81)
        Me.rdCookie.Name = "rdCookie"
        Me.rdCookie.Size = New System.Drawing.Size(58, 17)
        Me.rdCookie.TabIndex = 2
        Me.rdCookie.TabStop = True
        Me.rdCookie.Text = "Cookie"
        Me.rdCookie.UseVisualStyleBackColor = True
        '
        'rdCandyBar
        '
        Me.rdCandyBar.AutoSize = True
        Me.rdCandyBar.Location = New System.Drawing.Point(20, 58)
        Me.rdCandyBar.Name = "rdCandyBar"
        Me.rdCandyBar.Size = New System.Drawing.Size(74, 17)
        Me.rdCandyBar.TabIndex = 1
        Me.rdCandyBar.TabStop = True
        Me.rdCandyBar.Text = "Candy Bar"
        Me.rdCandyBar.UseVisualStyleBackColor = True
        '
        'rdExtraScoop
        '
        Me.rdExtraScoop.AutoSize = True
        Me.rdExtraScoop.Location = New System.Drawing.Point(20, 35)
        Me.rdExtraScoop.Name = "rdExtraScoop"
        Me.rdExtraScoop.Size = New System.Drawing.Size(83, 17)
        Me.rdExtraScoop.TabIndex = 0
        Me.rdExtraScoop.TabStop = True
        Me.rdExtraScoop.Text = "Extra Scoop"
        Me.rdExtraScoop.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(40, 234)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(212, 23)
        Me.btnEnter.TabIndex = 3
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(37, 260)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(224, 61)
        Me.lblResult.TabIndex = 4
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(37, 332)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(224, 40)
        Me.lblTotal.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 381)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Resurant Order Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdOrangeSherbert As System.Windows.Forms.RadioButton
    Friend WithEvents rdStrawberry As System.Windows.Forms.RadioButton
    Friend WithEvents rdChocolate As System.Windows.Forms.RadioButton
    Friend WithEvents rdVanilla As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkWhipCream As System.Windows.Forms.CheckBox
    Friend WithEvents chkCarmel As System.Windows.Forms.CheckBox
    Friend WithEvents chkHotFudge As System.Windows.Forms.CheckBox
    Friend WithEvents chkSprinkles As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdCookie As System.Windows.Forms.RadioButton
    Friend WithEvents rdCandyBar As System.Windows.Forms.RadioButton
    Friend WithEvents rdExtraScoop As System.Windows.Forms.RadioButton
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class
