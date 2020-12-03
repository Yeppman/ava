/*----------------------------------------------------
@File: Default Styles
@Author: Sports Avalanche
@URL: http://sportsavalanche.com
Author E-mail: info@sportsavalanche.com

---------------------------------------------------- */
/*=====================================================================
@Template Name: Sports Avalanche
@Author: Sports Avalanche
@Developed By: Sports Avalanche
@Developer URL: http://sportsavalanche.com
Author E-mail: info@sportsavalanche.com

@Default Styles

Table of Content:
01/ Variables
02/ predefin
03/ header
04/ button
05/ banner
06/ breadcrumb
07/ about
08/ team
09/ project 
10/ price 
11/ team 
12/ blog 
13/ video  
14/ features  
15/ career  
16/ contact 
17/ footer

=====================================================================*/
/*----------------------------------------------------*/
/*font Variables*/
/*Color Variables*/
/*=================== fonts ====================*/
@import url("https://fonts.googleapis.com/css?family=Open+Sans:400,600,700|Roboto:300,300i,400,500,700");
/*---------------------------------------------------- */
/*----------------------------------------------------*/



.list {
  list-style: none;
  margin: 0px;
  padding: 0px;
}

a {
  text-decoration: none;
  -webkit-transition: all 0.3s ease-in-out;
  -o-transition: all 0.3s ease-in-out;
  transition: all 0.3s ease-in-out;
}

a:hover, a:focus {
  text-decoration: none;
  outline: none;
}

.row.m0 {
  margin: 0px;
}


  /* Make the image fully responsive */
  .carousel-inner img {
    width: 100%;
    height: 100%;
  }

  .slide-box{
    /* height: 300px; */
  }

body {
  line-height: 24px;
  font-size: 14px;
  font-family: "Roboto", sans-serif;
  font-weight: normal;
  color: #777777;
}

h1, h2, h3, h4, h5, h6 {
  font-family: "Open Sans", sans-serif;
  font-weight: 600;
}

button:focus {
  outline: none;
  -webkit-box-shadow: none;
  box-shadow: none;
}

.p_120 {
  padding-top: 120px;
  padding-bottom: 120px;
}

.pad_top {
  padding-top: 120px;
}

.mt-25 {
  margin-top: 25px;
}

.p0 {
  padding-left: 0px;
  padding-right: 0px;
}

@media (min-width: 1200px) {
  .container {
    max-width: 1170px;
  }
}

@media (min-width: 1620px) {
  .box_1620 {
    max-width: 1650px;
    margin: auto;
  }
}

/* Main Title Area css
============================================================================================ */
.main_title {
  text-align: center;
  /* margin-bottom: 75px; */
}

.main_title h2 {
  font-family: "Open Sans", sans-serif;
  font-size: 3rem;
  color: #222222;
  font-weight: 800;
  margin-bottom: 15px;
  font-family: "Boing", '-apple-system, BlinkMacSystemFont', "Segoe UI", 'Roboto',
  Helvetica, Arial, sans-serif, "Apple Color Emoji", "Segoe UI Emoji",
  "Segoe UI Symbol";
}

.main_title p {
  font-size: 1.0rem;
  font-family: "Roboto", sans-serif;
  line-height: 24px;
  color: #777777;
  max-width: 570px;
  font-weight: 500;
  margin: auto;
  margin-bottom: 20px;
}

.main_title.white h2 {
  color: #fff;
}

.main_title.white p {
  color: #fff;
  opacity: .6;
}

/* End Main Title Area css
============================================================================================ */
/*---------------------------------------------------- */
/*----------------------------------------------------*/
.header_area {
  position: absolute;
  /* background: white; */
  width: 100%;
  top: 0;
  left: 0;
  z-index: 99;
  -webkit-transition: background 0.4s, all 0.3s linear;
  -o-transition: background 0.4s, all 0.3s linear;
  transition: background 0.4s, all 0.3s linear;
}

.header_area .navbar {
  background: transparent;
  padding: 0px;
  border: 0px;
  border-radius: 0px;
}

.header_area .navbar .nav .nav-item {
  margin-right: 45px;
}

.header_area .navbar .nav .nav-item .nav-link {
  font: 600 12px/100px "Open Sans", sans-serif;
  text-transform: uppercase;
  color: rgb(0, 0, 0);
  padding: 0px;
  display: inline-block;
}

.header_area .navbar .nav .nav-item .nav-link:after {
  display: none;
}

.header_area .navbar .nav .nav-item.submenu {
  position: relative;
}

.header_area .navbar .nav .nav-item.submenu ul {
  border: none;
  padding: 0px;
  border-radius: 0px;
  -webkit-box-shadow: none;
  box-shadow: none;
  margin: 0px;
  background: #fff;
}

@media (min-width: 992px) {
  .header_area .navbar .nav .nav-item.submenu ul {
    position: absolute;
    top: 120%;
    left: 0px;
    min-width: 200px;
    text-align: left;
    opacity: 0;
    -webkit-transition: all 300ms ease-in;
    -o-transition: all 300ms ease-in;
    transition: all 300ms ease-in;
    visibility: hidden;
    display: block;
    border: none;
    padding: 0px;
    border-radius: 0px;
    -webkit-box-shadow: 0px 10px 30px 0px rgba(115, 73, 251, 0.3);
    box-shadow: 0px 10px 30px 0px rgba(115, 73, 251, 0.3);
  }
}

.header_area .navbar .nav .nav-item.submenu ul:before {
  content: "";
  width: 0;
  height: 0;
  border-style: solid;
  border-width: 10px 10px 0 10px;
  border-color: #eeeeee transparent transparent transparent;
  position: absolute;
  right: 24px;
  top: 45px;
  z-index: 3;
  opacity: 0;
  -webkit-transition: all 400ms linear;
  -o-transition: all 400ms linear;
  transition: all 400ms linear;
}

.header_area .navbar .nav .nav-item.submenu ul .nav-item {
  display: block;
  float: none;
  margin-right: 0px;
  border-bottom: 1px solid #ededed;
  margin-left: 0px;
  -webkit-transition: all 0.4s linear;
  -o-transition: all 0.4s linear;
  transition: all 0.4s linear;
}

.header_area .navbar .nav .nav-item.submenu ul .nav-item .nav-link {
  line-height: 45px;
  color: #222222;
  padding: 0px 30px;
  -webkit-transition: all 150ms linear;
  -o-transition: all 150ms linear;
  transition: all 150ms linear;
  display: block;
  margin-right: 0px;
}

.header_area .navbar .nav .nav-item.submenu ul .nav-item:last-child {
  border-bottom: none;
}

.header_area .navbar .nav .nav-item.submenu ul .nav-item:hover .nav-link {
  background-image: -moz-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%);
  background-image: -webkit-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%);
  background-image: -ms-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%);
  color: #fff;
}

@media (min-width: 992px) {
  .header_area .navbar .nav .nav-item.submenu:hover ul {
    visibility: visible;
    opacity: 1;
    top: 100%;
  }
}

.header_area .navbar .nav .nav-item.submenu:hover ul .nav-item {
  margin-top: 0px;
}

.header_area .navbar .nav .nav-item:last-child {
  margin-right: 0px;
}

.header_area .navbar .search {
  font-size: 12px;
  line-height: 60px;
  display: inline-block;
  color: #222222;
  margin-left: 80px;
}

.header_area .navbar .search i {
  font-weight: 600;
}

.header_area.navbar_fixed .main_menu {
  position: fixed;
  width: 100%;
  top: -70px;
  left: 0;
  right: 0;
  background-color: white;
  color: white !important;
  /* background-image: -moz-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%);
  background-image: -webkit-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%);
  background-image: -ms-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%); */
  -webkit-transform: translateY(70px);
  -ms-transform: translateY(70px);
  transform: translateY(70px);
  -webkit-transition: background 500ms ease, -webkit-transform 500ms ease;
  transition: background 500ms ease, -webkit-transform 500ms ease;
  -o-transition: transform 500ms ease, background 500ms ease;
  transition: transform 500ms ease, background 500ms ease;
  transition: transform 500ms ease, background 500ms ease, -webkit-transform 500ms ease;
  -webkit-transition: transform 500ms ease, background 500ms ease;
  -webkit-box-shadow: 0px 3px 16px 0px rgba(0, 0, 0, 0.1);
  box-shadow: 0px 3px 16px 0px rgba(0, 0, 0, 0.1);
}

.header_area.navbar_fixed .main_menu .navbar .nav .nav-item .nav-link {
  line-height: 70px;
}

.top_menu {
  background: #ec9d5f;
}

.top_menu .float-left a {
  line-height: 40px;
  display: inline-block;
  color: #fff;
  font-family: "Roboto", sans-serif;
  text-transform: uppercase;
  font-size: 12px;
  margin-right: 50px;
  -webkit-transition: all 300ms linear 0s;
  -o-transition: all 300ms linear 0s;
  transition: all 300ms linear 0s;
}

.top_menu .float-left a:last-child {
  margin-right: 0px;
}

.top_menu .float-left a:hover {
  color: #6247ea;
}

.top_menu .float-right .pur_btn {
  background: #6247ea;
  color: #fff;
  font-family: "Roboto", sans-serif;
  line-height: 40px;
  display: block;
  padding: 0px 40px;
  font-weight: 500;
  font-size: 12px;
}

/*---------------------------------------------------- */
/*----------------------------------------------------*/
/* Home Banner Area css
============================================================================================ */
.home_banner_area {
  z-index: 1;
  /* background: url('https://images.unsplash.com/photo-1522778119026-d647f0596c20?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80') no-repeat scroll center center; */
  /* background-size: cover; */
  background: -webkit-linear-gradient(
      45deg,
      /* rgba(171, 203, 211, 0.7),
      rgba(186, 168, 199, 0.7) */
      rgba(66, 211, 85, 0.2),
      rgba(66, 211, 85, 0.2)
      /* 152, 66, 211 */
    ),
    url("https://images.unsplash.com/photo-1522778119026-d647f0596c20?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80")
      50% no-repeat;
        background-repeat: no-repeat;
  background-size: cover
}

.home_banner_area .banner_inner {
  overflow: hidden;
  width: 100%;
  padding: 170px 0px 140px 0px;
}

.home_banner_area .banner_inner .banner_content {
  color: #fff;
}

.home_banner_area .banner_inner .banner_content .col-lg-9 {
  vertical-align: middle;
  -ms-flex-item-align: center;
  align-self: center;
}

.home_banner_area .banner_inner .banner_content h2 {
  font-size: 60px;
  font-weight: bold;
  font-family: "Open Sans", sans-serif;
  margin-bottom: 15px;
  margin-top: -30px;
}

.home_banner_area .banner_inner .banner_content p {
  color: #fff;
  font-family: "Roboto", sans-serif;
  font-weight: 300;
  /* max-width: 450px; */
  margin-bottom: 40px;
  font-size: 14px;
}

.home_banner_area .banner_inner .banner_content .banner_map_img {
  text-align: right;
}

.blog_banner {
  min-height: 780px;
  position: relative;
  z-index: 1;
  overflow: hidden;
  margin-bottom: 0px;
}

.blog_banner .banner_inner {
  background: #04091e;
  position: relative;
  overflow: hidden;
  width: 100%;
  min-height: 780px;
  z-index: 1;
}

