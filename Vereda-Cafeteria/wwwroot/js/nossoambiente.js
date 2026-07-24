document.addEventListener("DOMContentLoaded", function () {
    const overlay = document.getElementById("ambienteModalOverlay");
    const modalImg = document.getElementById("ambienteModalImg");
    const imagens = document.querySelectorAll(".ambiente-img");

    imagens.forEach(function (img) {
        img.addEventListener("click", function () {
            modalImg.src = img.src;
            modalImg.alt = img.alt;
            overlay.classList.add("active");
        });
    });

    overlay.addEventListener("click", function (e) {
        if (e.target === overlay) {
            overlay.classList.remove("active");
        }
    });
});