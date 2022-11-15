<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="webform2.aspx.cs" Inherits="webform1.Content.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div class="row">
        <div class="col-md-6 col-md-offset-3">
            <div class="panel panel-success">
                <div class="panel-heading">Employee Registration </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <label>Employee Name</label>
                                <asp:TextBox runat="server" ID="txtname" CssClass="form-control" />
                            </div>
                        </div>
                        <div class="col-md-6">          
                            <div class="form-group">
                                <label>Employee Email</label>
                                <asp:TextBox runat="server" ID="txtemail" CssClass="form-control" TextMode="Email" />
                            </div>
                        </div>
                    </div>
                     <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <label>Employee Salary</label>
                                <asp:TextBox runat="server" ID="txtsalary" CssClass="form-control" TextMode="Number" />
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <labell>Employee Mobile</labell>
                                <asp:TextBox runat="server" ID="txtmobile" CssClass="form-control" TextMode="number"  />
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <label>Employee Date_Of_Birth</label>
                                <asp:TextBox runat="server" ID="txtdob" CssClass="form-control" TextMode="Date" />

                            </div>
                       </div>
                    </div>

                </div>
                    <div class="pannel-footer">
                        <div class="row">
                            <div class="col-md-2 col-md-offset-8">
                                <div class="form-group">
                                    <asp:Button Text="clear" CssClass="btn btn-danger" ID="btnClear" runat="server" Onclick="btnClear_Click" />
                                </div>
                            </div>
                            <div class="col-md-2 col-md-offset-8">
                                <div class="form-group">
                                    <asp:Button Text="Register" CssClass="btn btn-info" ID="btnregister" runat="server" Onclick="btnregister_Click" />
                                </div>
                            </div>
                        </div>
                        <div class ="row">
                            <div class="col-md-12">
                                <asp:Label Text="" ID="lbMassage" runat="server" />
                            </div>
                        </div>
                        </div>
                    </div>
            </div>
   </div>     
    
        
</asp:Content>

