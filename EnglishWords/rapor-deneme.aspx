<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="rapor-deneme.aspx.cs" Inherits="EnglishWords.rapor_deneme" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
    <rsweb:ReportViewer ID="ReportViewer2" runat="server" Height="116px">
    </rsweb:ReportViewer>
<rsweb:ReportViewer ID="ReportViewer1" runat="server" CssClass="auto-style1" style="margin-right: 363px; margin-bottom: 0px; background-color:white;" Width="763px" Height="529px" >
</rsweb:ReportViewer>


</asp:Content>
