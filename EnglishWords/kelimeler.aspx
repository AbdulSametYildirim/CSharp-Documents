<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="kelimeler.aspx.cs" Inherits="EnglishWords.kelimeler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="row">


    <div class="col-3"></div>
    <div class="col-6">

         <div class="kelimeler-kutusu">
              <div class="kelimeler-baslik">Toplam Puan: <asp:Label ID="lbl_puan" runat="server"></asp:Label>
                  <asp:Label ID="lbl_dmesajim" runat="server" style="float: right; color: #0bf91d;" Text="Merhaba"></asp:Label>
                  <asp:Label ID="lbl_ymesajim" runat="server" style="float: right; color: red;" Text="Yanlış Cevap"></asp:Label>
              </div>
               <div class="kelimeler-soru"><asp:Label ID="lbl_soru" runat="server"></asp:Label>
              </div>
              <div class="row">
                  <div class="kelimeler-cevap1"><asp:Button ID="btn_cevap1" runat="server" Text="Cevap1" OnClick="btn_cevap1_Click" /></div>
                  <div class="kelimeler-cevap2"><asp:Button ID="btn_cevap2" runat="server" Text="Cevap2" OnClick="btn_cevap2_Click1" />
                  </div>

              </div>
                    <div class="row">
                  <div class="kelimeler-cevap3"><asp:Button ID="btn_cevap3" runat="server" Text="Cevap3" OnClick="btn_cevap3_Click1" /></div>
                  <div class="kelimeler-cevap4"><asp:Button ID="btn_cevap4" runat="server" Text="Cevap4" OnClick="btn_cevap4_Click1" /></div>
              </div>

              <div class="kelimeler-gonder"><asp:Button ID="btn_yeni" runat="server" Text="Başka Soru" OnClick="btn_yeni_Click" /></div>
               
          </div>
    </div>
 	<div class="col-3"></div>
</div>
</asp:Content>
