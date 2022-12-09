<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="admin-kelime-ekle.aspx.cs" Inherits="EnglishWords.admin_kelime_ekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="kelime-ekle">
          <asp:Label ID="lbl_mesaj" runat="server"></asp:Label>
      <br /><br />
    <asp:Label ID="Label2" runat="server" Text="Kelime" CssClass="giris-yap-label"></asp:Label><asp:TextBox ID="txt_kelime" runat="server" Width="162px" CssClass="giris-yap-textbox"></asp:TextBox>
     <br /><br />
    <asp:Label ID="Label1" runat="server" Text="Cevap1"></asp:Label>
    <asp:TextBox ID="txt_cevap1" runat="server" CssClass="giris-yap-textbox"></asp:TextBox>
     <br /><br />
         <asp:Label ID="Label3" runat="server" Text="Cevap2"></asp:Label>
    <asp:TextBox ID="txt_cevap2" runat="server" CssClass="giris-yap-textbox"></asp:TextBox>
     <br /><br />
         <asp:Label ID="Label4" runat="server" Text="Cevap3"></asp:Label>
    <asp:TextBox ID="txt_cevap3" runat="server" CssClass="giris-yap-textbox"></asp:TextBox>
     <br />
         <br />
         <asp:Label ID="Label5" runat="server" Text="Cevap4"></asp:Label>
    <asp:TextBox ID="txt_cevap4" runat="server" CssClass="giris-yap-textbox"></asp:TextBox>
     <br />
        <br />
        
         <asp:Label ID="Label6" runat="server" Text="Doğru Cevap"></asp:Label>
    <asp:TextBox ID="txt_dogru_cevap" runat="server" CssClass="giris-yap-textbox"></asp:TextBox>
     <br />
        <br />




    <asp:Button ID="Button1" runat="server" Text="Kelimeyi Kaydet" OnClick="Button1_Click" CssClass="giris-yap-buton"/>
    <br />
    </div>


</asp:Content>
