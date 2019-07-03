var i = 0;
var img = [];
img = ['/IMG/slide1.jpg', '/IMG/slide2.jpg', '/IMG/slide3.jpg', '/IMG/slide4.jpg', '/IMG/slide5.jpg', '/IMG/slide6.jpg', '/IMG/slide7.jpg', '/IMG/slide8.jpg', '/IMG/slide9.jpg'];
var time = 2000;

function changeImage() {
    document.slide.src = img[i];
    if (i < img.length - 1) {
        i++;
    } else {
        i = 0;
    }
    setTimeout("changeImage()", time);
    render();
    render1();
    render2();
    render3();
}

var data = [
  
    { name: "Máy ảnh canon 3000d", img: "/IMG/may-anh-canon-eos-3000d-kit-ef-s18-55-iii-1.jpg", price: "10.100.000 ₫" },
    { name: "Máy ảnh canon ixus", img: "/IMG/may-anh-kts-canon-ixus-185-b.jpg", price: "11.400.000 ₫"},
    { name: "Tivi sony 55x7000f", img: "/IMG/tivi-sony-kd-55x7000f.jpg", price: "22.300.000 ₫" },
    { name: "Tivi Toshiba 40124fd", img: "/IMG/ti-vi-toshiba-40l3650vn-a_1_1_1.jpg", price: "19.700.000 ₫" },
    { name: "Máy giặt Aqua sf564", img: "/IMG/may-giat-aqua-aqw-uw105at_1.png", price: "8.200.000 ₫" },
    { name: "Máy giặt Elextrolux dfe464", img: "/IMG/may-giat-long-ngang-electrolux-ewf12844.jpg", price: "12.100.000 ₫" },
    { name: "Nồi cơm Sharp com18v", img: "/IMG/noi-com-dien-sharp-1-8l-ks-com18v-w_1.jpg", price: "1.100.000 ₫"},
    { name: "Lò sưởi 13 thanh Goldsun", img: "/IMG/lo-suoi-dau-13-thanh-co-dieu-khien-ts9213.jpg", price: "5.700.000 ₫"},
    { name: "Lò vi sóng Electrolux fdd987", img: "/IMG/lo-vi-song-electrolux-emm2308x.png", price: "3.900.000 ₫"},
    { name: "Điều hòa Electrolux esm343", img: "/IMG/dieu-hoa-electrolux-1-chieu-esm09crm-a1_3_1_1.jpg", price: "12.600.000 ₫" },
    { name: "Điều hòa Electrolux fgff34", img: "/IMG/dieu-hoa-electrolux-esv09cro-d1_5_1_1.png", price: "11.500.000  ₫"},
    { name: "LapTop hp da0051tu", img: "/IMG/mtxt-hp-pav-15-da0051tu-4me64pa-core-i3-7020u-4gb-ram-500gb-15-6-win-10-silver.jpg", price: "15.100.000 ₫" },
    { name: "LapTop Lenovo dfe464", img: "/IMG/mtxt-lenovo-idp-320-14isk-80xfg009tvn-4gb-500gb-14-xam-1.jpg", price: "14.350.000 ₫" },
    { name: "Máy hút bụi Electrolux ", img: "/IMG/may-hut-bui-electrolux-zap9910.png", price: "7.400.000 ₫" },
    { name: "Máy ảnh canon ixus", img: "/IMG/may-rua-bat-electrolux-esf6010bw.jpg", price: "5.800.000 ₫" },
    
]
var dataStart = 0;
var dataDisplay = 10;

function navLeft() {
    if (dataStart == 0) {
        return;
    }
    dataStart--;
    render();
}

function navRight() {
    if (dataStart == data.length - dataDisplay) return;
    dataStart++;
    render();

}

function render() {
    var element = document.getElementById("sanpham")
    var html = "";
    var displayData = data.slice(dataStart, dataStart + dataDisplay);
    for (var i = 0; i < displayData.length; i++) {
        html += '<div style="float: left; width: 18%;border: 1px solid #bfd2e3;margin-left:10px;margin-top:10px">';
        html += '<img style="width:80%;margin-left:20px" src="'  + displayData[i].img +'">';
        html += '<p style="margin-left:20px;font-size:13px">' + displayData[i].name + '</p>';
        html += '<p style="color:red; text-align: center">' + displayData[i].price + '</p>';
        html += '</div>';
    }
    element.innerHTML = html;
}

var data1 = [

    { name: "Tivi samsung dsf989s", img: "/IMG/tivi-samsung-ua55nu7400kxxv_1_1.jpg", price: "10.100.000 ₫" },
    { name: "Tivi samsung us8383", img: "/IMG/tivi-samsung-ua50nu7800kxxv_1.jpg", price: "11.400.000 ₫" },
    { name: "Tivi sony 55x7000f", img: "/IMG/tivi-sony-kd-43x8500f_4_2_1.jpg", price: "22.300.000 ₫" },
    { name: "Tivi sony 40124fd", img: "/IMG/tivi-sony-kd-55x7000f.jpg", price: "19.700.000 ₫" },
    { name: "Tivi Toshiba sf564", img: "/IMG/ti-vi-toshiba-40l3650vn-a_1_1_1.jpg", price: "18.200.000 ₫" },
    { name: "Tivi Toshiba dfe464", img: "/IMG/ti-vi-toshiba-49u9750vn_2.jpg", price: "12.100.000 ₫" },
    { name: "Tivi Toshiba com18v", img: "/IMG/ti-vi-toshiba-55u9650vn.png", price: "11.100.000 ₫" },
    { name: "Tivi Sharp 50sdd59", img: "/IMG/tivi-sharp-lc-50ua440x_1_1.jpg", price: "15.700.000 ₫" },
    { name: "Tivi Sharp fdd987", img: "/IMG/tivi-sharp-lc-50ua6500x_1.jpg", price: "13.900.000 ₫" },
    { name: "Tivi Sharp esm343", img: "/IMG/tivi-sharp-lc-50ue630x-a_1.jpg", price: "12.600.000 ₫" },
    

]
var dataStart1 = 0;
var dataDisplay1 = 5;