.blog_banner .banner_inner .overlay {
  background: url(../img/banner/banner-2.jpg) no-repeat scroll center center;
  opacity: .5;
  height: 125%;
  position: absolute;
  left: 0px;
  top: 0px;
  width: 100%;
  z-index: -1;
}

.blog_banner .banner_inner .blog_b_text {
  max-width: 700px;
  margin: auto;
  color: #fff;
  margin-top: 40px;
}

.blog_banner .banner_inner .blog_b_text h2 {
  font-size: 60px;
  font-weight: 500;
  font-family: "Roboto", sans-serif;
  line-height: 66px;
  margin-bottom: 15px;
}

.blog_banner .banner_inner .blog_b_text p {
  font-size: 16px;
  margin-bottom: 35px;
}

.blog_banner .banner_inner .blog_b_text .white_bg_btn {
  line-height: 42px;
  padding: 0px 45px;
}

.banner_box {
  max-width: 1620px;
  margin: auto;
}

.banner_area {
  position: relative;
  z-index: 1;
  min-height: 400px;
  /* background-image: -moz-linear-gradient(0deg, rgba(188, 43, 255, 0.8) 0%, rgba(114, 73, 251, 0.8) 100%);
  background-image: -webkit-linear-gradient(0deg, rgba(188, 43, 255, 0.8) 0%, rgba(114, 73, 251, 0.8) 100%);
  background-image: -ms-linear-gradient(0deg, rgba(188, 43, 255, 0.8) 0%, rgba(114, 73, 251, 0.8) 100%); */
  background-image: url('https://images.unsplash.com/photo-1574629810360-7efbbe195018?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1156&q=80');
}

.banner_area .banner_inner {
  position: relative;
  overflow: hidden;
  width: 100%;
  min-height: 400px;
  z-index: 1;
}

.banner_area .banner_inner .banner_content {
  margin-top: 85px;
}

.banner_area .banner_inner .banner_content h2 {
  color: #fff;
  font-size: 48px;
  font-family: "Roboto", sans-serif;
  margin-bottom: 0px;
  font-weight: 500;
}

.banner_area .banner_inner .banner_content .page_link a {
  font-size: 14px;
  color: #fff;
  font-family: "Roboto", sans-serif;
  margin-right: 32px;
  position: relative;
  text-transform: uppercase;
}

.banner_area .banner_inner .banner_content .page_link a:before {
  content: "\f0da";
  font: normal normal normal 14px/1 FontAwesome;
  position: absolute;
  right: -25px;
  top: 50%;
  -webkit-transform: translateY(-50%);
  -ms-transform: translateY(-50%);
  transform: translateY(-50%);
}

.banner_area .banner_inner .banner_content .page_link a:last-child {
  margin-right: 0px;
}

.banner_area .banner_inner .banner_content .page_link a:last-child:before {
  display: none;
}

/* End Home Banner Area css
============================================================================================ */
/*---------------------------------------------------- */
/*----------------------------------------------------*/
/* Home latest Blog Area css
============================================================================================ */
.l_news_item {
  background: #fff;
  
  padding: 60px 30px;
  border-radius: 5px;
  -webkit-transition: all 300ms linear 0s;
  -o-transition: all 300ms linear 0s;
  transition: all 300ms linear 0s;
}

.l_news_item .date {
  background: #ffffff;
  color: #777777;
  border: 1px solid #dddddd;
  padding: 0px 18px;
  display: inline-block;
  line-height: 28px;
  border-radius: 3px;
  margin-bottom: 22px;
}

.l_news_item h4 {
  font-size: 20px;
  font-family: "Open Sans", sans-serif;
  font-weight: 600;
  text-transform: uppercase;
  color: #222222;
  line-height: 30px;
  margin-bottom: 15px;
}

.l_news_item p {
  margin-bottom: 22px;
}

.l_news_item .post_view a {
  font-size: 14px;
  font-family: "Roboto", sans-serif;
  font-weight: normal;
  color: #aaaaaa;
  margin-right: 20px;
}

.l_news_item .post_view a i {
  padding-right: 6px;
}

.l_news_item:hover {
  background: #fff;
  -webkit-box-shadow: 0px 10px 30px 0px rgba(0, 0, 0, 0.08);
  box-shadow: 0px 10px 30px 0px rgba(0, 0, 0, 0.08);
}

.l_news_item:hover .date {
  background-image: -webkit-linear-gradient(0deg, #009245 0%, #009245 100%);
  color: #fff;
  border-color: #f9f9ff;
}

.l_news_item:hover h4 {
  background-image: -webkit-linear-gradient(0deg, #009245 0%, #009245 100%);
  color: transparent;
  -webkit-background-clip: text;
  background-clip: text;
}

/* End Home latest Blog Area css
============================================================================================ */
/* Causes Area css
============================================================================================ */
.causes_slider .owl-dots {
  text-align: center;
  margin-top: 80px;
}

.causes_slider .owl-dots .owl-dot {
  height: 14px;
  width: 14px;
  background: #eeeeee;
  display: inline-block;
  margin-right: 7px;
}

.causes_slider .owl-dots .owl-dot:last-child {
  margin-right: 0px;
}

.causes_slider .owl-dots .owl-dot.active {
  background: #6247ea;
}

.causes_item {
  background: #fff;
}

.causes_item .causes_img {
  position: relative;
}

.causes_item .causes_img .c_parcent {
  position: absolute;
  bottom: 0px;
  width: 100%;
  left: 0px;
  height: 3px;
  background: rgba(255, 255, 255, 0.5);
}

.causes_item .causes_img .c_parcent span {
  width: 70%;
  height: 3px;
  background: #6247ea;
  position: absolute;
  left: 0px;
  bottom: 0px;
}

.causes_item .causes_img .c_parcent span:before {
  content: "75%";
  position: absolute;
  right: -10px;
  bottom: 0px;
  background: #6247ea;
  color: #fff;
  padding: 0px 5px;
}

.causes_item .causes_text {
  padding: 30px 35px 40px 30px;
}

.causes_item .causes_text h4 {
  color: #222222;
  font-family: "Roboto", sans-serif;
  font-size: 18px;
  font-weight: 600;
  margin-bottom: 15px;
  cursor: pointer;
}

.causes_item .causes_text h4:hover {
  color: #6247ea;
}

.causes_item .causes_text p {
  font-size: 14px;
  line-height: 24px;
  color: #777777;
  font-weight: 300;
  margin-bottom: 0px;
}

.causes_item .causes_bottom a {
  width: 50%;
  border: 1px solid #6247ea;
  text-align: center;
  float: left;
  line-height: 50px;
  background: #6247ea;
  color: #fff;
  font-family: "Roboto", sans-serif;
  font-size: 14px;
  font-weight: 500;
}

.causes_item .causes_bottom a + a {
  border-color: #eeeeee;
  background: #fff;
  font-size: 14px;
  color: #222222;
}

/* End Causes Area css
============================================================================================ */
/*================= latest_blog_area css =============*/
.latest_blog_area {
  background: #f9f9ff;
}

.single-recent-blog-post {
  margin-bottom: 30px;
}

.single-recent-blog-post .thumb {
  overflow: hidden;
}

.single-recent-blog-post .thumb img {
  -webkit-transition: all 0.7s linear;
  -o-transition: all 0.7s linear;
  transition: all 0.7s linear;
}

.single-recent-blog-post .details {
  padding-top: 30px;
}

.single-recent-blog-post .details .sec_h4 {
  line-height: 24px;
  padding: 10px 0px 13px;
  -webkit-transition: all 0.3s linear;
  -o-transition: all 0.3s linear;
  transition: all 0.3s linear;
}

.single-recent-blog-post .details .sec_h4:hover {
  color: #777777;
}

.single-recent-blog-post .date {
  font-size: 14px;
  line-height: 24px;
  font-weight: 400;
}

.single-recent-blog-post:hover img {
  -webkit-transform: scale(1.23) rotate(10deg);
  -ms-transform: scale(1.23) rotate(10deg);
  transform: scale(1.23) rotate(10deg);
}

.tags .tag_btn {
  font-size: 12px;
  font-weight: 500;
  line-height: 20px;
  border: 1px solid #eeeeee;
  display: inline-block;
  padding: 1px 18px;
  text-align: center;
  color: #222222;
}

.tags .tag_btn:before {
  background: #6247ea;
}

.tags .tag_btn + .tag_btn {
  margin-left: 2px;
}

/*========= blog_categorie_area css ===========*/
.blog_categorie_area {
  padding-top: 80px;
  padding-bottom: 80px;
}

.categories_post {
  position: relative;
  text-align: center;
  cursor: pointer;
}

.categories_post img {
  max-width: 100%;
}

.categories_post .categories_details {
  position: absolute;
  top: 20px;
  left: 20px;
  right: 20px;
  bottom: 20px;
  background: rgba(34, 34, 34, 0.8);
  color: #fff;
  -webkit-transition: all 0.3s linear;
  -o-transition: all 0.3s linear;
  transition: all 0.3s linear;
  display: -webkit-box;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-align: center;
  -ms-flex-align: center;
  align-items: center;
  -webkit-box-pack: center;
  -ms-flex-pack: center;
  justify-content: center;
}

.categories_post .categories_details h5 {
  margin-bottom: 0px;
  font-size: 18px;
  line-height: 26px;
  text-transform: uppercase;
  color: #fff;
  position: relative;
}

.categories_post .categories_details p {
  font-weight: 300;
  font-size: 14px;
  line-height: 26px;
  margin-bottom: 0px;
}

.categories_post .categories_details .border_line {
  margin: 10px 0px;
  background: #fff;
  width: 100%;
  height: 1px;
}

.categories_post:hover .categories_details {
  background-image: -moz-linear-gradient(0deg, rgba(188, 43, 255, 0.8) 0%, rgba(114, 73, 251, 0.8) 100%);
  background-image: -webkit-linear-gradient(0deg, rgba(188, 43, 255, 0.8) 0%, rgba(114, 73, 251, 0.8) 100%);
  background-image: -ms-linear-gradient(0deg, rgba(188, 43, 255, 0.8) 0%, rgba(114, 73, 251, 0.8) 100%);
  background-color: transparent;
}

/*============ blog_left_sidebar css ==============*/
.blog_item {
  margin-bottom: 40px;
}

.blog_info {
  padding-top: 30px;
}

.blog_info .post_tag {
  padding-bottom: 20px;
}

.blog_info .post_tag a {
  font: 300 14px/21px "Roboto", sans-serif;
  color: #222222;
}

.blog_info .post_tag a:hover {
  color: #777777;
}

.blog_info .post_tag a.active {
  color: #6247ea;
}

.blog_info .blog_meta li a {
  font: 300 14px/20px "Roboto", sans-serif;
  color: #777777;
  vertical-align: middle;
  padding-bottom: 12px;
  display: inline-block;
}

.blog_info .blog_meta li a i {
  color: #222222;
  font-size: 16px;
  font-weight: 600;
  padding-left: 15px;
  line-height: 20px;
  vertical-align: middle;
}

.blog_info .blog_meta li a:hover {
  color: #6247ea;
}

.blog_post img {
  max-width: 100%;
}

.blog_details {
  padding-top: 20px;
}

.blog_details h2 {
  font-size: 24px;
  line-height: 36px;
  color: #222222;
  font-weight: 600;
  -webkit-transition: all 0.3s linear;
  -o-transition: all 0.3s linear;
  transition: all 0.3s linear;
}

.blog_details h2:hover {
  color: #6247ea;
}

.blog_details p {
  margin-bottom: 26px;
}

.view_btn {
  font-size: 14px;
  line-height: 36px;
  display: inline-block;
  color: #222222;
  font-weight: 500;
  padding: 0px 30px;
  background: #fff;
}

.blog_right_sidebar {
  border: 1px solid #eeeeee;
  background: #fafaff;
  padding: 30px;
}

.blog_right_sidebar .widget_title {
  font-size: 18px;
  line-height: 25px;
  background-image: -moz-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%);
  background-image: -webkit-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%);
  background-image: -ms-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%);
  text-align: center;
  color: #fff;
  padding: 8px 0px;
  margin-bottom: 30px;
}

