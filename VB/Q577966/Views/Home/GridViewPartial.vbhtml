@Html.DevExpress().GridView(Sub(s)
                                s.Name = "grid"
                                s.Width = 200                                     
                                s.KeyFieldName = "ID"
                                s.CallbackRouteValues = New With {Key .Action = "GridViewPartial", Key .Controller = "Home"}
                                s.Settings.ShowStatusBar = GridViewStatusBarMode.Visible
                                s.Settings.VerticalScrollBarMode = ScrollBarMode.Auto
                                s.Styles.StatusBar.CssClass = "myStatusBar"
                                s.SetStatusBarTemplateContent(Html.Partial("StatusBar").ToHtmlString())
                            End Sub
).Bind(Enumerable.Range(0, 103).Select(Function(i) New With {Key .ID = i, Key .Name = "Name" & i, Key .Description = "Description" & i})).GetHtml()