﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Web.Editors.ASPx
Imports IntAsEnumExample.Module.BusinessObjects
Imports DevExpress.ExpressApp.Model

Namespace IntAsEnumExample.Module.Web.Editors
	<PropertyEditor(GetType(Integer), False)> _
	Public Class ASPxMyEnumIntPropertyEditor
		Inherits ASPxEnumIntPropertyEditor(Of SampleEnum)
		Public Sub New(ByVal objectType As Type, ByVal model As IModelMemberViewItem)
			MyBase.New(objectType, model)
		End Sub
	End Class
End Namespace
