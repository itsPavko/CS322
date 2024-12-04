<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div>

            <label for="fname">First name:</label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

            <br><br>

            <label for="lname">Last name:</label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

            <br><br>

            <label for="index">Index:</label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

            <br>

             <asp:Button ID="Button1" runat="server" Text="Add" /> 
            <!--
                OnClick="Button1_Click" Stvara gresku
                Ne pronalazi Default.aspx.cs i funkciju Button1_Click
                Samim tim ne dozvoljava stranici da se ucita
                Bez njega se stranica ucitava i podaci iz baze se prikazuju u tabeli
             -->

            <br>

            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Table]"></asp:SqlDataSource>
                
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Index" DataSourceID="SqlDataSource2" Width="483px">
                <Columns>
                    <asp:BoundField DataField="Index" HeaderText="Index" ReadOnly="True" SortExpression="Index" />
                    <asp:BoundField DataField="fName" HeaderText="fName" SortExpression="fName" />
                    <asp:BoundField DataField="lName" HeaderText="lName" SortExpression="lName" />
                </Columns>
            </asp:GridView>
        </div>
    </main>
</asp:Content>


