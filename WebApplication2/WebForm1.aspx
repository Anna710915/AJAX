<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<%--<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
    <div>
       <h4>Select a file to upload:</h4>
   
       <asp:FileUpload id="FileUpload1"                 
           runat="server">
       </asp:FileUpload>
            
       <br /><br />
       
       <asp:Button id="UploadButton" 
           Text="Upload file"
           OnClick="UploadButton_Click"
           runat="server">
       </asp:Button>    
       
       <hr />
       
       <asp:Label id="UploadStatusLabel"
           runat="server">
       </asp:Label> 
        <br>
        <asp:Image id="Image1" runat="server"
           AlternateText="Image text"
           ImageAlign="left"
           ImageUrl="images/isewtweetbg.jpg" Height="500px" Width="600px"/>     
        
    </div>
    </form>
</body>
</html>--%>


<head runat="server">

    <title>Untitled Page</title>

</head>

<body>

    <form id="form1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server" />

      

    <div>

      <h1>

      Сколько стоит воздух?

      </h1>

   <br />

  

   Result:

   <asp:UpdatePanel runat="server" ID="ResultPanel">

   <ContentTemplate>

   <br />
   <asp:Label runat="server" ID="Label1">Евро : </asp:Label>
   <asp:Label runat="server" ID="ResultrLabel"></asp:Label>
       
   <br />
       <asp:Label runat="server" ID="Label2">Доллар США : </asp:Label>
       <asp:Label runat="server" ID="Label3"></asp:Label>
   <br />
       <asp:Label runat="server" ID="Label4">Российский рубль : </asp:Label>
       <asp:Label runat="server" ID="Label5"></asp:Label>
       <asp:Timer ID="Timer1" runat="server"  Interval="1500" OnTick="Timer1_Tick">
       </asp:Timer>
   <br />
   <small>

   Panel render Time=<%=DateTime.Now.ToString() %></small>

      </ContentTemplate>

      

   </asp:UpdatePanel>

   

   <asp:UpdateProgress runat="server" ID="UpdateProgress1">

   <ProgressTemplate>

   

   </ProgressTemplate>

   

   </asp:UpdateProgress>

   

   <small>Page render Time2=<% =DateTime.Now.ToString() %></small>

    

    </div>

    </form>

</body>


</html>

