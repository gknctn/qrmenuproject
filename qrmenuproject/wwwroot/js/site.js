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

document.addEventListener("DOMContentLoaded", function () {
    const cards = document.querySelectorAll('.gallery .card');

    // İlk kartı normal hale getir
    if (cards.length > 0) {
        cards[0].classList.add('active');
    }

    cards.forEach(card => {
        card.addEventListener('click', function () {
            // Tüm kartların bulanık olmasını sağla
            cards.forEach(c => c.classList.remove('active'));
            // Tıklanan karta 'active' sınıfı ekle
            this.classList.add('active');
        });
    });
});
