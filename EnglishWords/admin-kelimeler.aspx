<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="admin-kelimeler.aspx.cs" Inherits="EnglishWords.admin_kelimeler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <br>  <br> <h3 class="h3-admin-2"><a href="admin-kelime-ekle.aspx">Kelime Ekle</a></h3>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="word_id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" AllowPaging="True" AllowSorting="True" PageSize="5">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="word_id" HeaderText="Kelime id" InsertVisible="False" ReadOnly="True" SortExpression="word_id" />
                <asp:BoundField DataField="word_ing" HeaderText="Kelime" SortExpression="word_ing" />
                <asp:BoundField DataField="word_answer1" HeaderText="Cevap1" SortExpression="word_answer1" />
                <asp:BoundField DataField="word_answer2" HeaderText="Cevap2" SortExpression="word_answer2" />
                <asp:BoundField DataField="word_answer3" HeaderText="Cevap3" SortExpression="word_answer3" />
                <asp:BoundField DataField="word_answer4" HeaderText="Cevap4" SortExpression="word_answer4" />
                <asp:BoundField DataField="word_correct_answer" HeaderText="Doğru Cevap" SortExpression="word_correct_answer" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WordConnectionString %>" DeleteCommand="DELETE FROM [Words] WHERE [word_id] = @word_id" InsertCommand="INSERT INTO [Words] ([word_ing], [word_answer1], [word_answer2], [word_answer3], [word_answer4], [word_correct_answer]) VALUES (@word_ing, @word_answer1, @word_answer2, @word_answer3, @word_answer4, @word_correct_answer)" SelectCommand="SELECT * FROM [Words]" UpdateCommand="UPDATE [Words] SET [word_ing] = @word_ing, [word_answer1] = @word_answer1, [word_answer2] = @word_answer2, [word_answer3] = @word_answer3, [word_answer4] = @word_answer4, [word_correct_answer] = @word_correct_answer WHERE [word_id] = @word_id">
            <DeleteParameters>
                <asp:Parameter Name="word_id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="word_ing" Type="String" />
                <asp:Parameter Name="word_answer1" Type="String" />
                <asp:Parameter Name="word_answer2" Type="String" />
                <asp:Parameter Name="word_answer3" Type="String" />
                <asp:Parameter Name="word_answer4" Type="String" />
                <asp:Parameter Name="word_correct_answer" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="word_ing" Type="String" />
                <asp:Parameter Name="word_answer1" Type="String" />
                <asp:Parameter Name="word_answer2" Type="String" />
                <asp:Parameter Name="word_answer3" Type="String" />
                <asp:Parameter Name="word_answer4" Type="String" />
                <asp:Parameter Name="word_correct_answer" Type="String" />
                <asp:Parameter Name="word_id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
</asp:Content>
