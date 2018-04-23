<!DOCTYPE HTML>

<html>
<head>
    <title>@ViewBag.Title</title>

    <script src="@Url.Content("~/Scripts/jquery-1.6.2.min.js")" type="text/javascript"></script>
@Html.DevExpress().GetStyleSheets(New StyleSheet With {.ExtensionSuite = ExtensionSuite.GridView})
@Html.DevExpress().GetScripts(New Script With {.ExtensionSuite = ExtensionSuite.GridView})
</head>

<body>
	@RenderBody()
</body>
</html>