.blog_right_sidebar .search_widget .input-group .form-control {
  font-size: 14px;
  line-height: 29px;
  border: 0px;
  width: 100%;
  font-weight: 300;
  color: #fff;
  padding-left: 20px;
  border-radius: 45px;
  z-index: 0;
  background-image: -moz-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%);
  background-image: -webkit-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%);
  background-image: -ms-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%);
}

.blog_right_sidebar .search_widget .input-group .form-control.placeholder {
  color: #fff;
}

.blog_right_sidebar .search_widget .input-group .form-control:-moz-placeholder {
  color: #fff;
}

.blog_right_sidebar .search_widget .input-group .form-control::-moz-placeholder {
  color: #fff;
}

.blog_right_sidebar .search_widget .input-group .form-control::-webkit-input-placeholder {
  color: #fff;
}

.blog_right_sidebar .search_widget .input-group .form-control:focus {
  -webkit-box-shadow: none;
  box-shadow: none;
}

.blog_right_sidebar .search_widget .input-group .btn-default {
  position: absolute;
  right: 20px;
  background: transparent;
  border: 0px;
  -webkit-box-shadow: none;
  box-shadow: none;
  font-size: 14px;
  color: #fff;
  padding: 0px;
  top: 50%;
  -webkit-transform: translateY(-50%);
  -ms-transform: translateY(-50%);
  transform: translateY(-50%);
  z-index: 1;
}

.blog_right_sidebar .author_widget {
  text-align: center;
}

.blog_right_sidebar .author_widget h4 {
  font-size: 18px;
  line-height: 20px;
  color: #222222;
  margin-bottom: 5px;
  margin-top: 30px;
}

.blog_right_sidebar .author_widget p {
  margin-bottom: 0px;
}

.blog_right_sidebar .author_widget .social_icon {
  padding: 7px 0px 15px;
}

.blog_right_sidebar .author_widget .social_icon a {
  font-size: 14px;
  color: #222222;
  -webkit-transition: all 0.2s linear;
  -o-transition: all 0.2s linear;
  transition: all 0.2s linear;
}

.blog_right_sidebar .author_widget .social_icon a + a {
  margin-left: 20px;
}

.blog_right_sidebar .author_widget .social_icon a:hover {
  color: #6247ea;
}

.blog_right_sidebar .popular_post_widget .post_item .media-body {
  -webkit-box-pack: center;
  -ms-flex-pack: center;
  justify-content: center;
  -ms-flex-item-align: center;
  align-self: center;
  padding-left: 20px;
}

.blog_right_sidebar .popular_post_widget .post_item .media-body h3 {
  font-size: 14px;
  line-height: 20px;
  color: #222222;
  margin-bottom: 4px;
  -webkit-transition: all 0.3s linear;
  -o-transition: all 0.3s linear;
  transition: all 0.3s linear;
}

.blog_right_sidebar .popular_post_widget .post_item .media-body h3:hover {
  color: #6247ea;
}

.blog_right_sidebar .popular_post_widget .post_item .media-body p {
  font-size: 12px;
  line-height: 21px;
  margin-bottom: 0px;
}

.blog_right_sidebar .popular_post_widget .post_item + .post_item {
  margin-top: 20px;
}

.blog_right_sidebar .post_category_widget .cat-list li {
  border-bottom: 2px dotted #eee;
  -webkit-transition: all 0.3s ease 0s;
  -o-transition: all 0.3s ease 0s;
  transition: all 0.3s ease 0s;
  padding-bottom: 12px;
}

.blog_right_sidebar .post_category_widget .cat-list li a {
  font-size: 14px;
  line-height: 20px;
  color: #777;
}

.blog_right_sidebar .post_category_widget .cat-list li a p {
  margin-bottom: 0px;
}

.blog_right_sidebar .post_category_widget .cat-list li + li {
  padding-top: 15px;
}

.blog_right_sidebar .post_category_widget .cat-list li:hover {
  border-color: #6247ea;
}

.blog_right_sidebar .post_category_widget .cat-list li:hover a {
  color: #6247ea;
}

.blog_right_sidebar .newsletter_widget {
  text-align: center;
}

.blog_right_sidebar .newsletter_widget .form-group {
  margin-bottom: 8px;
}

.blog_right_sidebar .newsletter_widget .input-group-prepend {
  margin-right: -1px;
}

.blog_right_sidebar .newsletter_widget .input-group-text {
  background: #fff;
  border-radius: 0px;
  vertical-align: top;
  font-size: 12px;
  line-height: 36px;
  padding: 0px 0px 0px 15px;
  border: 1px solid #eeeeee;
  border-right: 0px;
}

.blog_right_sidebar .newsletter_widget .form-control {
  font-size: 12px;
  line-height: 24px;
  color: #cccccc;
  border: 1px solid #eeeeee;
  border-left: 0px;
  border-radius: 0px;
}

.blog_right_sidebar .newsletter_widget .form-control.placeholder {
  color: #cccccc;
}

.blog_right_sidebar .newsletter_widget .form-control:-moz-placeholder {
  color: #cccccc;
}

.blog_right_sidebar .newsletter_widget .form-control::-moz-placeholder {
  color: #cccccc;
}

.blog_right_sidebar .newsletter_widget .form-control::-webkit-input-placeholder {
  color: #cccccc;
}

.blog_right_sidebar .newsletter_widget .form-control:focus {
  outline: none;
  -webkit-box-shadow: none;
  box-shadow: none;
}

.blog_right_sidebar .newsletter_widget .bbtns {
  background-image: -moz-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%);
  background-image: -webkit-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%);
  background-image: -ms-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%);
  color: #fff;
  font-size: 12px;
  line-height: 38px;
  display: inline-block;
  font-weight: 500;
  padding: 0px 24px 0px 24px;
  border-radius: 0;
}

.blog_right_sidebar .newsletter_widget .text-bottom {
  font-size: 12px;
}

.blog_right_sidebar .tag_cloud_widget ul li {
  display: inline-block;
}

.blog_right_sidebar .tag_cloud_widget ul li a {
  display: inline-block;
  border: 1px solid #eee;
  background: #fff;
  padding: 0px 13px;
  margin-bottom: 8px;
  -webkit-transition: all 0.3s ease 0s;
  -o-transition: all 0.3s ease 0s;
  transition: all 0.3s ease 0s;
  color: #222222;
  font-size: 12px;
}

.blog_right_sidebar .tag_cloud_widget ul li a:hover {
  background-image: -moz-linear-gradient(0deg, rgba(188, 43, 255, 0.8) 0%, rgba(114, 73, 251, 0.8) 100%);
  background-image: -webkit-linear-gradient(0deg, rgba(188, 43, 255, 0.8) 0%, rgba(114, 73, 251, 0.8) 100%);
  background-image: -ms-linear-gradient(0deg, rgba(188, 43, 255, 0.8) 0%, rgba(114, 73, 251, 0.8) 100%);
  color: #fff;
}

.blog_right_sidebar .br {
  width: 100%;
  height: 1px;
  background: #eeeeee;
  margin: 30px 0px;
}

.blog-pagination {
  padding-top: 25px;
  padding-bottom: 95px;
}

.blog-pagination .page-link {
  border-radius: 0;
}

.blog-pagination .page-item {
  border: none;
}

.page-link {
  background: transparent;
  font-weight: 400;
}

.blog-pagination .page-item.active .page-link {
  background-color: #6247ea;
  border-color: transparent;
  color: #fff;
}

.blog-pagination .page-link {
  position: relative;
  display: block;
  padding: 0.5rem 0.75rem;
  margin-left: -1px;
  line-height: 1.25;
  color: #8a8a8a;
  border: none;
}

.blog-pagination .page-link .lnr {
  font-weight: 600;
}

.blog-pagination .page-item:last-child .page-link,
.blog-pagination .page-item:first-child .page-link {
  border-radius: 0;
}

.blog-pagination .page-link:hover {
  color: #fff;
  text-decoration: none;
  background-color: #6247ea;
  border-color: #eee;
}

/*============ Start Blog Single Styles  =============*/
.single-post-area .social-links {
  padding-top: 10px;
}

.single-post-area .social-links li {
  display: inline-block;
  margin-bottom: 10px;
}

.single-post-area .social-links li a {
  color: #cccccc;
  padding: 7px;
  font-size: 14px;
  -webkit-transition: all 0.2s linear;
  -o-transition: all 0.2s linear;
  transition: all 0.2s linear;
}

.single-post-area .social-links li a:hover {
  color: #222222;
}

.single-post-area .blog_details {
  padding-top: 26px;
}

.single-post-area .blog_details p {
  margin-bottom: 10px;
}

.single-post-area .quotes {
  margin-top: 20px;
  margin-bottom: 30px;
  padding: 24px 35px 24px 30px;
  background-color: white;
  -webkit-box-shadow: -20.84px 21.58px 30px 0px rgba(176, 176, 176, 0.1);
  box-shadow: -20.84px 21.58px 30px 0px rgba(176, 176, 176, 0.1);
  font-size: 14px;
  line-height: 24px;
  color: #777;
  font-style: italic;
}

.single-post-area .arrow {
  position: absolute;
}

.single-post-area .arrow .lnr {
  font-size: 20px;
  font-weight: 600;
}

.single-post-area .thumb .overlay-bg {
  background: rgba(0, 0, 0, 0.8);
}

.single-post-area .navigation-area {
  border-top: 1px solid #eee;
  padding-top: 30px;
  margin-top: 60px;
}

.single-post-area .navigation-area p {
  margin-bottom: 0px;
}

.single-post-area .navigation-area h4 {
  font-size: 18px;
  line-height: 25px;
  color: #222222;
}

.single-post-area .navigation-area .nav-left {
  text-align: left;
}

.single-post-area .navigation-area .nav-left .thumb {
  margin-right: 20px;
  background: #000;
}

.single-post-area .navigation-area .nav-left .thumb img {
  -webkit-transition: all 300ms linear 0s;
  -o-transition: all 300ms linear 0s;
  transition: all 300ms linear 0s;
}

.single-post-area .navigation-area .nav-left .lnr {
  margin-left: 20px;
  opacity: 0;
  -webkit-transition: all 300ms linear 0s;
  -o-transition: all 300ms linear 0s;
  transition: all 300ms linear 0s;
}

.single-post-area .navigation-area .nav-left:hover .lnr {
  opacity: 1;
}

.single-post-area .navigation-area .nav-left:hover .thumb img {
  opacity: .5;
}

