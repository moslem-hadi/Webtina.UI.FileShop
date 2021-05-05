/*
Template Name: Miver - LMS & Freelance Services Marketplace for Businesses HTML Template
Author: Askbootstrap
Author URI: https://themeforest.net/user/askbootstrap
Version: 1.0
*/

$(document).ready(function () {
  "use strict";

  //   //
  //   $("body").on("contextmenu", function (e) {
  //     return false;
  //   });
  //   $(document).keydown(function (e) {
  //     if (
  //       e.ctrlKey &&
  //       (e.keyCode === 67 ||
  //         e.keyCode === 86 ||
  //         e.keyCode === 85 ||
  //         e.keyCode === 117)
  //     ) {
  //       return false;
  //     }
  //     if (e.which === 123) {
  //       return false;
  //     }
  //     if (e.metaKey) {
  //       return false;
  //     }
  //     //document.onkeydown = function(e) {
  //     // "I" key
  //     if (e.ctrlKey && e.shiftKey && e.keyCode == 73) {
  //       return false;
  //     }
  //     // "J" key
  //     if (e.ctrlKey && e.shiftKey && e.keyCode == 74) {
  //       return false;
  //     }
  //     // "S" key + macOS
  //     if (
  //       e.keyCode == 83 &&
  //       (navigator.platform.match("Mac") ? e.metaKey : e.ctrlKey)
  //     ) {
  //       return false;
  //     }
  //     if (
  //       e.keyCode == 224 &&
  //       (navigator.platform.match("Mac") ? e.metaKey : e.ctrlKey)
  //     ) {
  //       return false;
  //     }
  //     // "U" key
  //     if (e.ctrlKey && e.keyCode == 85) {
  //       return false;
  //     }
  //     // "F12" key
  //     if (event.keyCode == 123) {
  //       return false;
  //     }
  //   });

  /* Select2 */
  $("select").select2();

  /* Tooltip */
  $('[data-toggle="tooltip"]').tooltip();

  /* index */
  $(".recent-slider").slick({
    slidesToShow: 4,
    slidesToScroll: 1,
    arrows: true,
    fade: false,
    rtl: true,
    responsive: [
      {
        breakpoint: 1099,
        settings: {
          slidesToShow: 4,
        },
      },
      {
        breakpoint: 1024,
        settings: {
          slidesToShow: 3,
        },
      },
      {
        breakpoint: 600,
        settings: {
          slidesToShow: 1,
        },
      },
    ],
  });

  $(".freelance-slider").slick({
    slidesToShow: 4,
    slidesToScroll: 1,
    arrows: true,
    fade: false,
    rtl: true,
    responsive: [
      {
        breakpoint: 1099,
        settings: {
          slidesToShow: 4,
        },
      },
      {
        breakpoint: 1024,
        settings: {
          slidesToShow: 2,
        },
      },
      {
        breakpoint: 600,
        settings: {
          slidesToShow: 1,
        },
      },
    ],
  });
  $(".service-slider").slick({
    slidesToShow: 5,
    slidesToScroll: 1,
    arrows: true,
    fade: false,
    rtl: true,
    responsive: [
      {
        breakpoint: 1099,
        settings: {
          slidesToShow: 4,
        },
      },
      {
        breakpoint: 1024,
        settings: {
          slidesToShow: 3,
        },
      },
      {
        breakpoint: 600,
        settings: {
          slidesToShow: 2,
        },
      },
    ],
  });

  /* web design */
  $(function () {
    $("#aniimated-thumbnials").lightGallery({
      thumbnail: true,
      rtl: true,
    });

    $(".slider-for").slick({
      slidesToShow: 1,
      slidesToScroll: 1,
      arrows: true,
      rtl: true,
      adaptiveHeight: true,
      asNavFor: ".slider-nav",
    });

    $(".recommend").slick({
      slidesToShow: 2,
      slidesToScroll: 1,
      arrows: true,
      rtl: true,
      fade: false,
    });

    $(".slider-nav").slick({
      slidesToShow: 4,
      slidesToScroll: 1,
      asNavFor: ".slider-for",
      dots: false,
      arrows: true,
      rtl: true,
        focusOnSelect: true,
      variableWidth: true,
      responsive: [
        {
          breakpoint: 1099,
          settings: {
            slidesToShow: 4,
          },
        },
        {
          breakpoint: 1024,
          settings: {
            slidesToShow: 2,
          },
        },
        {
          breakpoint: 600,
          settings: {
            slidesToShow: 1,
          },
        },
      ],
    });



      $('.view').slick({
          slidesToShow: 4,
          slidesToScroll: 1,
          arrows: true,
          fade: false,
          rtl:true,
          responsive: [{
              breakpoint: 1099,
              settings: {
                  slidesToShow: 4,
              }
          },
          {
              breakpoint: 1024,
              settings: {
                  slidesToShow: 2,
              }
          },
          {
              breakpoint: 600,
              settings: {
                  slidesToShow: 1,
              }
          }

          ]
      });

  });
  /* profile */

  ///* wireframe */
  //$("#aniimated-thumbnials").lightGallery({
  //  thumbnail: true 
  //});

  //$(".slider-for").slick({
  //  slidesToShow: 1,
  //  slidesToScroll: 1,
  //  arrows: true,
  //  rtl: true,
  //  fade: true,
  //  adaptiveHeight: true,
  //  asNavFor: ".slider-nav",
  //});

  //$(".recommend").slick({
  //  slidesToShow: 2,
  //  slidesToScroll: 1,
  //  arrows: true,
  //  fade: false,
  //  rtl: true,
  //  responsive: [
  //    {
  //      breakpoint: 767,
  //      settings: {
  //        slidesToShow: 1,
  //      },
  //    },
  //  ],
  //});

  //$(".view").slick({
  //  slidesToShow: 4,
  //  slidesToScroll: 1,
  //  arrows: true,
  //  fade: false,
  //  rtl: true,
  //  responsive: [
  //    {
  //      breakpoint: 1099,
  //      settings: {
  //        slidesToShow: 4,
  //      },
  //    },
  //    {
  //      breakpoint: 1024,
  //      settings: {
  //        slidesToShow: 2,
  //      },
  //    },
  //    {
  //      breakpoint: 600,
  //      settings: {
  //        slidesToShow: 1,
  //      },
  //    },
  //  ],
  //});

  //$(".slider-nav").slick({
  //  slidesToShow: 4,
  //  slidesToScroll: 1,
  //  asNavFor: ".slider-for",
  //  dots: false,
  //  arrows: true,
  //  rtl: true,
  //  focusOnSelect: true,
  //  variableWidth: true,
  //  responsive: [
  //    {
  //      breakpoint: 1099,
  //      settings: {
  //        slidesToShow: 4,
  //      },
  //    },
  //    {
  //      breakpoint: 1024,
  //      settings: {
  //        slidesToShow: 3,
  //      },
  //    },
  //    {
  //      breakpoint: 600,
  //      settings: {
  //        slidesToShow: 1,
  //      },
  //    },
  //  ],
  //});
});
$(".dropdown").hover(
  function () {
    $(this).find(".dropdown-menu").stop(true, true).delay(200).fadeIn("fast");
  },
  function () {
    $(this).find(".dropdown-menu").stop(true, true).delay(200).fadeOut("fast");
  }
);

$(".dropdown-menu").hover(
  function () {
    $(this).stop(true, true);
  },
  function () {
    $(this).stop(true, true).delay(200).fadeOut("fast");
  }
);
