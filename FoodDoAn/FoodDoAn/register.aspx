<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="FoodDoAn.register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_content" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="p-5">
                <div class="text-center">
                    <h1 class="h4 text-gray-900 mb-4">Create an Account!</h1>
                </div>
                <div class="user">
                    <div class="form-group row">
                        <%--<div class="col-sm-4 mb-3 mb-sm-0">
                            <asp:TextBox ID="txtFirstName" runat="server" type="text" CssClass="form-control form-control-user" placeholder="First Name"></asp:TextBox>
                           
                        </div>--%>
                        <div class="col-sm-4">
                            <asp:TextBox ID="txtName" runat="server"  type="text" CssClass="form-control form-control-user" placeholder="Name"></asp:TextBox>
                            <asp:RequiredFieldValidator ValidationGroup="vsNotification" ID="rfvName" runat="server" ErrorMessage="Bạn Chưa Nhập Name" ControlToValidate="txtName"></asp:RequiredFieldValidator>
                        </div>

                        <div class="col-sm-4">
                            <asp:TextBox ID="txtUserName" runat="server"  type="text" CssClass="form-control form-control-user" placeholder="UserName"></asp:TextBox>
                             <asp:RequiredFieldValidator ValidationGroup="vsNotification" ID="rfvUserName" runat="server" ErrorMessage="Bạn Chưa Nhập User Name" ControlToValidate="txtUserName"></asp:RequiredFieldValidator><br />
                            <asp:RegularExpressionValidator ID="revUserName" runat="server" ErrorMessage="Bạn Phải Nhập Chữ" ValidationExpression="[A-Za-z_]" ControlToValidate="txtUserName"></asp:RegularExpressionValidator>
                        </div>
                       <%-- <div class="col-sm-4">
                            <asp:TextBox ID="txtEmail" runat="server" type="email" CssClass="form-control form-control-user"  placeholder="Email Address"></asp:TextBox>
                            
                        </div>--%>
                    </div>
                    <div class="form-group row">
                        <div class="col-sm-4  mb-3 mb-sm-0">
                            <asp:TextBox ID="txtPhone" runat="server" type="number" CssClass="form-control form-control-user" placeholder="Phone"></asp:TextBox>
                            <asp:RegularExpressionValidator ValidationGroup="vsNotification" ID="revPhone" runat="server" ErrorMessage="Bạn Phải Nhập 10 số" ControlToValidate="txtPhone" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
                        </div>
                        <div class="col-sm-4 mb-3 mb-sm-0">

                            <asp:TextBox ID="txtPassword" runat="server" type="password" CssClass="form-control form-control-user" placeholder="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ValidationGroup="vsNotification" ID="rvPass" runat="server" ErrorMessage="Bạn Chưa Nhập Password" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                            <br />
                           <asp:RegularExpressionValidator ValidationGroup="vsNotification" ID="revPassword" runat="server" ErrorMessage="Bạn Phải Nhập 3 đến 10" ControlToValidate="txtPassword" ValidationExpression="[A-Za-z]{3,10}"></asp:RegularExpressionValidator>
                        </div>
                        <div class="col-sm-4  mb-3 mb-sm-0">

                            <asp:TextBox ID="txtRepass" runat="server" type="password" CssClass="form-control form-control-user" placeholder="Repeat Password"></asp:TextBox>
                            <asp:CompareValidator ValidationGroup="vsNotification" ID="cvRepass" runat="server" ErrorMessage="rePass Chưa giống pass" ControlToCompare="txtPassword" ControlToValidate="txtRepass" Type="String"></asp:CompareValidator>
                        </div>
                    </div>
                    <div class="form-group row">
                      <%--  <asp:DropDownList ID="ddl_status" runat="server" CssClass="col-sm-4  mb-3 mb-sm-0">
                            <asp:ListItem Enabled="true">--Trạng Thái--</asp:ListItem>
                             <asp:ListItem Value="0">Ngừng Hoạt Động</asp:ListItem>
                             <asp:ListItem Value="1">Đang Hoạt Động</asp:ListItem>
                        </asp:DropDownList>--%>
                        <asp:DropDownList ID="ddl_user" runat="server" CssClass="col-sm-4  mb-3 mb-sm-0">
                              <asp:ListItem Enabled="true">--Role--</asp:ListItem>
                             <asp:ListItem Value="0">User</asp:ListItem>
                             <asp:ListItem Value="1">Admin</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                  
                    <div class="form-group row">
                        <div class="col-sm-4  mb-3 mb-sm-0">
                            <i class="fab fa-google fa-fw"></i>
                            <asp:Button ValidationGroup="vsNotification" ID="btn_register" runat="server" Text="Register Account" CssClass="btn btn-primary btn-user btn-block" OnClick="btn_register_Click" />
                            
                        </div>
                        <div class="col-sm-4  mb-3 mb-sm-0">
                            <i class="fab fa-google fa-fw"></i>
                            <asp:Button ID="btn_google"  CssClass="btn btn-google btn-user btn-block"  runat="server" Text="Register with Google" />
                           
                        </div>
                        <div class="col-sm-4  mb-3 mb-sm-0">
                            <i class="fab fa-facebook-f fa-fw"></i>
                            <asp:Button ID="btn_fb" runat="server" Text="Register with Facebook"  CssClass="btn btn-facebook btn-user btn-block" />
                           
                        </div>

                        <hr>


                    </div>

                </div>
                <hr>
                
                <div class="text-center">
                    <a class="small" href="forgot-password.html">Forgot Password?</a>
                </div>
                <div class="text-center">
                    <a class="small" href="login.html">Already have an account? Login!</a>
                </div>
                <asp:ValidationSummary ID="vsGroup" runat="server" ValidationGroup="vsNotification" />

                <div id ="txtKQ" runat="server">KQ...</div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_js" runat="server">
</asp:Content>
