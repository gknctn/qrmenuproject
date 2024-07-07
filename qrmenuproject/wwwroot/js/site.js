// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function showDiv(divId) {
    // Tüm divleri gizle
    var divs = document.querySelectorAll('.my-div');
    divs.forEach(function (div) {
        div.style.display = 'none';
    });
    // Seçilen divi göster
    document.getElementById(divId).style.display = 'block';
}

document.getElementById('menuToggleOpen').addEventListener('click', function () {
    const menu = document.getElementById('menu');
    const menuToggleOpen = document.getElementById('menuToggleOpen');
    const menuToggleClose = document.getElementById('menuToggleClose');

    menu.style.display = 'flex';
    menuToggleOpen.classList.add('hide');
    menuToggleClose.classList.add('show');
});

document.getElementById('menuToggleClose').addEventListener('click', function () {
    const menu = document.getElementById('menu');
    const menuToggleOpen = document.getElementById('menuToggleOpen');
    const menuToggleClose = document.getElementById('menuToggleClose');

    menu.style.display = 'none';
    menuToggleOpen.classList.remove('hide');
    menuToggleClose.classList.remove('show');
});

var swiper = new Swiper(".slide-content", {
    slidesPerView: 3,
    spaceBetween: 25,
    loop: true,
    centerSlide: 'true',
    fade: 'true',
    grabCursor: 'true',
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
        dynamicBullets: true,
    },
    navigation: {
        nextEl: ".swiper-button-next",
        prevEl: ".swiper-button-prev",
    },

    breakpoints: {
        0: {
            slidesPerView: 1,
        },
        520: {
            slidesPerView: 2,
        },
        950: {
            slidesPerView: 4,
        },
    },
});
