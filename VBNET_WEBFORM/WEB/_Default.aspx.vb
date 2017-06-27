Imports Telerik.Web.UI

Public Class _Default1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then

            'insert node into radtreeview
            'For i As Integer = 0 To 4
            '    Dim root1 As New RadTreeNode("Root " + i.ToString())
            '    root1.Attributes.Add("Text", "Value")
            '    RadTreeView.Nodes.Add(root1)
            '    For j As Integer = 0 To 4
            '        Dim subroot1 As New RadTreeNode("Node" + j.ToString())
            '        subroot1.Attributes.Add("Text", "Value")
            '        root1.Nodes.Add(subroot1)
            '    Next
            'Next

            '



            Dim list As List(Of TREEVIEW) = New List(Of TREEVIEW)
            list.Add(New TREEVIEW("https://nhaccuatui.com", "Switch 1", True, "https://daa.uit.edu.vn", "Machine 1", True, True, False, "https://mp3.zing.vn", "Computer 1", 1, Nothing, 0))
            list.Add(New TREEVIEW("https://nhaccuatui.com", "Switch 2", False, "https://daa.uit.edu.vn", "Machine 2", False, True, True, "https://mp3.zing.vn", "Computer 2", 2, Nothing, 0))
            list.Add(New TREEVIEW("https://nhaccuatui.com", "Switch 3", True, "https://daa.uit.edu.vn", "Machine 3", True, False, False, "https://mp3.zing.vn", "Computer 3", 3, 1, 103))
            list.Add(New TREEVIEW("https://nhaccuatui.com", "Switch 4", True, "https://daa.uit.edu.vn", "Machine 4", True, False, False, "https://mp3.zing.vn", "Computer 4", 4, 1, 104))
            list.Add(New TREEVIEW("https://nhaccuatui.com", "Switch 5", True, "https://daa.uit.edu.vn", "Machine 5", False, True, True, "https://mp3.zing.vn", "Computer 5", 5, 2, 105))
            list.Add(New TREEVIEW("https://nhaccuatui.com", "Switch 6", False, "https://daa.uit.edu.vn", "Machine 6", True, False, False, "https://mp3.zing.vn", "Computer 6", 6, 2, 106))
            list.Add(New TREEVIEW("https://nhaccuatui.com", "Switch 7", True, "https://daa.uit.edu.vn", "Machine 7", True, False, True, "https://mp3.zing.vn", "Computer 7", 7, 2, 107))
            list.Add(New TREEVIEW("https://nhaccuatui.com", "Switch 8", False, "https://daa.uit.edu.vn", "Machine 8", False, True, False, "https://mp3.zing.vn", "Computer 8", 8, 2, 108))
            list.Add(New TREEVIEW("https://nhaccuatui.com", "Switch 9", True, "https://daa.uit.edu.vn", "Machine 9", True, False, True, "https://mp3.zing.vn", "Computer 9", 9, 3, 109))
            list.Add(New TREEVIEW("https://nhaccuatui.com", "Switch 10", False, "https://daa.uit.edu.vn", "Machine 10", True, False, False, "https://mp3.zing.vn", "Computer 10", 10, 3, 110))
            list.Add(New TREEVIEW("https://nhaccuatui.com", "Switch 10", True, "https://daa.uit.edu.vn", "Machine 11", True, False, False, "https://mp3.zing.vn", "Computer 11", 10, 3, 111))

            'insert node into radtreeview1

            RadTreeView.DataSource = list
            RadTreeView.DataFieldID = "SwitchID"
            RadTreeView.DataFieldParentID = "ParentSwitchID"
            'RadTreeView.DataFieldParentID = "ComputerID"

            'RadTreeView.DataTextField = "Text"
            'RadTreeView.DataTextField = getText("LinkMachine", "Machine", True, "LinkComputer", "Computer")
            RadTreeView.DataBind()
            RadTreeView.ExpandAllNodes()


        End If

    End Sub


    Public Function getText(_linkSwitch As String, _switch As String, _statusSwitch As Boolean, _linkMachine As String, _machine As String, _statusLine As Boolean, _statusMachine As Boolean, _statusComputer As Boolean, _linkComputer As String, _computer As String, _switchID As Integer, _parentSwitchID As Integer, _computerID As Integer)
        Dim result As String = ""
        Dim strline As String = ""
        Dim strcomputer As String = ""
        Dim strMachine As String = ""
        Dim strSwitch As String = ""

        If _switchID Mod 2 = 0 Then
            If _statusSwitch Then
                strSwitch = "<a class='label label-info' style='float:left' href='" + _linkSwitch + "' target='_blank'><img class='swingimage' src='Images/Network-icon.gif'  />&nbsp" + _switch + "</a>"
            Else
                strSwitch = "<a class='label label-info' style='float:left' href='" + _linkSwitch + "' target='_blank'><img src='Images/Network-icon.gif'  />&nbsp" + _switch + "</a>"
            End If

            result = strSwitch
        Else
            If _statusMachine Then
                strcomputer = "<a class='label label-info' style='float:left' href='" + _linkComputer + "' target='_blank'><img class='swingimage' src='Images/Computer-icon.png'  />&nbsp" + _computer + "</a>"
            Else
                strcomputer = "<a class='label label-info' style='float:left' href='" + _linkComputer + "' target='_blank'><img src='Images/Computer-icon.png'  />&nbsp" + _computer + "</a>"
            End If

            If _statusComputer Then
                strMachine = "<a class='label label-info' style='float:left' href='" + _linkMachine + "' target='_blank'><img class='swingimage' src='Images/Machine-icon.png' />&nbsp" + _machine + "</a>"
            Else
                strMachine = "<a class='label label-info' style='float:left' href='" + _linkMachine + "' target='_blank'><img class='imgzoom' src='Images/Machine-icon.png' />&nbsp" + _machine + "</a>"
            End If

            If _statusLine Then
                strline = "<p class='greenline' style='float:left;width:150px; margin-top:15px;height:3px;' >&nbsp</p>"
            Else
                strline = "<p class='redline' style='float:left;width:150px; margin-top:15px;height:3px;' >&nbsp</p>"
            End If

            result = strcomputer + strline + strMachine
        End If

        Return result
    End Function


    Public Class TREEVIEW
        Public Sub New(LinkSwitch As String, Switch As String, StatusSwitch As Boolean, LinkMachine As String, Machine As String, StatusLine As Boolean, StatusMachine As Boolean, StatusComputer As Boolean, LinkComputer As String, Computer As String, SwitchID As Integer, ParentSwitchID As Integer, ComputerID As Integer)
            _linkSwitch = LinkSwitch
            _switch = Switch
            _statusSwitch = StatusSwitch
            _linkMachine = LinkMachine
            _machine = Machine
            _statusLine = StatusLine
            _statusMachine = StatusMachine
            _statusComputer = StatusComputer
            _linkComputer = LinkComputer
            _computer = Computer
            _switchID = SwitchID
            _parentSwitchID = ParentSwitchID
            _computerID = ComputerID
        End Sub

        Private _linkSwitch As String
        Public Property LinkSwitch() As String
            Get
                Return _linkSwitch
            End Get
            Set(value As String)
                _linkSwitch = value
            End Set
        End Property
        Private _switch As String
        Public Property Switch() As String
            Get
                Return _switch
            End Get
            Set(value As String)
                _switch = value
            End Set
        End Property
        Private _statusSwitch As Boolean
        Public Property StatusSwitch() As Boolean
            Get
                Return _statusSwitch
            End Get
            Set(value As Boolean)
                _statusSwitch = value
            End Set
        End Property
        Private _linkMachine As String
        Public Property LinkMachine() As String
            Get
                Return _linkMachine
            End Get
            Set(value As String)
                _linkMachine = value
            End Set
        End Property
        Private _machine As String
        Public Property Machine() As String
            Get
                Return _machine
            End Get
            Set(value As String)
                _machine = value
            End Set
        End Property
        Private _statusLine As Boolean
        Public Property StatusLine() As Boolean
            Get
                Return _statusLine
            End Get
            Set(value As Boolean)
                _statusLine = value
            End Set
        End Property
        Private _statusMachine As Boolean
        Public Property StatusMachine() As Boolean
            Get
                Return _statusMachine
            End Get
            Set(value As Boolean)
                _statusMachine = value
            End Set
        End Property
        Private _statusComputer As Boolean
        Public Property StatusComputer() As Boolean
            Get
                Return _statusComputer
            End Get
            Set(value As Boolean)
                _statusComputer = value
            End Set
        End Property
        Private _linkComputer As String
        Public Property LinkComputer() As String
            Get
                Return _linkComputer
            End Get
            Set(value As String)
                _linkComputer = value
            End Set
        End Property
        Private _computer As String
        Public Property Computer() As String
            Get
                Return _computer
            End Get
            Set(value As String)
                _computer = value
            End Set
        End Property

        Private _switchID As Integer
        Public Property SwitchID() As Integer
            Get
                Return _switchID
            End Get
            Set(value As Integer)
                _switchID = value
            End Set
        End Property
        Private _parentSwitchID As Integer
        Public Property ParentSwitchID() As Integer
            Get
                Return _parentSwitchID
            End Get
            Set(value As Integer)
                _parentSwitchID = value
            End Set
        End Property

        Private _computerID As Integer
        Public Property ComputerID() As Integer
            Get
                Return _computerID
            End Get
            Set(value As Integer)
                _computerID = value
            End Set
        End Property
    End Class

    Protected Sub RadTreeView_NodeDataBound(sender As Object, e As RadTreeNodeEventArgs) Handles RadTreeView.NodeDataBound
        e.Node.Text = getText(TryCast(e.Node.DataItem, TREEVIEW).LinkSwitch, TryCast(e.Node.DataItem, TREEVIEW).Switch, TryCast(e.Node.DataItem, TREEVIEW).StatusSwitch, TryCast(e.Node.DataItem, TREEVIEW).LinkMachine, TryCast(e.Node.DataItem, TREEVIEW).Machine, TryCast(e.Node.DataItem, TREEVIEW).StatusLine, TryCast(e.Node.DataItem, TREEVIEW).StatusMachine, TryCast(e.Node.DataItem, TREEVIEW).StatusComputer, TryCast(e.Node.DataItem, TREEVIEW).LinkComputer, TryCast(e.Node.DataItem, TREEVIEW).Computer, TryCast(e.Node.DataItem, TREEVIEW).SwitchID, TryCast(e.Node.DataItem, TREEVIEW).ParentSwitchID, TryCast(e.Node.DataItem, TREEVIEW).ComputerID)
        e.Node.ToolTip = TryCast(e.Node.DataItem, TREEVIEW).Switch + TryCast(e.Node.DataItem, TREEVIEW).Computer + TryCast(e.Node.DataItem, TREEVIEW).Machine
    End Sub

End Class