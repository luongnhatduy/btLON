<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="dangnhap.aspx.cs" Inherits="dangnhap" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="CSS/dangnhap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="dangnhap">
                     <b> CHÀO MỪNG BẠN ĐĂNG NHẬP </b> 
              
                       <div class="khung">
		                    <div class="input">
			                    <div>
				                    <span class="chu">TÀI KHOẢN</span>
				                    <input class="tyt" type="text"name="">
			                    </div>
			                      <div style="margin-top:50px">
				                        <span class="chu">MẬT KHẨU</span>
				                        <input class="txt" type="password" name="">
			                        </div>
			                        <div class="tzt">
				                        <input type="checkbox" name="">Nhớ Mật Khẩu
			                        </div>
		                      </div>
		               </div>
                            <div style="margin-top:30px">
                                  <a href="home.aspx" > <input type="button" value="ĐĂNG NHẬP" style="margin-right:60px;padding:5px 5px"   /></a> 
                                  <a href="dangki.aspx"> <input type="button" value="ĐĂNG KÝ "style="padding:5px 5px" /></a>
                            </div>
                      
                    
                
            </div>
</asp:Content>