@media (max-width: 767px) {
  .single-post-area .navigation-area .nav-left {
    margin-bottom: 30px;
  }
}

.single-post-area .navigation-area .nav-right {
  text-align: right;
}

.single-post-area .navigation-area .nav-right .thumb {
  margin-left: 20px;
  background: #000;
}

.single-post-area .navigation-area .nav-right .thumb img {
  -webkit-transition: all 300ms linear 0s;
  -o-transition: all 300ms linear 0s;
  transition: all 300ms linear 0s;
}

.single-post-area .navigation-area .nav-right .lnr {
  margin-right: 20px;
  opacity: 0;
  -webkit-transition: all 300ms linear 0s;
  -o-transition: all 300ms linear 0s;
  transition: all 300ms linear 0s;
}

.single-post-area .navigation-area .nav-right:hover .lnr {
  opacity: 1;
}

.single-post-area .navigation-area .nav-right:hover .thumb img {
  opacity: .5;
}

@media (max-width: 991px) {
  .single-post-area .sidebar-widgets {
    padding-bottom: 0px;
  }
}

.comments-area {
  background: #fafaff;
  border: 1px solid #eee;
  padding: 50px 30px;
  margin-top: 50px;
}

@media (max-width: 414px) {
  .comments-area {
    padding: 50px 8px;
  }
}

.comments-area h4 {
  text-align: center;
  margin-bottom: 50px;
  color: #222222;
  font-size: 18px;
}

.comments-area h5 {
  font-size: 16px;
  margin-bottom: 0px;
}

.comments-area a {
  color: #222222;
}

.comments-area .comment-list {
  padding-bottom: 48px;
}

.comments-area .comment-list:last-child {
  padding-bottom: 0px;
}

.comments-area .comment-list.left-padding {
  padding-left: 25px;
}

@media (max-width: 413px) {
  .comments-area .comment-list .single-comment h5 {
    font-size: 12px;
  }
  .comments-area .comment-list .single-comment .date {
    font-size: 11px;
  }
  .comments-area .comment-list .single-comment .comment {
    font-size: 10px;
  }
}

.comments-area .thumb {
  margin-right: 20px;
}

.comments-area .date {
  font-size: 13px;
  color: #cccccc;
  margin-bottom: 13px;
}

.comments-area .comment {
  color: #777777;
  margin-bottom: 0px;
}

.comments-area .btn-reply {
  background-color: #fff;
  color: #222222;
  border: 1px solid #eee;
  padding: 2px 18px;
  font-size: 12px;
  display: block;
  font-weight: 600;
  -webkit-transition: all 300ms linear 0s;
  -o-transition: all 300ms linear 0s;
  transition: all 300ms linear 0s;
}

.comments-area .btn-reply:hover {
  background-color: #6247ea;
  color: #fff;
}

.comment-form {
  background: #fafaff;
  text-align: center;
  border: 1px solid #eee;
  padding: 47px 30px 43px;
  margin-top: 50px;
  margin-bottom: 40px;
}

.comment-form h4 {
  text-align: center;
  margin-bottom: 50px;
  font-size: 18px;
  line-height: 22px;
  color: #222222;
}

.comment-form .name {
  padding-left: 0px;
}

@media (max-width: 767px) {
  .comment-form .name {
    padding-right: 0px;
    margin-bottom: 1rem;
  }
}

.comment-form .email {
  padding-right: 0px;
}

@media (max-width: 991px) {
  .comment-form .email {
    padding-left: 0px;
  }
}

.comment-form .form-control {
  padding: 8px 20px;
  background: #fff;
  border: none;
  border-radius: 0px;
  width: 100%;
  font-size: 14px;
  color: #777777;
  border: 1px solid transparent;
}

.comment-form .form-control:focus {
  -webkit-box-shadow: none;
  box-shadow: none;
  border: 1px solid #eee;
}

.comment-form textarea.form-control {
  height: 140px;
  resize: none;
}

.comment-form ::-webkit-input-placeholder {
  /* Chrome/Opera/Safari */
  font-size: 13px;
  color: #777;
}

.comment-form ::-moz-placeholder {
  /* Firefox 19+ */
  font-size: 13px;
  color: #777;
}

.comment-form :-ms-input-placeholder {
  /* IE 10+ */
  font-size: 13px;
  color: #777;
}

.comment-form :-moz-placeholder {
  /* Firefox 18- */
  font-size: 13px;
  color: #777;
}

/*============ End Blog Single Styles  =============*/
/*---------------------------------------------------- */
/*----------------------------------------------------*/
/* Reservation Form Area css
============================================================================================ */
.reservation_form_area .res_form_inner {
  max-width: 555px;
  margin: auto;
  -webkit-box-shadow: 0px 10px 30px 0px rgba(153, 153, 153, 0.1);
  box-shadow: 0px 10px 30px 0px rgba(153, 153, 153, 0.1);
  padding: 75px 50px;
  position: relative;
}

.reservation_form_area .res_form_inner:before {
  content: "";
  background: url(../img/contact-shap-1.png);
  position: absolute;
  left: -125px;
  height: 421px;
  width: 98px;
  top: 50%;
  -webkit-transform: translateY(-50%);
  -ms-transform: translateY(-50%);
  transform: translateY(-50%);
}

.reservation_form_area .res_form_inner:after {
  content: "";
  background: url(../img/contact-shap-2.png);
  position: absolute;
  right: -125px;
  height: 421px;
  width: 98px;
  top: 50%;
  -webkit-transform: translateY(-50%);
  -ms-transform: translateY(-50%);
  transform: translateY(-50%);
}

.reservation_form .form-group input {
  height: 40px;
  border-radius: 0px;
  border: 1px solid #eeeeee;
  outline: none;
  -webkit-box-shadow: none;
  box-shadow: none;
  padding: 0px 15px;
  font-size: 13px;
  font-family: "Roboto", sans-serif;
  font-weight: 300;
  color: #999999;
}

.reservation_form .form-group input.placeholder {
  font-size: 13px;
  font-family: "Roboto", sans-serif;
  font-weight: 300;
  color: #999999;
}

.reservation_form .form-group input:-moz-placeholder {
  font-size: 13px;
  font-family: "Roboto", sans-serif;
  font-weight: 300;
  color: #999999;
}

.reservation_form .form-group input::-moz-placeholder {
  font-size: 13px;
  font-family: "Roboto", sans-serif;
  font-weight: 300;
  color: #999999;
}

.reservation_form .form-group input::-webkit-input-placeholder {
  font-size: 13px;
  font-family: "Roboto", sans-serif;
  font-weight: 300;
  color: #999999;
}

.reservation_form .form-group .res_select {
  height: 40px;
  border: 1px solid #eeeeee;
  border-radius: 0px;
  width: 100%;
  padding: 0px 15px;
  line-height: 36px;
}

.reservation_form .form-group .res_select .current {
  font-size: 13px;
  font-family: "Roboto", sans-serif;
  font-weight: 300;
  color: #999999;
}

.reservation_form .form-group .res_select:after {
  content: "\e874";
  font-family: 'Linearicons-Free';
  color: #cccccc;
  -webkit-transform: rotate(0deg);
  -ms-transform: rotate(0deg);
  transform: rotate(0deg);
  border: none;
  margin-top: -17px;
  font-size: 13px;
  right: 22px;
}

.reservation_form .form-group:last-child {
  text-align: center;
}

/* End Reservation Form Area css
============================================================================================ */
/*============== contact_area css ================*/
.mapBox {
  height: 420px;
  margin-bottom: 80px;
}

.contact_info .info_item {
  position: relative;
  padding-left: 45px;
}

.contact_info .info_item i {
  position: absolute;
  left: 0;
  top: 0;
  font-size: 20px;
  line-height: 24px;
  color: green;
  font-weight: 600;
}

.contact_info .info_item h6 {
  font-size: 16px;
  line-height: 24px;
  color: "Roboto", sans-serif;
  font-weight: bold;
  margin-bottom: 0px;
  color: #222222;
}

.contact_info .info_item h6 a {
  color: #222222;
}

.contact_info .info_item p {
  font-size: 14px;
  line-height: 24px;
  padding: 2px 0px;
}

.contact_form .form-group {
  margin-bottom: 10px;
}

.contact_form .form-group .form-control {
  font-size: 13px;
  line-height: 26px;
  color: #999;
  border: 1px solid #eeeeee;
  font-family: "Roboto", sans-serif;
  border-radius: 0px;
  padding-left: 20px;
}

.contact_form .form-group .form-control:focus {
  -webkit-box-shadow: none;
  box-shadow: none;
  outline: none;
}

.contact_form .form-group .form-control.placeholder {
  color: #999;
}

.contact_form .form-group .form-control:-moz-placeholder {
  color: #999;
}

.contact_form .form-group .form-control::-moz-placeholder {
  color: #999;
}

.contact_form .form-group .form-control::-webkit-input-placeholder {
  color: #999;
}

.contact_form .form-group textarea {
  resize: none;
}

.contact_form .form-group textarea.form-control {
  height: 140px;
}

.contact_form .submit_btn {
  margin-top: 20px;
  cursor: pointer;
}

/* Contact Success and error Area css
============================================================================================ */
.modal-message .modal-dialog {
  position: absolute;
  top: 36%;
  left: 50%;
  -webkit-transform: translateX(-50%) translateY(-50%) !important;
  -ms-transform: translateX(-50%) translateY(-50%) !important;
  transform: translateX(-50%) translateY(-50%) !important;
  margin: 0px;
  max-width: 500px;
  width: 100%;
}

.modal-message .modal-dialog .modal-content .modal-header {
  text-align: center;
  display: block;
  border-bottom: none;
  padding-top: 50px;
  padding-bottom: 50px;
}

.modal-message .modal-dialog .modal-content .modal-header .close {
  position: absolute;
  right: -15px;
  top: -15px;
  padding: 0px;
  color: #fff;
  opacity: 1;
  cursor: pointer;
}

.modal-message .modal-dialog .modal-content .modal-header h2 {
  display: block;
  text-align: center;
  color: #6247ea;
  padding-bottom: 10px;
  font-family: "Roboto", sans-serif;
}

.modal-message .modal-dialog .modal-content .modal-header p {
  display: block;
}

/* End Contact Success and error Area css
============================================================================================ */
/*---------------------------------------------------- */
/*----------------------------------------------------*/
/*============== Elements Area css ================*/
.mb-20 {
  margin-bottom: 20px;
}

.mb-30 {
  margin-bottom: 30px;
}

.sample-text-area {
  padding: 100px 0px;
}

.sample-text-area .title_color {
  margin-bottom: 30px;
}

.sample-text-area p {
  line-height: 26px;
}

.sample-text-area p b {
  font-weight: bold;
  color: #6247ea;
}

.sample-text-area p i {
  color: #6247ea;
  font-style: italic;
}

.sample-text-area p sup {
  color: #6247ea;
  font-style: italic;
}

.sample-text-area p sub {
  color: #6247ea;
  font-style: italic;
}

.sample-text-area p del {
  color: #6247ea;
}

.sample-text-area p u {
  color: #6247ea;
}

/*============== End Elements Area css ================*/
/*==============Elements Button Area css ================*/
.elements_button .title_color {
  margin-bottom: 30px;
  color: #222222;
}

.title_color {
  color: #222222;
}

.button-group-area {
  margin-top: 15px;
}

