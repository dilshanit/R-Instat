﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimaticCheckDataTemperature
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgClimaticCheckDataTemperature))
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblElement1 = New System.Windows.Forms.Label()
        Me.lblRangeElement1 = New System.Windows.Forms.Label()
        Me.lblRangeElement2 = New System.Windows.Forms.Label()
        Me.lblRangeElement1to = New System.Windows.Forms.Label()
        Me.lblRangeElement2to = New System.Windows.Forms.Label()
        Me.lblJumpElement1 = New System.Windows.Forms.Label()
        Me.lblJumpElement2 = New System.Windows.Forms.Label()
        Me.lblElement2 = New System.Windows.Forms.Label()
        Me.ucrReceiverElement2 = New instat.ucrReceiverSingle()
        Me.ucrNudJumpElement2 = New instat.ucrNud()
        Me.ucrNudJumpElement1 = New instat.ucrNud()
        Me.ucrChkRange = New instat.ucrCheck()
        Me.ucrNudSame = New instat.ucrNud()
        Me.ucrNudDifference = New instat.ucrNud()
        Me.ucrNudOutlier = New instat.ucrNud()
        Me.ucrNudRangeElement2Max = New instat.ucrNud()
        Me.ucrChkOutlier = New instat.ucrCheck()
        Me.ucrNudRangeElement2Min = New instat.ucrNud()
        Me.ucrNudRangeElement1Max = New instat.ucrNud()
        Me.ucrChkSame = New instat.ucrCheck()
        Me.ucrNudRangeElement1Min = New instat.ucrNud()
        Me.ucrChkJump = New instat.ucrCheck()
        Me.ucrChkDifference = New instat.ucrCheck()
        Me.ucrReceiverElement1 = New instat.ucrReceiverSingle()
        Me.ucrReceiverDay = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorTemperature = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblStation
        '
        resources.ApplyResources(Me.lblStation, "lblStation")
        Me.lblStation.Name = "lblStation"
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
        '
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.Name = "lblYear"
        '
        'lblMonth
        '
        resources.ApplyResources(Me.lblMonth, "lblMonth")
        Me.lblMonth.Name = "lblMonth"
        '
        'lblDay
        '
        resources.ApplyResources(Me.lblDay, "lblDay")
        Me.lblDay.Name = "lblDay"
        '
        'lblElement1
        '
        resources.ApplyResources(Me.lblElement1, "lblElement1")
        Me.lblElement1.Name = "lblElement1"
        '
        'lblRangeElement1
        '
        resources.ApplyResources(Me.lblRangeElement1, "lblRangeElement1")
        Me.lblRangeElement1.Name = "lblRangeElement1"
        '
        'lblRangeElement2
        '
        resources.ApplyResources(Me.lblRangeElement2, "lblRangeElement2")
        Me.lblRangeElement2.Name = "lblRangeElement2"
        '
        'lblRangeElement1to
        '
        resources.ApplyResources(Me.lblRangeElement1to, "lblRangeElement1to")
        Me.lblRangeElement1to.Name = "lblRangeElement1to"
        '
        'lblRangeElement2to
        '
        resources.ApplyResources(Me.lblRangeElement2to, "lblRangeElement2to")
        Me.lblRangeElement2to.Name = "lblRangeElement2to"
        '
        'lblJumpElement1
        '
        resources.ApplyResources(Me.lblJumpElement1, "lblJumpElement1")
        Me.lblJumpElement1.Name = "lblJumpElement1"
        '
        'lblJumpElement2
        '
        resources.ApplyResources(Me.lblJumpElement2, "lblJumpElement2")
        Me.lblJumpElement2.Name = "lblJumpElement2"
        '
        'lblElement2
        '
        resources.ApplyResources(Me.lblElement2, "lblElement2")
        Me.lblElement2.Name = "lblElement2"
        '
        'ucrReceiverElement2
        '
        Me.ucrReceiverElement2.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverElement2, "ucrReceiverElement2")
        Me.ucrReceiverElement2.Name = "ucrReceiverElement2"
        Me.ucrReceiverElement2.Selector = Nothing
        Me.ucrReceiverElement2.strNcFilePath = ""
        Me.ucrReceiverElement2.ucrSelector = Nothing
        '
        'ucrNudJumpElement2
        '
        Me.ucrNudJumpElement2.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudJumpElement2, "ucrNudJumpElement2")
        Me.ucrNudJumpElement2.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudJumpElement2.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudJumpElement2.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJumpElement2.Name = "ucrNudJumpElement2"
        Me.ucrNudJumpElement2.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudJumpElement1
        '
        Me.ucrNudJumpElement1.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJumpElement1.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudJumpElement1, "ucrNudJumpElement1")
        Me.ucrNudJumpElement1.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudJumpElement1.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJumpElement1.Name = "ucrNudJumpElement1"
        Me.ucrNudJumpElement1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkRange
        '
        Me.ucrChkRange.Checked = False
        resources.ApplyResources(Me.ucrChkRange, "ucrChkRange")
        Me.ucrChkRange.Name = "ucrChkRange"
        '
        'ucrNudSame
        '
        Me.ucrNudSame.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSame.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSame, "ucrNudSame")
        Me.ucrNudSame.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSame.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSame.Name = "ucrNudSame"
        Me.ucrNudSame.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDifference
        '
        Me.ucrNudDifference.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDifference.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudDifference, "ucrNudDifference")
        Me.ucrNudDifference.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDifference.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDifference.Name = "ucrNudDifference"
        Me.ucrNudDifference.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudOutlier
        '
        Me.ucrNudOutlier.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudOutlier, "ucrNudOutlier")
        Me.ucrNudOutlier.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudOutlier.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudOutlier.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudOutlier.Name = "ucrNudOutlier"
        Me.ucrNudOutlier.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudRangeElement2Max
        '
        Me.ucrNudRangeElement2Max.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudRangeElement2Max, "ucrNudRangeElement2Max")
        Me.ucrNudRangeElement2Max.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRangeElement2Max.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRangeElement2Max.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRangeElement2Max.Name = "ucrNudRangeElement2Max"
        Me.ucrNudRangeElement2Max.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkOutlier
        '
        Me.ucrChkOutlier.Checked = False
        resources.ApplyResources(Me.ucrChkOutlier, "ucrChkOutlier")
        Me.ucrChkOutlier.Name = "ucrChkOutlier"
        '
        'ucrNudRangeElement2Min
        '
        Me.ucrNudRangeElement2Min.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudRangeElement2Min, "ucrNudRangeElement2Min")
        Me.ucrNudRangeElement2Min.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRangeElement2Min.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRangeElement2Min.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRangeElement2Min.Name = "ucrNudRangeElement2Min"
        Me.ucrNudRangeElement2Min.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudRangeElement1Max
        '
        Me.ucrNudRangeElement1Max.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRangeElement1Max.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudRangeElement1Max, "ucrNudRangeElement1Max")
        Me.ucrNudRangeElement1Max.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRangeElement1Max.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRangeElement1Max.Name = "ucrNudRangeElement1Max"
        Me.ucrNudRangeElement1Max.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkSame
        '
        Me.ucrChkSame.Checked = False
        resources.ApplyResources(Me.ucrChkSame, "ucrChkSame")
        Me.ucrChkSame.Name = "ucrChkSame"
        '
        'ucrNudRangeElement1Min
        '
        Me.ucrNudRangeElement1Min.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRangeElement1Min.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudRangeElement1Min, "ucrNudRangeElement1Min")
        Me.ucrNudRangeElement1Min.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRangeElement1Min.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRangeElement1Min.Name = "ucrNudRangeElement1Min"
        Me.ucrNudRangeElement1Min.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkJump
        '
        Me.ucrChkJump.Checked = False
        resources.ApplyResources(Me.ucrChkJump, "ucrChkJump")
        Me.ucrChkJump.Name = "ucrChkJump"
        '
        'ucrChkDifference
        '
        Me.ucrChkDifference.Checked = False
        resources.ApplyResources(Me.ucrChkDifference, "ucrChkDifference")
        Me.ucrChkDifference.Name = "ucrChkDifference"
        '
        'ucrReceiverElement1
        '
        Me.ucrReceiverElement1.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverElement1, "ucrReceiverElement1")
        Me.ucrReceiverElement1.Name = "ucrReceiverElement1"
        Me.ucrReceiverElement1.Selector = Nothing
        Me.ucrReceiverElement1.strNcFilePath = ""
        Me.ucrReceiverElement1.ucrSelector = Nothing
        '
        'ucrReceiverDay
        '
        Me.ucrReceiverDay.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDay, "ucrReceiverDay")
        Me.ucrReceiverDay.Name = "ucrReceiverDay"
        Me.ucrReceiverDay.Selector = Nothing
        Me.ucrReceiverDay.strNcFilePath = ""
        Me.ucrReceiverDay.ucrSelector = Nothing
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMonth, "ucrReceiverMonth")
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverYear, "ucrReceiverYear")
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDate, "ucrReceiverDate")
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStation, "ucrReceiverStation")
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorTemperature
        '
        Me.ucrSelectorTemperature.bShowHiddenColumns = False
        Me.ucrSelectorTemperature.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorTemperature, "ucrSelectorTemperature")
        Me.ucrSelectorTemperature.Name = "ucrSelectorTemperature"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgClimaticCheckDataTemperature
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblElement2)
        Me.Controls.Add(Me.ucrReceiverElement2)
        Me.Controls.Add(Me.lblJumpElement1)
        Me.Controls.Add(Me.lblJumpElement2)
        Me.Controls.Add(Me.ucrNudJumpElement2)
        Me.Controls.Add(Me.ucrNudJumpElement1)
        Me.Controls.Add(Me.ucrChkRange)
        Me.Controls.Add(Me.lblRangeElement1to)
        Me.Controls.Add(Me.ucrNudSame)
        Me.Controls.Add(Me.lblRangeElement2to)
        Me.Controls.Add(Me.lblRangeElement1)
        Me.Controls.Add(Me.ucrNudDifference)
        Me.Controls.Add(Me.lblRangeElement2)
        Me.Controls.Add(Me.ucrNudOutlier)
        Me.Controls.Add(Me.ucrNudRangeElement2Max)
        Me.Controls.Add(Me.ucrChkOutlier)
        Me.Controls.Add(Me.ucrNudRangeElement2Min)
        Me.Controls.Add(Me.ucrNudRangeElement1Max)
        Me.Controls.Add(Me.ucrChkSame)
        Me.Controls.Add(Me.ucrNudRangeElement1Min)
        Me.Controls.Add(Me.ucrChkJump)
        Me.Controls.Add(Me.ucrChkDifference)
        Me.Controls.Add(Me.lblElement1)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverElement1)
        Me.Controls.Add(Me.ucrReceiverDay)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrSelectorTemperature)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticCheckDataTemperature"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorTemperature As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents lblElement1 As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverElement1 As ucrReceiverSingle
    Friend WithEvents ucrReceiverDay As ucrReceiverSingle
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrChkOutlier As ucrCheck
    Friend WithEvents ucrChkSame As ucrCheck
    Friend WithEvents ucrChkJump As ucrCheck
    Friend WithEvents ucrChkDifference As ucrCheck
    Friend WithEvents ucrNudSame As ucrNud
    Friend WithEvents ucrNudDifference As ucrNud
    Friend WithEvents ucrNudOutlier As ucrNud
    Friend WithEvents ucrNudRangeElement1Max As ucrNud
    Friend WithEvents ucrNudRangeElement1Min As ucrNud
    Friend WithEvents lblRangeElement1 As Label
    Friend WithEvents lblRangeElement2 As Label
    Friend WithEvents ucrNudRangeElement2Max As ucrNud
    Friend WithEvents ucrNudRangeElement2Min As ucrNud
    Friend WithEvents lblRangeElement1to As Label
    Friend WithEvents lblRangeElement2to As Label
    Friend WithEvents ucrChkRange As ucrCheck
    Friend WithEvents lblJumpElement1 As Label
    Friend WithEvents lblJumpElement2 As Label
    Friend WithEvents ucrNudJumpElement2 As ucrNud
    Friend WithEvents ucrNudJumpElement1 As ucrNud
    Friend WithEvents lblElement2 As Label
    Friend WithEvents ucrReceiverElement2 As ucrReceiverSingle
End Class
