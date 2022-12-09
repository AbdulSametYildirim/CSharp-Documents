<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="giris.aspx.cs" Inherits="EnglishWords.giris" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="row">

        <div class="col-3"></div>
         <div class="col-6">

             <div class="giris-yap">
      <asp:Label ID="lbl_mesaj" runat="server"></asp:Label>
      <br />
    <asp:Label ID="Label2" runat="server" Text="Kullanici Adi" CssClass="giris-yap-label"></asp:Label><asp:TextBox ID="txt_kadi" runat="server" Width="162px" CssClass="giris-yap-textbox"></asp:TextBox>
     <br />
    <asp:Label ID="Label1" runat="server" Text="Şifre"></asp:Label>
    <asp:TextBox ID="txt_sifre" runat="server" TextMode="Password" CssClass="giris-yap-textbox"></asp:TextBox>
     <br />
    <asp:Button ID="Button1" runat="server" Text="Giriş Yap" OnClick="Button1_Click" CssClass="giris-yap-buton"/>
    <br /></div>

         </div>
         <div class="col-3"></div>

    </div>




</asp:Content>
