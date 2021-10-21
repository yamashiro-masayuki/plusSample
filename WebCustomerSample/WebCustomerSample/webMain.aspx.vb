﻿Public Class webMain
    Inherits System.Web.UI.Page

    'クラス宣言
    Dim common As commonCusData
    Dim fullName As String


    Sub New()
        fullName = "デバックモード"
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'クラスの宣言
        common = New commonCusData()

        '共通変数にログイン時の名前がなかったらエラーページに移行する。
        If common.LoginName = "" And common.CheckLogin Then
            'エラーページの表示
            Response.Redirect("~/webNotAccess.aspx")
        Else
            'デバックモードの時はloginNameにデバックモードを挿入
            common.LoginName = "デバックモード"
        End If

        lbl_LoginName.Text = $"{common.LoginName}さんようこそ"

    End Sub

    Protected Sub btn_AddCus_Click(sender As Object, e As EventArgs) Handles btn_AddCus.Click

        '顧客情報登録ページの表示
        Response.Redirect("~/webAddCus.aspx")

    End Sub

    Protected Sub btn_SerchCus_Click(sender As Object, e As EventArgs) Handles btn_SerchCus.Click

        '顧客情報検索・一覧表示ページの表示
        Response.Redirect("~/webSerchView.aspx")

    End Sub

End Class