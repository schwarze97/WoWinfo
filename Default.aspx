<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WoWinfo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>World of Warcraft - Character Profile Displayer</h1>
        <p class="lead">&nbsp;</p>
		<p class="lead">Click on the button below to obtain information about a World of Warcraft character.</p>
		<p class="lead">&nbsp;</p>
        <p>
			<asp:Button ID="btnInfo" runat="server" Height="52px" OnClick="btnInfo_Click" Text="Get Information" Width="195px" />
		</p>
		<p>&nbsp;</p>
		<p>ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;</p>
		<p>Name:&nbsp;&nbsp;
			<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
		</p>
		<p>Level:&nbsp;&nbsp;&nbsp;
			<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
		</p>
		<p>&nbsp;</p>
		<p>&nbsp;</p>
		<p>&nbsp;</p>
    </div>

    </asp:Content>
