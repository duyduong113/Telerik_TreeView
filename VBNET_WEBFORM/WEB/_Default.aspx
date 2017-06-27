<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="_Default.aspx.vb" Inherits="WEB._Default1" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

    <style>
        @-webkit-keyframes reding {
            0% {
                background-color: #ff0000;
                -webkit-box-shadow: 0 0 3px #ff0000;
            }

            50% {
                background-color: #c80000;
                -webkit-box-shadow: 0 0 10px #c80000;
            }

            100% {
                background-color: #ff0000;
                -webkit-box-shadow: 0 0 3px #ff0000;
            }
        }

        @-moz-keyframes reding {
            0% {
                background-color: #ff0000;
                -moz-box-shadow: 0 0 3px #ff0000;
            }

            50% {
                background-color: #c80000;
                -moz-box-shadow: 0 0 10px #c80000;
            }

            100% {
                background-color: #ff0000;
                -moz-box-shadow: 0 0 3px #ff0000;
            }
        }

        @-o-keyframes reding {
            0% {
                background-color: #ff0000;
                box-shadow: 0 0 3px #ff0000;
            }

            50% {
                background-color: #c80000;
                box-shadow: 0 0 10px #c80000;
            }

            100% {
                background-color: #ff0000;
                box-shadow: 0 0 3px #ff0000;
            }
        }

        @keyframes reding {
            0% {
                background-color: #ff0000;
                box-shadow: 0 0 3px #ff0000;
            }

            50% {
                background-color: #c80000;
                box-shadow: 0 0 10px #c80000;
            }

            100% {
                background-color: #ff0000;
                box-shadow: 0 0 3px #ff0000;
            }
        }

        .redline {
            -webkit-animation: reding 1500ms infinite;
            -moz-animation: reding 1500ms infinite;
            -o-animation: reding 1500ms infinite;
            animation: reding 1500ms infinite;
        }
    </style>

    <style>
        @-webkit-keyframes greening {
            0% {
                background-color: #00ff00;
                -webkit-box-shadow: 0 0 3px #00ff00;
            }

            50% {
                background-color: #00c800;
                -webkit-box-shadow: 0 0 10px #00c800;
            }

            100% {
                background-color: #00ff00;
                -webkit-box-shadow: 0 0 3px #00ff00;
            }
        }

        @-moz-keyframes greening {
            0% {
                background-color: #00ff00;
                -moz-box-shadow: 0 0 3px #00ff00;
            }

            50% {
                background-color: #00c800;
                -moz-box-shadow: 0 0 10px #00c800;
            }

            100% {
                background-color: #00ff00;
                -moz-box-shadow: 0 0 3px #00ff00;
            }
        }

        @-o-keyframes greening {
            0% {
                background-color: #00ff00;
                box-shadow: 0 0 3px #00ff00;
            }

            50% {
                background-color: #00c800;
                box-shadow: 0 0 10px #00c800;
            }

            100% {
                background-color: #00ff00;
                box-shadow: 0 0 3px #00ff00;
            }
        }

        @keyframes greening {
            0% {
                background-color: #00ff00;
                box-shadow: 0 0 3px #00ff00;
            }

            50% {
                background-color: #00c800;
                box-shadow: 0 0 10px #00c800;
            }

            100% {
                background-color: #00ff00;
                box-shadow: 0 0 3px #00ff00;
            }
        }

        .greenline {
            -webkit-animation: greening 1500ms infinite;
            -moz-animation: greening 1500ms infinite;
            -o-animation: greening 1500ms infinite;
            animation: greening 1500ms infinite;
        }
    </style>


    <style>
        @-webkit-keyframes swinging {
            0% {
                -webkit-transform: scale(0.5)  ;
            }

            50% {
                -webkit-transform: scale(1.0)
            }

            100% {
                -webkit-transform: scale(0.5) ;
            }
        }

        @keyframes swinging {
            0% {
                transform: scale(0.5) ;
            }

            50% {
                transform: scale(1.0) 
            }

            100% {
                transform: scale(0.5) ;
            }
        }

        .swingimage {
            position: relative;
            left: 0px;
            -webkit-transform-origin: 50% 0;
            transform-origin: 50% 0;
            -webkit-animation: swinging 3.5s ease-in-out forwards infinite;
            animation: swinging 3.5s ease-in-out forwards infinite;
        }

        .swingimageshift {
            position: relative;
            left: 50px;
            margin-top: 30px;
            -webkit-transform-origin: 35% 0;
            transform-origin: 35% 0;
            -webkit-animation: swinging 3.5s ease-in-out forwards infinite;
            animation: swinging 3.5s ease-in-out forwards infinite;
        }
    </style>



</head>
<body>
    <form id="form1" runat="server" lang="en" title="Demo">
        <telerik:RadSkinManager ID="RadSkinManager1" runat="server" />
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
            <Scripts>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js"></asp:ScriptReference>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js"></asp:ScriptReference>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js"></asp:ScriptReference>
            </Scripts>
        </telerik:RadScriptManager>
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        </telerik:RadAjaxManager>

        <div style="font-size: 50px; color: red; font-weight: bold; text-align: center;">
            Demo TreeView
        </div>

        <telerik:RadTreeView ID="RadTreeView" RenderMode="Lightweight" runat="server">
        </telerik:RadTreeView>

     





    </form>
</body>
</html>