.button-group-area:nth-child(odd) {
  margin-top: 40px;
}

.button-group-area:first-child {
  margin-top: 0px;
}

.button-group-area .theme_btn {
  margin-right: 10px;
}

.button-group-area .white_btn {
  margin-right: 10px;
}

.button-group-area .link {
  text-decoration: underline;
  color: #222222;
  background: transparent;
}

.button-group-area .link:hover {
  color: #fff;
}

.button-group-area .disable {
  background: transparent;
  color: #007bff;
  cursor: not-allowed;
}

.button-group-area .disable:before {
  display: none;
}

.primary {
  background: #52c5fd;
}

.primary:before {
  background: #2faae6;
}

.success {
  background: #4cd3e3;
}

.success:before {
  background: #2ebccd;
}

.info {
  background: #38a4ff;
}

.info:before {
  background: #298cdf;
}

.warning {
  background: #f4e700;
}

.warning:before {
  background: #e1d608;
}

.danger {
  background: #f54940;
}

.danger:before {
  background: #e13b33;
}

.primary-border {
  background: transparent;
  border: 1px solid #52c5fd;
  color: #52c5fd;
}

.primary-border:before {
  background: #52c5fd;
}

.success-border {
  background: transparent;
  border: 1px solid #4cd3e3;
  color: #4cd3e3;
}

.success-border:before {
  background: #4cd3e3;
}

.info-border {
  background: transparent;
  border: 1px solid #38a4ff;
  color: #38a4ff;
}

.info-border:before {
  background: #38a4ff;
}

.warning-border {
  background: #fff;
  border: 1px solid #f4e700;
  color: #f4e700;
}

.warning-border:before {
  background: #f4e700;
}

.danger-border {
  background: transparent;
  border: 1px solid #f54940;
  color: #f54940;
}

.danger-border:before {
  background: #f54940;
}

.link-border {
  background: transparent;
  border: 1px solid #6247ea;
  color: #6247ea;
}

.link-border:before {
  background: #6247ea;
}

.radius {
  border-radius: 3px;
}

.circle {
  border-radius: 20px;
}

.arrow span {
  padding-left: 5px;
}

.e-large {
  line-height: 50px;
  padding-top: 0px;
  padding-bottom: 0px;
}

.large {
  line-height: 45px;
  padding-top: 0px;
  padding-bottom: 0px;
}

.medium {
  line-height: 30px;
  padding-top: 0px;
  padding-bottom: 0px;
}

.small {
  line-height: 25px;
  padding-top: 0px;
  padding-bottom: 0px;
}

.general {
  line-height: 38px;
  padding-top: 0px;
  padding-bottom: 0px;
}

/*==============End Elements Button Area css ================*/
/* =================================== */
/*  Elements Page Styles
/* =================================== */
/*---------- Start Elements Page -------------*/
.generic-banner {
  margin-top: 60px;
  text-align: center;
}

.generic-banner .height {
  height: 600px;
}

@media (max-width: 767.98px) {
  .generic-banner .height {
    height: 400px;
  }
}

.generic-banner .generic-banner-content h2 {
  line-height: 1.2em;
  margin-bottom: 20px;
}

@media (max-width: 991.98px) {
  .generic-banner .generic-banner-content h2 br {
    display: none;
  }
}

.generic-banner .generic-banner-content p {
  text-align: center;
  font-size: 16px;
}

@media (max-width: 991.98px) {
  .generic-banner .generic-banner-content p br {
    display: none;
  }
}

.generic-content h1 {
  font-weight: 600;
}

.about-generic-area {
  background: #fff;
}

.about-generic-area p {
  margin-bottom: 20px;
}

.white-bg {
  background: #fff;
}

.section-top-border {
  padding: 50px 0;
  border-top: 1px dotted #eee;
}

.switch-wrap {
  margin-bottom: 10px;
}

.switch-wrap p {
  margin: 0;
}

/*---------- End Elements Page -------------*/
.sample-text-area {
  padding: 100px 0 70px 0;
}

.sample-text {
  margin-bottom: 0;
}

.text-heading {
  margin-bottom: 30px;
  font-size: 24px;
}

.typo-list {
  margin-bottom: 10px;
}

@media (max-width: 767px) {
  .typo-sec {
    margin-bottom: 30px;
  }
}

@media (max-width: 767px) {
  .element-wrap {
    margin-top: 30px;
  }
}

b, sup, sub, u, del {
  color: #f8b600;
}

h1 {
  font-size: 36px;
}

h2 {
  font-size: 30px;
}

h3 {
  font-size: 24px;
}

h4 {
  font-size: 18px;
}

h5 {
  font-size: 16px;
}

h6 {
  font-size: 14px;
}

.typography h1, .typography h2, .typography h3, .typography h4, .typography h5, .typography h6 {
  color: #777777;
}

.button-area .border-top-generic {
  padding: 70px 15px;
  border-top: 1px dotted #eee;
}

.button-group-area .genric-btn {
  margin-right: 10px;
  margin-top: 10px;
}

.button-group-area .genric-btn:last-child {
  margin-right: 0;
}

.circle {
  border-radius: 20px;
}

.genric-btn {
  display: inline-block;
  outline: none;
  line-height: 40px;
  padding: 0 30px;
  font-size: .8em;
  text-align: center;
  text-decoration: none;
  font-weight: 500;
  cursor: pointer;
  -webkit-transition: all 0.3s ease 0s;
  -moz-transition: all 0.3s ease 0s;
  -o-transition: all 0.3s ease 0s;
  transition: all 0.3s ease 0s;
}

.genric-btn:focus {
  outline: none;
}

.genric-btn.e-large {
  padding: 0 40px;
  line-height: 50px;
}

.genric-btn.large {
  line-height: 45px;
}

.genric-btn.medium {
  line-height: 30px;
}

.genric-btn.small {
  line-height: 25px;
}

.genric-btn.radius {
  border-radius: 3px;
}

.genric-btn.circle {
  border-radius: 20px;
}

.genric-btn.arrow {
  display: -webkit-inline-box;
  display: -ms-inline-flexbox;
  display: inline-flex;
  -webkit-box-align: center;
  -ms-flex-align: center;
  align-items: center;
}

.genric-btn.arrow span {
  margin-left: 10px;
}

.genric-btn.default {
  color: #222222;
  background: #f9f9ff;
  border: 1px solid transparent;
}

.genric-btn.default:hover {
  border: 1px solid #f9f9ff;
  background: #fff;
}

.genric-btn.default-border {
  border: 1px solid #f9f9ff;
  background: #fff;
}

.genric-btn.default-border:hover {
  color: #222222;
  background: #f9f9ff;
  border: 1px solid transparent;
}

.genric-btn.primary {
  color: #fff;
  background: #f8b600;
  border: 1px solid transparent;
}

.genric-btn.primary:hover {
  color: #f8b600;
  border: 1px solid #f8b600;
  background: #fff;
}

.genric-btn.primary-border {
  color: #f8b600;
  border: 1px solid #f8b600;
  background: #fff;
}

.genric-btn.primary-border:hover {
  color: #fff;
  background: #f8b600;
  border: 1px solid transparent;
}

.genric-btn.success {
  color: #fff;
  background: #4cd3e3;
  border: 1px solid transparent;
}

.genric-btn.success:hover {
  color: #4cd3e3;
  border: 1px solid #4cd3e3;
  background: #fff;
}

.genric-btn.success-border {
  color: #4cd3e3;
  border: 1px solid #4cd3e3;
  background: #fff;
}

.genric-btn.success-border:hover {
  color: #fff;
  background: #4cd3e3;
  border: 1px solid transparent;
}

.genric-btn.info {
  color: #fff;
  background: #38a4ff;
  border: 1px solid transparent;
}

.genric-btn.info:hover {
  color: #38a4ff;
  border: 1px solid #38a4ff;
  background: #fff;
}

.genric-btn.info-border {
  color: #38a4ff;
  border: 1px solid #38a4ff;
  background: #fff;
}

.genric-btn.info-border:hover {
  color: #fff;
  background: #38a4ff;
  border: 1px solid transparent;
}

.genric-btn.warning {
  color: #fff;
  background: #f4e700;
  border: 1px solid transparent;
}

.genric-btn.warning:hover {
  color: #f4e700;
  border: 1px solid #f4e700;
  background: #fff;
}

.genric-btn.warning-border {
  color: #f4e700;
  border: 1px solid #f4e700;
  background: #fff;
}

.genric-btn.warning-border:hover {
  color: #fff;
  background: #f4e700;
  border: 1px solid transparent;
}

.genric-btn.danger {
  color: #fff;
  background: #f44a40;
  border: 1px solid transparent;
}

.genric-btn.danger:hover {
  color: #f44a40;
  border: 1px solid #f44a40;
  background: #fff;
}

.genric-btn.danger-border {
  color: #f44a40;
  border: 1px solid #f44a40;
  background: #fff;
}

.genric-btn.danger-border:hover {
  color: #fff;
  background: #f44a40;
  border: 1px solid transparent;
}

.genric-btn.link {
  color: #222222;
  background: #f9f9ff;
  text-decoration: underline;
  border: 1px solid transparent;
}

.genric-btn.link:hover {
  color: #222222;
  border: 1px solid #f9f9ff;
  background: #fff;
}

.genric-btn.link-border {
  color: #222222;
  border: 1px solid #f9f9ff;
  background: #fff;
  text-decoration: underline;
}

.genric-btn.link-border:hover {
  color: #222222;
  background: #f9f9ff;
  border: 1px solid transparent;
}

.genric-btn.disable {
  color: #222222, 0.3;
  background: #f9f9ff;
  border: 1px solid transparent;
  cursor: not-allowed;
}

.generic-blockquote {
  padding: 30px 50px 30px 30px;
  background: #fff;
  border-left: 2px solid #f8b600;
}

@media (max-width: 991px) {
  .progress-table-wrap {
    overflow-x: scroll;
  }
}

.progress-table {
  background: #fff;
  padding: 15px 0px 30px 0px;
  min-width: 800px;
}

.progress-table .serial {
  width: 11.83%;
  padding-left: 30px;
}

.progress-table .country {
  width: 28.07%;
}

.progress-table .visit {
  width: 19.74%;
}

.progress-table .percentage {
  width: 40.36%;
  padding-right: 50px;
}

.progress-table .table-head {
  display: -webkit-box;
  display: -ms-flexbox;
  display: flex;
}

.progress-table .table-head .serial, .progress-table .table-head .country, .progress-table .table-head .visit, .progress-table .table-head .percentage {
  color: #222222;
  line-height: 40px;
  text-transform: uppercase;
  font-weight: 500;
}

.progress-table .table-row {
  padding: 15px 0;
  border-top: 1px solid #edf3fd;
  display: -webkit-box;
  display: -ms-flexbox;
  display: flex;
}

.progress-table .table-row .serial, .progress-table .table-row .country, .progress-table .table-row .visit, .progress-table .table-row .percentage {
  display: -webkit-box;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-align: center;
  -ms-flex-align: center;
  align-items: center;
}

.progress-table .table-row .country img {
  margin-right: 15px;
}

.progress-table .table-row .percentage .progress {
  width: 80%;
  border-radius: 0px;
  background: transparent;
}

.progress-table .table-row .percentage .progress .progress-bar {
  height: 5px;
  line-height: 5px;
}

