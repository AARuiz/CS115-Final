﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimsList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimsList))
        Me.picDoggie = New System.Windows.Forms.PictureBox()
        Me.lblTimsList = New System.Windows.Forms.Label()
        Me.cmbCategorySelect = New System.Windows.Forms.ComboBox()
        Me.lblCategorySelect = New System.Windows.Forms.Label()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblPriceRange = New System.Windows.Forms.Label()
        Me.lblDash = New System.Windows.Forms.Label()
        Me.btnFindIt = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.cmbSortOrder = New System.Windows.Forms.ComboBox()
        Me.rtbTest = New System.Windows.Forms.RichTextBox()
        Me.lvwTest = New System.Windows.Forms.ListView()
        Me.pnlAd = New System.Windows.Forms.Panel()
        Me.llbBack = New System.Windows.Forms.LinkLabel()
        Me.lblAdItem = New System.Windows.Forms.Label()
        Me.picAdPicture = New System.Windows.Forms.PictureBox()
        Me.rtbAdText = New System.Windows.Forms.RichTextBox()
        Me.picComputer = New System.Windows.Forms.PictureBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblSortBy = New System.Windows.Forms.Label()
        CType(Me.picDoggie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
        Me.pnlAd.SuspendLayout()
        CType(Me.picAdPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picDoggie
        '
        Me.picDoggie.Image = CType(resources.GetObject("picDoggie.Image"), System.Drawing.Image)
        Me.picDoggie.Location = New System.Drawing.Point(12, 12)
        Me.picDoggie.Name = "picDoggie"
        Me.picDoggie.Size = New System.Drawing.Size(45, 46)
        Me.picDoggie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDoggie.TabIndex = 0
        Me.picDoggie.TabStop = False
        '
        'lblTimsList
        '
        Me.lblTimsList.AutoSize = True
        Me.lblTimsList.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimsList.ForeColor = System.Drawing.Color.Black
        Me.lblTimsList.Location = New System.Drawing.Point(63, 12)
        Me.lblTimsList.Name = "lblTimsList"
        Me.lblTimsList.Size = New System.Drawing.Size(158, 45)
        Me.lblTimsList.TabIndex = 1
        Me.lblTimsList.Text = "Tim's List"
        '
        'cmbCategorySelect
        '
        Me.cmbCategorySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategorySelect.Items.AddRange(New Object() {"Automobiles", "Cellular Phones", "Farm/Garden", "Furniture", "Laptop Computers", "Sporting"})
        Me.cmbCategorySelect.Location = New System.Drawing.Point(3, 22)
        Me.cmbCategorySelect.Name = "cmbCategorySelect"
        Me.cmbCategorySelect.Size = New System.Drawing.Size(205, 21)
        Me.cmbCategorySelect.TabIndex = 3
        '
        'lblCategorySelect
        '
        Me.lblCategorySelect.AutoSize = True
        Me.lblCategorySelect.Location = New System.Drawing.Point(3, 6)
        Me.lblCategorySelect.Name = "lblCategorySelect"
        Me.lblCategorySelect.Size = New System.Drawing.Size(85, 13)
        Me.lblCategorySelect.TabIndex = 4
        Me.lblCategorySelect.Text = "Select Category:"
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(301, 22)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(72, 20)
        Me.txtMin.TabIndex = 5
        Me.txtMin.Text = "Min"
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(408, 22)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(71, 20)
        Me.txtMax.TabIndex = 6
        Me.txtMax.Text = "Max"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(313, 6)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(48, 13)
        Me.lblMin.TabIndex = 7
        Me.lblMin.Text = "Minimum"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(417, 5)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(51, 13)
        Me.lblMax.TabIndex = 8
        Me.lblMax.Text = "Maximum"
        '
        'lblPriceRange
        '
        Me.lblPriceRange.AutoSize = True
        Me.lblPriceRange.Location = New System.Drawing.Point(214, 25)
        Me.lblPriceRange.Name = "lblPriceRange"
        Me.lblPriceRange.Size = New System.Drawing.Size(81, 13)
        Me.lblPriceRange.TabIndex = 9
        Me.lblPriceRange.Text = "Price Range:  $"
        '
        'lblDash
        '
        Me.lblDash.AutoSize = True
        Me.lblDash.Location = New System.Drawing.Point(379, 25)
        Me.lblDash.Name = "lblDash"
        Me.lblDash.Size = New System.Drawing.Size(25, 13)
        Me.lblDash.TabIndex = 10
        Me.lblDash.Text = "—  $"
        '
        'btnFindIt
        '
        Me.btnFindIt.Location = New System.Drawing.Point(493, 20)
        Me.btnFindIt.Name = "btnFindIt"
        Me.btnFindIt.Size = New System.Drawing.Size(75, 23)
        Me.btnFindIt.TabIndex = 12
        Me.btnFindIt.Text = "&Find It"
        Me.btnFindIt.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(574, 20)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "&Clear Entires"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.DarkTurquoise
        Me.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSearch.Controls.Add(Me.lblSortBy)
        Me.pnlSearch.Controls.Add(Me.btnReset)
        Me.pnlSearch.Controls.Add(Me.cmbSortOrder)
        Me.pnlSearch.Controls.Add(Me.cmbCategorySelect)
        Me.pnlSearch.Controls.Add(Me.btnClear)
        Me.pnlSearch.Controls.Add(Me.lblCategorySelect)
        Me.pnlSearch.Controls.Add(Me.btnFindIt)
        Me.pnlSearch.Controls.Add(Me.txtMin)
        Me.pnlSearch.Controls.Add(Me.txtMax)
        Me.pnlSearch.Controls.Add(Me.lblDash)
        Me.pnlSearch.Controls.Add(Me.lblMin)
        Me.pnlSearch.Controls.Add(Me.lblPriceRange)
        Me.pnlSearch.Controls.Add(Me.lblMax)
        Me.pnlSearch.Location = New System.Drawing.Point(12, 64)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(994, 59)
        Me.pnlSearch.TabIndex = 14
        '
        'cmbSortOrder
        '
        Me.cmbSortOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSortOrder.FormattingEnabled = True
        Me.cmbSortOrder.Items.AddRange(New Object() {"Item Name (A-Z)", "Item Name (Z-A)", "Category (A-Z)", "Category (Z-A)", "Price (Low to High)", "Price (High to Low)"})
        Me.cmbSortOrder.Location = New System.Drawing.Point(702, 22)
        Me.cmbSortOrder.Name = "cmbSortOrder"
        Me.cmbSortOrder.Size = New System.Drawing.Size(188, 21)
        Me.cmbSortOrder.TabIndex = 14
        '
        'rtbTest
        '
        Me.rtbTest.BackColor = System.Drawing.Color.Orange
        Me.rtbTest.Location = New System.Drawing.Point(438, 12)
        Me.rtbTest.Name = "rtbTest"
        Me.rtbTest.ReadOnly = True
        Me.rtbTest.Size = New System.Drawing.Size(568, 43)
        Me.rtbTest.TabIndex = 20
        Me.rtbTest.Text = "Used to output different debugging information. Will not be included in final rel" & _
            "ease. Or it could be turned into a scrolling marquee of our names :P"
        '
        'lvwTest
        '
        Me.lvwTest.BackColor = System.Drawing.Color.Bisque
        Me.lvwTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwTest.FullRowSelect = True
        Me.lvwTest.GridLines = True
        Me.lvwTest.LabelWrap = False
        Me.lvwTest.Location = New System.Drawing.Point(12, 129)
        Me.lvwTest.MultiSelect = False
        Me.lvwTest.Name = "lvwTest"
        Me.lvwTest.Size = New System.Drawing.Size(994, 578)
        Me.lvwTest.TabIndex = 21
        Me.lvwTest.UseCompatibleStateImageBehavior = False
        Me.lvwTest.View = System.Windows.Forms.View.Details
        '
        'pnlAd
        '
        Me.pnlAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAd.Controls.Add(Me.llbBack)
        Me.pnlAd.Controls.Add(Me.lblAdItem)
        Me.pnlAd.Controls.Add(Me.picAdPicture)
        Me.pnlAd.Controls.Add(Me.rtbAdText)
        Me.pnlAd.Location = New System.Drawing.Point(110, 186)
        Me.pnlAd.Name = "pnlAd"
        Me.pnlAd.Size = New System.Drawing.Size(836, 508)
        Me.pnlAd.TabIndex = 26
        '
        'llbBack
        '
        Me.llbBack.AutoSize = True
        Me.llbBack.Location = New System.Drawing.Point(761, 8)
        Me.llbBack.Name = "llbBack"
        Me.llbBack.Size = New System.Drawing.Size(67, 13)
        Me.llbBack.TabIndex = 3
        Me.llbBack.TabStop = True
        Me.llbBack.Text = "<<  Go Back"
        '
        'lblAdItem
        '
        Me.lblAdItem.AutoSize = True
        Me.lblAdItem.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdItem.Location = New System.Drawing.Point(34, 0)
        Me.lblAdItem.Name = "lblAdItem"
        Me.lblAdItem.Size = New System.Drawing.Size(297, 45)
        Me.lblAdItem.TabIndex = 2
        Me.lblAdItem.Text = "Temporary Text"
        '
        'picAdPicture
        '
        Me.picAdPicture.Location = New System.Drawing.Point(30, 48)
        Me.picAdPicture.Name = "picAdPicture"
        Me.picAdPicture.Size = New System.Drawing.Size(351, 331)
        Me.picAdPicture.TabIndex = 1
        Me.picAdPicture.TabStop = False
        '
        'rtbAdText
        '
        Me.rtbAdText.BackColor = System.Drawing.SystemColors.Window
        Me.rtbAdText.Location = New System.Drawing.Point(440, 48)
        Me.rtbAdText.Name = "rtbAdText"
        Me.rtbAdText.Size = New System.Drawing.Size(377, 425)
        Me.rtbAdText.TabIndex = 0
        Me.rtbAdText.Text = ""
        '
        'picComputer
        '
        Me.picComputer.Image = CType(resources.GetObject("picComputer.Image"), System.Drawing.Image)
        Me.picComputer.Location = New System.Drawing.Point(216, 12)
        Me.picComputer.Name = "picComputer"
        Me.picComputer.Size = New System.Drawing.Size(54, 50)
        Me.picComputer.TabIndex = 27
        Me.picComputer.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(896, 20)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(84, 23)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Reset Sorting"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblSortBy
        '
        Me.lblSortBy.AutoSize = True
        Me.lblSortBy.Location = New System.Drawing.Point(699, 6)
        Me.lblSortBy.Name = "lblSortBy"
        Me.lblSortBy.Size = New System.Drawing.Size(44, 13)
        Me.lblSortBy.TabIndex = 16
        Me.lblSortBy.Text = "Sort By:"
        '
        'frmTimsList
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1018, 706)
        Me.Controls.Add(Me.picComputer)
        Me.Controls.Add(Me.pnlAd)
        Me.Controls.Add(Me.rtbTest)
        Me.Controls.Add(Me.lvwTest)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.lblTimsList)
        Me.Controls.Add(Me.picDoggie)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTimsList"
        Me.Text = "Our Tim's List Project"
        CType(Me.picDoggie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.pnlAd.ResumeLayout(False)
        Me.pnlAd.PerformLayout()
        CType(Me.picAdPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComputer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picDoggie As System.Windows.Forms.PictureBox
    Friend WithEvents lblTimsList As System.Windows.Forms.Label
    Friend WithEvents cmbCategorySelect As System.Windows.Forms.ComboBox
    Friend WithEvents lblCategorySelect As System.Windows.Forms.Label
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents txtMax As System.Windows.Forms.TextBox
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents lblPriceRange As System.Windows.Forms.Label
    Friend WithEvents lblDash As System.Windows.Forms.Label
    Friend WithEvents btnFindIt As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents rtbTest As System.Windows.Forms.RichTextBox
    Friend WithEvents lvwTest As System.Windows.Forms.ListView
    Friend WithEvents pnlAd As System.Windows.Forms.Panel
    Friend WithEvents lblAdItem As System.Windows.Forms.Label
    Friend WithEvents picAdPicture As System.Windows.Forms.PictureBox
    Friend WithEvents rtbAdText As System.Windows.Forms.RichTextBox
    Friend WithEvents llbBack As System.Windows.Forms.LinkLabel
    Friend WithEvents cmbSortOrder As System.Windows.Forms.ComboBox
    Friend WithEvents picComputer As System.Windows.Forms.PictureBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblSortBy As System.Windows.Forms.Label

End Class
