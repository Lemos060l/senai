$ (document).ready(function () {

  $("#barras").click(function () {
    $("#submenu").toggleClass("submenu-ativo")

  })

//   $("$carrosel img:eq(0)").addClass("banner-ativo").show()

//   setInterval(slide, 1000)

//   function slide() {
//     if ($(".banner-ativo").next().length) {
//       $(".banner-ativo").removeClass("banner-ativo").hide().next().addClass("banner-ativo").show()
//     } else {
//       (".banner-ativo").removeClass().hide()
//       $("$carrosel img:eq(0)").addClass("banner-ativo").show()
//     }
//   }

})

// let menu = document.getElementById("submenu")

// function mostrarSubmenu() {
//   if (submenu.style.display == "none") {
//     submenu.style.display = "flex"
//   } else {
//     submenu.style.display = "none"
//   }
// }

function mostrarPopup() {
  window.alert("Bem Vindo")
}