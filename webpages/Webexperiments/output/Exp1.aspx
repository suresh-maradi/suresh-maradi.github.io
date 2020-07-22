<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exp1.aspx.cs" Inherits="hometute.webpages.Webexperiments.output.Exp1" %>

<!doctype html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <title>java sript Calculator</title>
  </head>
  <body>
      <form runat="server">
    <asp:ScriptManager ID="scriptmanager1" runat="server">  
</asp:ScriptManager>
          <asp:UpdatePanel ID="updatepnl" runat="server">  
<ContentTemplate> 
          <h1>Calculator using javascript</h1>
      <asp:Table ID="Table1" runat="server" HorizontalAlign="Center" BorderStyle="Solid" BorderWidth="5px" BackColor="WhiteSmoke">
          <asp:TableHeaderRow>
              <asp:TableHeaderCell ColumnSpan="4" HorizontalAlign="Center" Width="100%" >
                  <asp:TextBox ID="txtbxresult" runat="server" Text="0" TextMode="SingleLine" CssClass="badge-pill"></asp:TextBox><br />
                  <asp:TextBox ID="txtbxcalc" runat="server" TextMode="SingleLine" CssClass="badge-pill"></asp:TextBox>
              </asp:TableHeaderCell>

          </asp:TableHeaderRow>
      <asp:TableHeaderRow HorizontalAlign="Center">
          
          <asp:TableCell>
              <asp:Button ID="btnClear" runat="server" Text="C" OnClick="btnClear_Click" CssClass="badge-pill" />
          </asp:TableCell>
          <asp:TableCell>
              <asp:Button ID="btnBackspace" runat="server" Text="B" OnClick="btnBackspace_Click" CssClass="badge-pill" />
          </asp:TableCell>
          <asp:TableCell>
              <asp:Button ID="BtnModulus" runat="server" Text="%" OnClick="BtnModulus_Click" CssClass="badge-pill" />
          </asp:TableCell>
          <asp:TableCell>
              <asp:Button ID="BtnDevide" runat="server" Text="/" OnClick="BtnDevide_Click" CssClass="badge-pill" />
          </asp:TableCell>
      </asp:TableHeaderRow>
          <asp:TableHeaderRow HorizontalAlign="Center">
          <asp:TableCell>
              <asp:Button ID="btnseven" runat="server" Text="7" OnClick="btnseven_Click" CssClass="badge-pill" />
          </asp:TableCell>
          <asp:TableCell>
              <asp:Button ID="btneight" runat="server" Text="8" OnClick="btneight_Click" CssClass="badge-pill" />
          </asp:TableCell>
          <asp:TableCell>
              <asp:Button ID="btnnine" runat="server" Text="9" OnClick="btnnine_Click" CssClass="badge-pill" />
          </asp:TableCell>
          <asp:TableCell>
              <asp:Button ID="btntimes" runat="server" Text="X" OnClick="btntimes_Click" CssClass="badge-pill" />
          </asp:TableCell>
      </asp:TableHeaderRow>
          <asp:TableHeaderRow HorizontalAlign="Center">
          <asp:TableCell>
              <asp:Button ID="btnfour" runat="server" Text="4" OnClick="btnfour_Click" CssClass="badge-pill" />
          </asp:TableCell>
          <asp:TableCell>
              <asp:Button ID="btnfive" runat="server" Text="5" OnClick="btnfive_Click" CssClass="badge-pill" />
          </asp:TableCell>
          <asp:TableCell>
              <asp:Button ID="btnsix" runat="server" Text="6" OnClick="btnsix_Click" CssClass="badge-pill" />
          </asp:TableCell>
          <asp:TableCell>
              <asp:Button ID="btnsubstract" runat="server" Text="-" OnClick="btnsubstract_Click" CssClass="badge-pill" />
          </asp:TableCell>
      </asp:TableHeaderRow>
          <asp:TableHeaderRow HorizontalAlign="Center">
          <asp:TableCell>
              <asp:Button ID="btnone" runat="server" Text="1" OnClick="btnone_Click" CssClass="badge-pill" />
          </asp:TableCell>
          <asp:TableCell>
              <asp:Button ID="btntwo" runat="server" Text="2" OnClick="btntwo_Click" CssClass="badge-pill" />
          </asp:TableCell>
          <asp:TableCell>
              <asp:Button ID="btnthree" runat="server" Text="3" OnClick="btnthree_Click" CssClass="badge-pill" />
          </asp:TableCell>
          <asp:TableCell>
              <asp:Button ID="btnaddition" runat="server" Text="+" OnClick="btnaddition_Click" CssClass="badge-pill" />
          </asp:TableCell>
      </asp:TableHeaderRow>
          <asp:TableHeaderRow HorizontalAlign="Center">
          <asp:TableCell>
              <asp:Button ID="btndummy" runat="server" Text="@" OnClick="btndummy_Click" CssClass="badge-pill" />
          </asp:TableCell>
          <asp:TableCell>
              <asp:Button ID="btnzero" runat="server" Text="0" OnClick="btnzero_Click" CssClass="badge-pill" />
          </asp:TableCell>
          <asp:TableCell>
              <asp:Button ID="btnpoint" runat="server" Text="." OnClick="btnpoint_Click" CssClass="badge-pill" />
          </asp:TableCell>
          <asp:TableCell>
              <asp:Button ID="btnassign" runat="server" Text="=" OnClick="btnassign_Click" CssClass="badge-pill" />
          </asp:TableCell>
      </asp:TableHeaderRow>
      </asp:Table>
    </ContentTemplate>
              </asp:UpdatePanel>
          </form>
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
  </body>
</html>