.progress-table .table-row .percentage .progress .progress-bar.color-1 {
  background-color: #6382e6;
}

.progress-table .table-row .percentage .progress .progress-bar.color-2 {
  background-color: #e66686;
}

.progress-table .table-row .percentage .progress .progress-bar.color-3 {
  background-color: #f09359;
}

.progress-table .table-row .percentage .progress .progress-bar.color-4 {
  background-color: #73fbaf;
}

.progress-table .table-row .percentage .progress .progress-bar.color-5 {
  background-color: #73fbaf;
}

.progress-table .table-row .percentage .progress .progress-bar.color-6 {
  background-color: #6382e6;
}

.progress-table .table-row .percentage .progress .progress-bar.color-7 {
  background-color: #a367e7;
}

.progress-table .table-row .percentage .progress .progress-bar.color-8 {
  background-color: #e66686;
}

.single-gallery-image {
  margin-top: 30px;
  background-repeat: no-repeat !important;
  background-position: center center !important;
  background-size: cover !important;
  height: 200px;
  -webkit-transition: all 0.3s ease 0s;
  -moz-transition: all 0.3s ease 0s;
  -o-transition: all 0.3s ease 0s;
  transition: all 0.3s ease 0s;
}

.single-gallery-image:hover {
  opacity: .8;
}

.list-style {
  width: 14px;
  height: 14px;
}

.unordered-list li {
  position: relative;
  padding-left: 30px;
  line-height: 1.82em !important;
}

.unordered-list li:before {
  content: "";
  position: absolute;
  width: 14px;
  height: 14px;
  border: 3px solid #f8b600;
  background: #fff;
  top: 4px;
  left: 0;
  border-radius: 50%;
}

.ordered-list {
  margin-left: 30px;
}

.ordered-list li {
  list-style-type: decimal-leading-zero;
  color: #f8b600;
  font-weight: 500;
  line-height: 1.82em !important;
}

.ordered-list li span {
  font-weight: 300;
  color: #777777;
}

.ordered-list-alpha li {
  margin-left: 30px;
  list-style-type: lower-alpha;
  color: #f8b600;
  font-weight: 500;
  line-height: 1.82em !important;
}

.ordered-list-alpha li span {
  font-weight: 300;
  color: #777777;
}

.ordered-list-roman li {
  margin-left: 30px;
  list-style-type: lower-roman;
  color: #f8b600;
  font-weight: 500;
  line-height: 1.82em !important;
}

.ordered-list-roman li span {
  font-weight: 300;
  color: #777777;
}

.single-input {
  display: block;
  width: 100%;
  line-height: 40px;
  border: none;
  outline: none;
  background: #f9f9ff;
  padding: 0 20px;
}

.single-input:focus {
  outline: none;
}

.input-group-icon {
  position: relative;
}

.input-group-icon .icon {
  position: absolute;
  left: 20px;
  top: 0;
  line-height: 40px;
  z-index: 3;
}

.input-group-icon .icon i {
  color: #797979;
}

.input-group-icon .single-input {
  padding-left: 45px;
}

.single-textarea {
  display: block;
  width: 100%;
  line-height: 40px;
  border: none;
  outline: none;
  background: #f9f9ff;
  padding: 0 20px;
  height: 100px;
  resize: none;
}

.single-textarea:focus {
  outline: none;
}

.single-input-primary {
  display: block;
  width: 100%;
  line-height: 40px;
  border: 1px solid transparent;
  outline: none;
  background: #f9f9ff;
  padding: 0 20px;
}

.single-input-primary:focus {
  outline: none;
  border: 1px solid #f8b600;
}

.single-input-accent {
  display: block;
  width: 100%;
  line-height: 40px;
  border: 1px solid transparent;
  outline: none;
  background: #f9f9ff;
  padding: 0 20px;
}

.single-input-accent:focus {
  outline: none;
  border: 1px solid #eb6b55;
}

.single-input-secondary {
  display: block;
  width: 100%;
  line-height: 40px;
  border: 1px solid transparent;
  outline: none;
  background: #f9f9ff;
  padding: 0 20px;
}

.single-input-secondary:focus {
  outline: none;
  border: 1px solid #f09359;
}

.default-switch {
  width: 35px;
  height: 17px;
  border-radius: 8.5px;
  background: #fff;
  position: relative;
  cursor: pointer;
}

.default-switch input {
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  height: 100%;
  opacity: 0;
  cursor: pointer;
}

.default-switch input + label {
  position: absolute;
  top: 1px;
  left: 1px;
  width: 15px;
  height: 15px;
  border-radius: 50%;
  background: #f8b600;
  -webkit-transition: all 0.2s;
  -moz-transition: all 0.2s;
  -o-transition: all 0.2s;
  transition: all 0.2s;
  -webkit-box-shadow: 0px 4px 5px 0px rgba(0, 0, 0, 0.2);
  box-shadow: 0px 4px 5px 0px rgba(0, 0, 0, 0.2);
  cursor: pointer;
}

.default-switch input:checked + label {
  left: 19px;
}

.single-element-widget {
  margin-bottom: 30px;
}

.primary-switch {
  width: 35px;
  height: 17px;
  border-radius: 8.5px;
  background: #fff;
  position: relative;
  cursor: pointer;
}

.primary-switch input {
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  height: 100%;
  opacity: 0;
}

.primary-switch input + label {
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  height: 100%;
}

.primary-switch input + label:before {
  content: "";
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  height: 100%;
  background: transparent;
  border-radius: 8.5px;
  cursor: pointer;
  -webkit-transition: all 0.2s;
  -moz-transition: all 0.2s;
  -o-transition: all 0.2s;
  transition: all 0.2s;
}

.primary-switch input + label:after {
  content: "";
  position: absolute;
  top: 1px;
  left: 1px;
  width: 15px;
  height: 15px;
  border-radius: 50%;
  background: #fff;
  -webkit-transition: all 0.2s;
  -moz-transition: all 0.2s;
  -o-transition: all 0.2s;
  transition: all 0.2s;
  -webkit-box-shadow: 0px 4px 5px 0px rgba(0, 0, 0, 0.2);
  box-shadow: 0px 4px 5px 0px rgba(0, 0, 0, 0.2);
  cursor: pointer;
}

.primary-switch input:checked + label:after {
  left: 19px;
}

.primary-switch input:checked + label:before {
  background: #f8b600;
}

.confirm-switch {
  width: 35px;
  height: 17px;
  border-radius: 8.5px;
  background: #fff;
  position: relative;
  cursor: pointer;
}

.confirm-switch input {
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  height: 100%;
  opacity: 0;
}

.confirm-switch input + label {
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  height: 100%;
}

.confirm-switch input + label:before {
  content: "";
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  height: 100%;
  background: transparent;
  border-radius: 8.5px;
  -webkit-transition: all 0.2s;
  -moz-transition: all 0.2s;
  -o-transition: all 0.2s;
  transition: all 0.2s;
  cursor: pointer;
}

.confirm-switch input + label:after {
  content: "";
  position: absolute;
  top: 1px;
  left: 1px;
  width: 15px;
  height: 15px;
  border-radius: 50%;
  background: #fff;
  -webkit-transition: all 0.2s;
  -moz-transition: all 0.2s;
  -o-transition: all 0.2s;
  transition: all 0.2s;
  -webkit-box-shadow: 0px 4px 5px 0px rgba(0, 0, 0, 0.2);
  box-shadow: 0px 4px 5px 0px rgba(0, 0, 0, 0.2);
  cursor: pointer;
}

.confirm-switch input:checked + label:after {
  left: 19px;
}

.confirm-switch input:checked + label:before {
  background: #4cd3e3;
}

.primary-checkbox {
  width: 16px;
  height: 16px;
  border-radius: 3px;
  background: #fff;
  position: relative;
  cursor: pointer;
}

.primary-checkbox input {
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  height: 100%;
  opacity: 0;
}

.primary-checkbox input + label {
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  height: 100%;
  border-radius: 3px;
  cursor: pointer;
  border: 1px solid #f1f1f1;
}

.single-defination h4 {
  color: #222222;
}

.primary-checkbox input:checked + label {
  background: url(../img/elements/primary-check.png) no-repeat center center/cover;
  border: none;
}

.confirm-checkbox {
  width: 16px;
  height: 16px;
  border-radius: 3px;
  background: #fff;
  position: relative;
  cursor: pointer;
}

.confirm-checkbox input {
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  height: 100%;
  opacity: 0;
}

.confirm-checkbox input + label {
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  height: 100%;
  border-radius: 3px;
  cursor: pointer;
  border: 1px solid #f1f1f1;
}

.confirm-checkbox input:checked + label {
  background: url(../img/elements/success-check.png) no-repeat center center/cover;
  border: none;
}

.disabled-checkbox {
  width: 16px;
  height: 16px;
  border-radius: 3px;
  background: #fff;
  position: relative;
  cursor: pointer;
}

.disabled-checkbox input {
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  height: 100%;
  opacity: 0;
}

.disabled-checkbox input + label {
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  height: 100%;
  border-radius: 3px;
  cursor: pointer;
  border: 1px solid #f1f1f1;
}

.disabled-checkbox input:disabled {
  cursor: not-allowed;
  z-index: 3;
}

.disabled-checkbox input:checked + label {
  background: url(../img/elements/disabled-check.png) no-repeat center center/cover;
  border: none;
}

.primary-radio {
  width: 16px;
  height: 16px;
  border-radius: 8px;
  background: #fff;
  position: relative;
  cursor: pointer;
}

.primary-radio input {
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  height: 100%;
  opacity: 0;
}

.primary-radio input + label {
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  height: 100%;
  border-radius: 8px;
  cursor: pointer;
  border: 1px solid #f1f1f1;
}

.primary-radio input:checked + label {
  background: url(../img/elements/primary-radio.png) no-repeat center center/cover;
  border: none;
}

.confirm-radio {
  width: 16px;
  height: 16px;
  border-radius: 8px;
  background: #fff;
  position: relative;
  cursor: pointer;
}

.confirm-radio input {
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  height: 100%;
  opacity: 0;
}

.confirm-radio input + label {
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  height: 100%;
  border-radius: 8px;
  cursor: pointer;
  border: 1px solid #f1f1f1;
}

.confirm-radio input:checked + label {
  background: url(../img/elements/success-radio.png) no-repeat center center/cover;
  border: none;
}

.disabled-radio {
  width: 16px;
  height: 16px;
  border-radius: 8px;
  background: #fff;
  position: relative;
  cursor: pointer;
}

.disabled-radio input {
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  height: 100%;
  opacity: 0;
}

.disabled-radio input + label {
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  height: 100%;
  border-radius: 8px;
  cursor: pointer;
  border: 1px solid #f1f1f1;
}

.disabled-radio input:disabled {
  cursor: not-allowed;
  z-index: 3;
}

.unordered-list {
  list-style: none;
  padding: 0px;
  margin: 0px;
}

.ordered-list {
  list-style: none;
  padding: 0px;
}

.disabled-radio input:checked + label {
  background: url(../img/elements/disabled-radio.png) no-repeat center center/cover;
  border: none;
}

.default-select {
  height: 40px;
}

.default-select .nice-select {
  border: none;
  border-radius: 0px;
  height: 40px;
  background: #fff;
  padding-left: 20px;
  padding-right: 40px;
}

