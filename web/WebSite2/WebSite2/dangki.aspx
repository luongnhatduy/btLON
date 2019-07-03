<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="dangki.aspx.cs" Inherits="dangki" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="CSS/dangki.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="noidung">
      <div id="dangky">
                               
                        <b> CHÀO MỪNG BẠN ĐẾN VỚI ĐĂNG KÝ </b> <br />
                    <label>
                        <div >
                            <div>
                                <table id="bang">
                                    <tr>
                                        <td class="td_trai"><label for='txttaikhoan'>TÀI KHOẢN </label></td>
                                         <td class="td_phai" >
                                             <input id='txttaikhoan' type="text" placeholder='nhập tài khoản' style="width:100%"> 
                                          </td>
                                    </tr>
                                    <tr> 
                                        <td class="td_trai"> <label for='txttaikhoan'>MẬT KHẨU  </label> </td>
                                         <td class="td_phai"> <input id='txtmathau' type="text" placeholder='nhập mật khẩu ' style="width:100%"> </td>
                                    </tr>
                                    <tr> 
                                        <td class="td_trai"> <lable> SDT or GMAIL </lable></td>
                                         <td class="td_phai"> <input type="text" placeholder="nhập số điện thoại/gmail" style="width:100%"> </td>
                                    </tr>
                                    <tr> 
                                         <td class="td_trai"><lable> NGÀY SINH </lable></td>
                                         <td class="td_phai"> <input type="date" style="width:100%"> </td>
                                    </tr>
                                    <tr>
                                        <td class="td_trai"> <lable>GIỚI TÍNH </lable></td>
                                       <td class="td_phai">
                                            <input type="radio" name='gioitinh' value="nam" /> <span>Nam </span>
                                            <input type="radio" name='gioitinh' value="nu" /> <span>Nữ </span>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </label>
                     <div >
                        <a href="home.aspx"> <input type="button" value="ĐĂNG KÝ" style="margin-right:60px" onclick="dangky()" class="dangky-button"  /></a>
                        <a href="dangnhap.aspx"> <input type="button" value="ĐĂNG NHẬP "   class="dangky-button"  /></a> 
                    </div>
               
            </div>
    </div>
</asp:Content>

