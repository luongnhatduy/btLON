<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/home.css" rel="stylesheet" />
    <script src="JS/home.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="main">
       <div class="slide">
           <img name="slide" width="557" height="385">
       </div>
       <div class ="banner">
           <img src="IMG/don-giang-sinh-rinh-qua-tangright1.png" />
           <img src="IMG/20181226-Right-2-Banner-.png" style="margin-top:5px">
       </div>
       <div class="sp-slide1">
           <div class="sp-slide1-top">
               
               <img src="IMG/dieu-hoa.gif" style="width:25px;height:25px">
               <span><b>KHUYẾN MÃI HOT</b></span>
               <p>&nbsp;</p>
               <img src="IMG/prev.jpg" style="margin-left:-40px" onclick="navLeft()">
               <img src="IMG/next.jpg" onClick="navRight()"/>
           </div>
           <div id="sanpham">

           </div>
       </div>


        <div class="sp-slide1">
           <div class="sp-slide1-top">
               
               <img src="IMG/dien-tu.gif" style="width:25px;height:25px">
               <span><b>TiVi</b></span>
               <p style="width:803px !important">&nbsp;</p>
               <img src="IMG/prev.jpg" style="margin-left:-40px" onclick="navLeft1()">
               <img src="IMG/next.jpg" onClick="navRight1()"/>
           </div>
           <div id="sanpham1">

           </div>
       </div>

        <div class="sp-slide1" style="margin-top:-202px  !important">
           <div class="sp-slide1-top">
               
               <img src="IMG/dien-thoai.gif" style="width:25px;height:25px">
               <span><b>ĐIỆN THOẠI</b></span>
               <p style="width:734px !important">&nbsp;</p>
               <img src="IMG/prev.jpg" style="margin-left:-40px" onclick="navLeft2()">
               <img src="IMG/next.jpg" onClick="navRight2()"/>
           </div>
           <div id="sanpham2">

           </div>
       </div>

        <div class="sp-slide1" style="margin-top:-202px  !important">
           <div class="sp-slide1-top">
               
               <img src="IMG/gia-dung.gif" style="width:25px;height:25px">
               <span><b>ĐỒ GIA DỤNG</b></span>
               <p style="width:715px !important">&nbsp;</p>
               <img src="IMG/prev.jpg" style="margin-left:-40px" onclick="navLeft3()">
               <img src="IMG/next.jpg" onClick="navRight3()"/>
           </div>
           <div id="sanpham3">

           </div>
       </div>


    </div>
    
    
</asp:Content>