.default-select .nice-select .list {
  margin-top: 0;
  border: none;
  border-radius: 0px;
  -webkit-box-shadow: none;
  box-shadow: none;
  width: 100%;
  padding: 10px 0 10px 0px;
}

.default-select .nice-select .list .option {
  font-weight: 300;
  -webkit-transition: all 0.3s ease 0s;
  -moz-transition: all 0.3s ease 0s;
  -o-transition: all 0.3s ease 0s;
  transition: all 0.3s ease 0s;
  line-height: 28px;
  min-height: 28px;
  font-size: 12px;
  padding-left: 20px;
}

.default-select .nice-select .list .option.selected {
  color: #f8b600;
  background: transparent;
}

.default-select .nice-select .list .option:hover {
  color: #f8b600;
  background: transparent;
}

.default-select .current {
  margin-right: 50px;
  font-weight: 300;
}

.default-select .nice-select::after {
  right: 20px;
}

@media (max-width: 991px) {
  .left-align-p p {
    margin-top: 20px;
  }
}

.form-select {
  height: 40px;
  width: 100%;
}

.form-select .nice-select {
  border: none;
  border-radius: 0px;
  height: 40px;
  background: #f9f9ff !important;
  padding-left: 45px;
  padding-right: 40px;
  width: 100%;
}

.form-select .nice-select .list {
  margin-top: 0;
  border: none;
  border-radius: 0px;
  -webkit-box-shadow: none;
  box-shadow: none;
  width: 100%;
  padding: 10px 0 10px 0px;
}

.mt-10 {
  margin-top: 10px;
}

.form-select .nice-select .list .option {
  font-weight: 300;
  -webkit-transition: all 0.3s ease 0s;
  -moz-transition: all 0.3s ease 0s;
  -o-transition: all 0.3s ease 0s;
  transition: all 0.3s ease 0s;
  line-height: 28px;
  min-height: 28px;
  font-size: 12px;
  padding-left: 45px;
}

.form-select .nice-select .list .option.selected {
  color: #f8b600;
  background: transparent;
}

.form-select .nice-select .list .option:hover {
  color: #f8b600;
  background: transparent;
}

.form-select .current {
  margin-right: 50px;
  font-weight: 300;
}

.form-select .nice-select::after {
  right: 20px;
}

/*---------------------------------------------------- */
/*----------------------------------------------------*/
/* Main Button Area css
============================================================================================ */
.main_btn {
  padding: 0px 45px;
  /* background-image: -webkit-gradient(linear, left top, right top, from(#bc2bff), color-stop(51%, #7249fb), to(#bc2bff));
  background-image: -webkit-linear-gradient(left, #bc2bff 0%, #7249fb 51%, #bc2bff 100%);
  background-image: -o-linear-gradient(left, #bc2bff 0%, #7249fb 51%, #bc2bff 100%);
  background-image: linear-gradient(to right, #bc2bff 0%, #7249fb 51%, #bc2bff 100%); */
  background-size: 200% auto;
  background-color: #049444;
  color: white !important;
  z-index: 2;
  display: inline-block;
  -webkit-transition: all 400ms linear;
  -o-transition: all 400ms linear;
  transition: all 400ms linear;
  text-align: center;
  color: #fff;
  font-size: 13px;
  font-weight: 600;
  font-family: "Open Sans", sans-serif;
  line-height: 50px;
  border-radius: 5px;
  -webkit-box-shadow: 0px 10px 30px 0px rgba(115, 73, 251, 0.3);
  box-shadow: 0px 10px 30px 0px rgba(115, 73, 251, 0.3);
}

.main_btn:hover {
  background-position: right center;
  color: #fff;
}

.main_btn2 {
  display: inline-block;
  background: #f9f9ff;
  padding: 0px 45px;
  color: #222222;
  font-family: "Open Sans", sans-serif;
  font-size: 13px;
  font-weight: 600;
  line-height: 48px;
  border-radius: 5px;
  outline: none !important;
  -webkit-box-shadow: none !important;
  box-shadow: none !important;
  text-align: center;
  border: 1px solid #dddddd;
  cursor: pointer;
  -webkit-transition: color 0ms linear;
  -o-transition: color 0ms linear;
  transition: color 0ms linear;
}

.main_btn2:hover {
  background-color: #049444;
  -webkit-box-shadow: 0px 10px 30px 0px rgba(115, 73, 251, 0.3);
  box-shadow: 0px 10px 30px 0px rgba(115, 73, 251, 0.3);
  color: #fff;
}

.submit_btn {
  width: auto;
  display: inline-block;
background-color: #049444;
  background-size: 200% auto;
  padding: 0px 50px;
  color: #fff;
  font-family: "Roboto", sans-serif;
  font-size: 13px;
  font-weight: 500;
  line-height: 50px;
  border-radius: 5px;
  outline: none !important;
  -webkit-box-shadow: none !important;
  box-shadow: none !important;
  text-align: center;
  cursor: pointer;
  -webkit-transition: all 300ms linear 0s;
  -o-transition: all 300ms linear 0s;
  transition: all 300ms linear 0s;
}

.submit_btn:hover {
  background-position: right center;
  color: #fff;
}

.white_btn {
  display: inline-block;
  background: #f9f9ff;
  padding: 0px 50px;
  color: #222222;
  font-family: "Roboto", sans-serif;
  font-size: 12px;
  font-weight: 500;
  line-height: 50px;
  border-radius: 0px;
  outline: none !important;
  -webkit-box-shadow: none !important;
  box-shadow: none !important;
  text-align: center;
  cursor: pointer;
  -webkit-transition: all 300ms linear 0s;
  -o-transition: all 300ms linear 0s;
  transition: all 300ms linear 0s;
}

.white_btn:hover {
  background: #6247ea;
  color: #fff;
}

.banner_btn {
  padding: 0px 45px;
  line-height: 50px;
  background: #fff;
  color: #222222;
  display: inline-block;
  border-radius: 5px;
  font-size: 13px;
  font-family: "Open Sans", sans-serif;
  font-weight: 600;
  -webkit-transition: all 300ms linear 0s;
  -o-transition: all 300ms linear 0s;
  transition: all 300ms linear 0s;
}

.banner_btn:hover {
  color: #222222;
  -webkit-box-shadow: 0px 20px 20px 0px rgba(0, 0, 0, 0.1);
  box-shadow: 0px 20px 20px 0px rgba(0, 0, 0, 0.1);
}

.white_bg_btn {
  background: #fff;
  display: inline-block;
  color: #222222;
  line-height: 40px;
  padding: 0px 28px;
  font-size: 14px;
  font-family: "Roboto", sans-serif;
  font-weight: 500;
  text-transform: uppercase;
  -webkit-transition: all 300ms linear 0s;
  -o-transition: all 300ms linear 0s;
  transition: all 300ms linear 0s;
  border: none;
}

.white_bg_btn:hover {
  background: #6247ea;
  color: #fff;
}

.blog_btn {
  border: 1px solid #eeeeee;
  background: #f9f9ff;
  padding: 0px 32px;
  font-size: 13px;
  font-weight: 500;
  font-family: "Roboto", sans-serif;
  border-radius: 5px;
  color: #222222;
  line-height: 34px;
  display: inline-block;
}

.blog_btn:hover {
  background-image: -moz-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%);
  background-image: -webkit-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%);
  background-image: -ms-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%);
  border-color: #fff;
  color: #fff;
}

/* End Main Button Area css
============================================================================================ */
/*---------------------------------------------------- */
/*----------------------------------------------------*/
/* Feature Area css
============================================================================================ */
.feature_item {
  -webkit-box-shadow: 0px 10px 30px 0px rgba(0, 0, 0, 0.08);
  box-shadow: 0px 10px 30px 0px rgba(0, 0, 0, 0.08);
  padding: 50px 30px;
  border-radius: 5px;
  text-align: center;
}

.feature_item img {
  margin-bottom: 35px;
}

.feature_item h4 {
  color: #222222;
  font-size: 20px;
  font-family: "Open Sans", sans-serif;
  font-weight: 600;
  margin-bottom: 15px;
}

.feature_item p {
  margin-bottom: 0px;
}

/* End Feature Area css
============================================================================================ */
/* End Feature Area css
============================================================================================ */
.interior_area {
  /* background: #f9faff; */
  padding-top: 65px;
  padding-bottom: 65px;
}

.interior_area.interior_two {
  background: #fff;
}

.interior_inner .col-lg-5 {
  vertical-align: middle;
  -ms-flex-item-align: center;
  align-self: center;
}

.interior_inner .interior_text h4 {
  color: #222222;
  font-family: "Boing", '-apple-system, BlinkMacSystemFont', "Segoe UI", 'Roboto',
  Helvetica, Arial, sans-serif, "Apple Color Emoji", "Segoe UI Emoji",
  "Segoe UI Symbol";
  font-weight: 800;
  line-height: 45px;
  font-size: 36px;
  margin-bottom: 30px;
}

.interior_inner .interior_text p {
  margin-bottom: 40px;
}

