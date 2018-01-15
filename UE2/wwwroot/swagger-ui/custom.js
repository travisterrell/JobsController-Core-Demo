(function () {
    var logo = document.getElementById("logo");
    logo.href = "#";

    var logoImg = document.getElementsByClassName("logo__img")[0];
    logoImg.alt = "Vestcom";
    logoImg.src = "/swagger-ui/logo.png";
    //logoImg.width = 496;

    var logoText = document.getElementsByClassName("logo__title")[0];
    logoText.textContent = "UE2 Documentation";
})();