function navLeft1() {
    if (dataStart1 == 0) {
        return;
    }
    dataStart1--;
    render1();
}

function navRight1() {
    if (dataStart1 == data1.length - dataDisplay1) return;
    dataStart1++;
    render1();
}

function render1() {
    var element1 = document.getElementById("sanpham1")
    var html = "";
    var displayData1 = data1.slice(dataStart1, dataStart1 + dataDisplay1);
    for (var i = 0; i < displayData1.length; i++) {
        html += '<div style="float: left; width: 18%;border: 1px solid #bfd2e3;margin-left:10px;margin-top:10px">';
        html += '<img style="width:80%;margin-left:20px" src="' + displayData1[i].img + '">';
        html += '<p style="text-align: center;font-size:13px">' + displayData1[i].name + '</p>';
        html += '<p style="color:red; text-align: center">' + displayData1[i].price + '</p>';
        html += '</div>';
    }
    element1.innerHTML = html;
}


var data2 = [

    { name: "Iphone X 64gb silver", img: "/IMG/dien-thoai-iphone-x-64gb-silver-b.jpg", price: "10.100.000 ₫" },
    { name: "Iphone X 256gb silver", img: "/IMG/dien-thoai-iphone-x-64gb-silver_1.png", price: "11.400.000 ₫" },
    { name: "Nokia 7 plus", img: "/IMG/dien-thoai-nokia-7-plus-a.png", price: "22.300.000 ₫" },
    { name: "SamSung galaxy note 9", img: "/IMG/dien-thoai-samsung-galaxy-note-9-512gb-4.png", price: "19.700.000 ₫" },
    { name: "SamSung galaxy sm", img: "/IMG/dien-thoai-samsung-galaxy-sm-a750gzkwxxv.png", price: "18.200.000 ₫" },
    { name: "SamSung galaxy j6", img: "/IMG/dien-thoai-samsung-j6.jpg", price: "12.100.000 ₫" },
    { name: "Oppo F9", img: "/IMG/oppo-f9-2.png", price: "11.100.000 ₫" },
   
]
var dataStart2 = 0;
var dataDisplay2 = 5;

function navLeft2() {
    if (dataStart2 == 0) {
        return;
    }
    dataStart2--;
    render2();
}

function navRight2() {
    if (dataStart2 == data2.length - dataDisplay2) return;
    dataStart2++;
    render2();
}

function render2() {
    var element2 = document.getElementById("sanpham2")
    var html = "";
    var displayData2 = data2.slice(dataStart2, dataStart2 + dataDisplay2);
    for (var i = 0; i < displayData2.length; i++) {
        html += '<div style="float: left; width: 18%;border: 1px solid #bfd2e3;margin-left:10px;margin-top:10px">';
        html += '<img style="width:80%;margin-left:20px" src="' + displayData2[i].img + '">';
        html += '<p style="text-align: center;font-size:13px">' + displayData2[i].name + '</p>';
        html += '<p style="color:red; text-align: center">' + displayData2[i].price + '</p>';
        html += '</div>';
    }
    element2.innerHTML = html;
}


var data3 = [

    { name: "Iphone X 64gb silver", img: "/IMG/lo-suoi-dau-13-thanh-co-dieu-khien-ts9213.jpg", price: "3.100.000 ₫" },
    { name: "Iphone X 256gb silver", img: "/IMG/lo-vi-song-electrolux-emm2308x.png", price: "4.400.000 ₫" },
    { name: "Nokia 7 plus", img: "/IMG/lo-vi-song-panasonic-27l-co-nuong-nn-ct655myue.jpg", price: "2.300.000 ₫" },
    { name: "SamSung galaxy note 9", img: "/IMG/may-hut-bui-panasonic-mc-cg525rn49.jpg", price: "5.700.000 ₫" },
    { name: "SamSung galaxy sm", img: "/IMG/may-xay-sinh-to-philips-hr2056.jpg", price: "1.240.000 ₫" },
    { name: "SamSung galaxy j6", img: "/IMG/noi-com-dien-cuckoo-1-0l-mau-cam-cr-0661-o.png", price: "1.100.000 ₫" },
    { name: "Oppo F9", img: "/IMG/noi-com-dien-sharp-1-8l-ks-com18v-w_1.jpg", price: "1.300.000 ₫" },

]
var dataStart3 = 0;
var dataDisplay3 = 5;

function navLeft3() {
    if (dataStart3 == 0) {
        return;
    }
    dataStart3--;
    render3();
}

function navRight3() {
    if (dataStart3 == data3.length - dataDisplay3) return;
    dataStart3++;
    render3();
}

function render3() {
    var element3 = document.getElementById("sanpham3")
    var html = "";
    var displayData3 = data3.slice(dataStart3, dataStart3 + dataDisplay3);
    for (var i = 0; i < displayData3.length; i++) {
        html += '<div style="float: left; width: 18%;border: 1px solid #bfd2e3;margin-left:10px;margin-top:10px">';
        html += '<img style="width:80%;margin-left:20px" src="' + displayData3[i].img + '">';
        html += '<p style="text-align: center;font-size:13px">' + displayData3[i].name + '</p>';
        html += '<p style="color:red; text-align: center">' + displayData3[i].price + '</p>';
        html += '</div>';
    }
    element3.innerHTML = html;
}




window.onload = changeImage;