/* End Feature Area css
============================================================================================ */
/* Download App Area css
============================================================================================ */
.download_app_area {
  background-image: -webkit-linear-gradient(0deg, #009245 0%, #009245 100%);

}

.app_inner {
  max-width: 780px;
  margin: auto;
  text-align: center;
}

.app_inner h2 {
  color: #fff;
  font-size: 36px;
  font-family: "Open Sans", sans-serif;
  font-weight: 600;
  margin-bottom: 18px;
}

.app_inner p {
  color: #fff;
  margin-bottom: 40px;
}

.app_btn_area .app_btn {
  display: inline-block;
  border: 1px solid #eeeeee;
  padding-top: 12px;
  padding-bottom: 12px;
  padding-left: 30px;
  padding-right: 30px;
  border-radius: 5px;
  margin-right: 16px;
  @inlcude transition;
}

.app_btn_area .app_btn:hover {
  background: #fff;
  -webkit-box-shadow: 0px 20px 20px 0px rgba(0, 0, 0, 0.1);
  box-shadow: 0px 20px 20px 0px rgba(0, 0, 0, 0.1);
}

.app_btn_area .app_btn:hover .media .d-flex i {
  background: -webkit-linear-gradient(left, #bb2bff, #7349fb);
  background: -webkit-gradient(linear, left top, right top, from(#bb2bff), to(#7349fb));
  background: -o-linear-gradient(left, #bb2bff, #7349fb);
  background: linear-gradient(left, #bb2bff, #7349fb);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.app_btn_area .app_btn:hover .media .media-body h4 {
  color: #222222;
}

.app_btn_area .app_btn:hover .media .media-body p {
  color: #222222;
}

.app_btn_area .media {
  text-align: left;
}

.app_btn_area .media .d-flex {
  vertical-align: middle;
  -ms-flex-item-align: center;
  align-self: center;
  padding-right: 22px;
}

.app_btn_area .media .d-flex i {
  font-size: 40px;
  color: #fff;
}

.app_btn_area .media .media-body {
  vertical-align: middle;
  -ms-flex-item-align: center;
  align-self: center;
  color: #fff;
}

.app_btn_area .media .media-body h4 {
  margin-bottom: 0px;
  color: #fff;
  font-size: 24px;
  font-family: "Open Sans", sans-serif;
  font-weight: 600;
  -webkit-transition: all 300ms linear 0s;
  -o-transition: all 300ms linear 0s;
  transition: all 300ms linear 0s;
}

.app_btn_area .media .media-body p {
  margin-bottom: 0px;
  font-size: 14px;
  font-family: "Roboto", sans-serif;
  font-weight: normal;
  -webkit-transition: all 300ms linear 0s;
  -o-transition: all 300ms linear 0s;
  transition: all 300ms linear 0s;
}

/* End Download App Area css
============================================================================================ */
/*---------------------------------------------------- */
/*----------------------------------------------------*/
/* Video Area css
============================================================================================ */
.video_area {
  position: relative;
  text-align: center;
  margin-top: 65px;
  margin-bottom: 35px;
}

.video_area a {
  position: absolute;
  top: 50%;
  left: 50%;
  -webkit-transform: translateX(-50%) translateY(-50%);
  -ms-transform: translateX(-50%) translateY(-50%);
  transform: translateX(-50%) translateY(-50%);
}

/**
 * Simple fade transition,
 */
.mfp-fade.mfp-bg {
  opacity: 0;
  -webkit-transition: all 0.15s ease-out;
  -moz-transition: all 0.15s ease-out;
  -o-transition: all 0.15s ease-out;
  transition: all 0.15s ease-out;
}

.mfp-fade.mfp-bg.mfp-ready {
  opacity: 0.8;
}

.mfp-fade.mfp-bg.mfp-removing {
  opacity: 0;
}

.mfp-fade.mfp-wrap .mfp-content {
  opacity: 0;
  -webkit-transition: all 0.15s ease-out;
  -moz-transition: all 0.15s ease-out;
  -o-transition: all 0.15s ease-out;
  transition: all 0.15s ease-out;
}

.mfp-fade.mfp-wrap.mfp-ready .mfp-content {
  opacity: 1;
}

.mfp-fade.mfp-wrap.mfp-removing .mfp-content {
  opacity: 0;
}

/* End Video Area css
============================================================================================ */
/*---------------------------------------------------- */
/*----------------------------------------------------*/
/* Price Area css
============================================================================================ */
.price_area {
  background: #f9f9ff;
}

.price_item {
  background: #fff;
}

.price_item .price_head {
  overflow: hidden;
  border-bottom: 1px solid #eeeeee;
  padding: 40px;
}

.price_item .price_head h3 {
  color: #222222;
  font-size: 20px;
  font-family: "Open Sans", sans-serif;
  margin-bottom: 5px;
}

.price_item .price_head h2 {
  color: #222222;
  margin-bottom: 0px;
  font-weight: bold;
  font-size: 36px;
  font-family: "Roboto", sans-serif;
}

.price_item .price_head p {
  margin-bottom: 0px;
}

.price_item .price_body {
  text-align: center;
  padding-top: 30px;
  padding-bottom: 30px;
}

.price_item .price_body .list li {
  margin-bottom: 10px;
}

.price_item .price_body .list li a {
  font-size: 14px;
  font-family: "Roboto", sans-serif;
  font-weight: normal;
  color: #777777;
}

.price_item .price_body .list li:last-child {
  margin-bottom: 0px;
}

.price_item .price_footer {
  text-align: center;
  padding-bottom: 40px;
}

/* End Price Area css
============================================================================================ */
/*---------------------------------------------------- */
/*----------------------------------------------------*/
/* Testimonials Area css
============================================================================================ */
.testimonials_area {
  /* background: #f9f9ff; */
  position: relative;
}

.testimonials_area .owl-prev, .testimonials_area .owl-next {
  position: absolute;
  right: 150px;
  background: #fff;
  font-size: 24px;
  color: #c1c1c1;
  padding-left: 10px;
  padding-right: 10px;
  -webkit-transition: all 300ms linear 0s;
  -o-transition: all 300ms linear 0s;
  transition: all 300ms linear 0s;
  cursor: pointer;
  -webkit-box-shadow: -14.142px 14.142px 20px 0px rgba(157, 157, 157, 0.2);
  box-shadow: -14.142px 14.142px 20px 0px rgba(157, 157, 157, 0.2);
}

.testimonials_area .owl-prev:hover, .testimonials_area .owl-next:hover {
  color: #222222;
}

.testimonials_area .owl-prev {
  bottom: 50%;
  padding-top: 15px;
  padding-bottom: 10px;
}

.testimonials_area .owl-prev:before {
  content: "";
  width: 28px;
  background: #e8e8e8;
  position: absolute;
  left: 50%;
  -webkit-transform: translateX(-50%);
  -ms-transform: translateX(-50%);
  transform: translateX(-50%);
  bottom: 0px;
  height: 1px;
}

.testimonials_area .owl-next {
  top: 50%;
  padding-top: 10px;
  padding-bottom: 15px;
}

.testi_slider {
  margin-top: -30px;
  margin-bottom: -30px;
}

.testi_item {
  padding: 30px 0px;
}

.testi_item .media {
  border-radius: 10px;
  padding: 40px;
  background: #fff;
  -webkit-transition: all 300ms linear 0s;
  -o-transition: all 300ms linear 0s;
  transition: all 300ms linear 0s;
}

.testi_item .media .d-flex {
  padding-right: 25px;
}

.testi_item .media .media-body p {
  margin-bottom: 20px;
}

.testi_item .media .media-body h4 {
  color: #222222;
  font-family: "Roboto", sans-serif;
  font-weight: 500;
  font-size: 20px;
  -webkit-transition: all 300ms linear 0s;
  -o-transition: all 300ms linear 0s;
  transition: all 300ms linear 0s;
}

.testi_item .media .media-body h5 {
  margin-bottom: 0px;
  font-size: 14px;
  color: #777777;
  font-weight: normal;
  font-family: "Roboto", sans-serif;
}

.testi_item:hover .media {
  -webkit-box-shadow: 0px 10px 30px 0px rgba(157, 157, 157, 0.2);
  box-shadow: 0px 10px 30px 0px rgba(157, 157, 157, 0.2);
  background: #fff;
  border-color: #fff;
}

.testi_item:hover .media .media-body h4 {
  background-image: -webkit-gradient(linear, left top, right top, color-stop(0, #bc2bff), color-stop(0.15, #bc2bff), color-stop(0.3, #7249fb), color-stop(0.45, #7249fb), color-stop(0.6, #7249fb), color-stop(0.75, #7249fb), color-stop(0.9, #7249fb), color-stop(1, #7249fb));
  background-image: gradient(linear, left top, right top, color-stop(0, #bc2bff), color-stop(0.15, #bc2bff), color-stop(0.3, #7249fb), color-stop(0.45, #7249fb), color-stop(0.6, #7249fb), color-stop(0.75, #7249fb), color-stop(0.9, #7249fb), color-stop(1, #7249fb));
  color: transparent;
  -webkit-background-clip: text;
  background-clip: text;
}

/* End Testimonials Area css
============================================================================================ */
/*---------------------------------------------------- */
/*----------------------------------------------------*/
/*============== footer-area css ===============*/
.footer-area {
  background: #222222;
}

.single-footer-widget p {
  margin-bottom: 0px;
}

.single-footer-widget .instafeed {
  margin-left: -5px;
  margin-right: -5px;
}

.single-footer-widget .instafeed li {
  margin: 5px;
}

.single-footer-widget .subscribe_form {
  padding-top: 25px;
}

.single-footer-widget .input-group {
  display: block !important;
}

.single-footer-widget input {
  max-width: 100%;
  width: 100%;
  border: 1px solid #333333;
  font-size: 13px;
  line-height: 40px;
  padding-right: 110px;
  height: 40px;
  color: #999999;
  border-radius: 20px;
  background: #fff;
  padding-left: 20px;
}

.single-footer-widget input.placeholder {
  color: #999999;
}

.single-footer-widget input:-moz-placeholder {
  color: #999999;
}

.single-footer-widget input::-moz-placeholder {
  color: #999999;
}

.single-footer-widget input::-webkit-input-placeholder {
  color: #999999;
}

.single-footer-widget input:focus {
  outline: none;
}

.single-footer-widget .sub-btn {
  /* background-image: -moz-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%);
  background-image: -webkit-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%);
  background-image: -ms-linear-gradient(0deg, #bc2bff 0%, #7249fb 100%); */
  background-color: #049444;
  color: #fff;
  font-weight: 500;
  line-height: 38px;
  font-size: 12px;
  padding: 0px 38px;
  display: inline-block;
  cursor: pointer;
  /* position: absolute; */
  top: 0px;
  right: -26px;
  border-radius: 20px;
  -webkit-transition: all 300ms linear 0s;
  -o-transition: all 300ms linear 0s;
  transition: all 300ms linear 0s;
  outline: none !important;
  -webkit-box-shadow: none !important;
  box-shadow: none !important;
}

.ab_wd p {
  max-width: 230px;
}

.contact_wd {
  margin-right: -15px;
}

.contact_wd p {
  margin-bottom: 15px;
}

.contact_wd a {
  display: block;
  color: #6247ea;
  font-size: 24px;
  font-family: "Roboto", sans-serif;
  font-weight: 500;
  margin-bottom: 10px;
}

.contact_wd a + a {
  margin-bottom: 0px;
}

.tp_widgets .list li {
  margin-bottom: 12px;
}

.tp_widgets .list li a {
  color: #fff;
  font-size: 14px;
  font-weight: 300;
  font-family: "Roboto", sans-serif;
}

.tp_widgets .list li:last-child {
  margin-bottom: 0px;
}

.news_widgets p {
  color: #fff;
  opacity: .6;
}

.footer_title {
  font-size: 20px;
  line-height: 24px;
  font-weight: 600;
  font-family: "Open Sans", sans-serif;
  color: #fff;
  margin-bottom: 28px;
  text-transform: uppercase;
}

.border_line {
  width: 100%;
  height: 1px;
  background: #333333;
  margin-top: 30px;
}

.footer-bottom {
  padding-top: 85px;
}

.footer-bottom .footer-text {
  color: #fff;
  opacity: .6;
}

.footer-bottom .footer-text i {
  color: #6247ea;
  opacity: 1;
}

.footer-bottom .footer-text a {
  color: #6247ea;
  opacity: 1;
}

.footer-bottom .footer-social {
  text-align: right;
}

.footer-bottom .footer-social a {
  font-size: 14px;
  line-height: 30px;
  color: #fff;
  margin-left: 6px;
  -webkit-transition: all 0.3s linear;
  -o-transition: all 0.3s linear;
  transition: all 0.3s linear;
  background: #111111;
  height: 30px;
  width: 30px;
  text-align: center;
  display: inline-block;
  -webkit-transition: all 300ms linear 0s;
  -o-transition: all 300ms linear 0s;
  transition: all 300ms linear 0s;
}

.footer-bottom .footer-social a:hover {
  color: #fff;
  background-image: -moz-linear-gradient(0deg, rgba(188, 43, 255, 0.8) 0%, rgba(114, 73, 251, 0.8) 100%);
  background-image: -webkit-linear-gradient(0deg, rgba(188, 43, 255, 0.8) 0%, rgba(114, 73, 251, 0.8) 100%);
  background-image: -ms-linear-gradient(0deg, rgba(188, 43, 255, 0.8) 0%, rgba(114, 73, 251, 0.8) 100%);
}


/*---------------------------------------------------- */

/*# sourceMappingURL=style.css.map */